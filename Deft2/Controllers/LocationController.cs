using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Deft2.Models;
using Deft2.Services;
using PagedList;

namespace Deft2.Controllers
{
    public class LocationController : Controller
    {
        private Deft2DB db = new Deft2DB();
        private readonly ILocationService _locationService = new LocationService();

        // GET: Location
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.NameLocationSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            var location = from l in db.Locations
                           select l;
            if(searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

             if(!String.IsNullOrEmpty(searchString))
            {
                location = location.Where(l => l.LocationName.Contains(searchString));
            }

             switch(sortOrder)
            {
                case "name_desc":
                    location = location.OrderByDescending(l => l.LocationName);
                    break;
                default:
                    location = location.OrderBy(l => l.LocationName);
                    break;
            }

            return View(_locationService.GetAll());
        }

        // GET: Location/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationViewModel location = _locationService.FindById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocationId,LocationName,Address,City,State,ZipCode,Phone,Email,ClosedSunday")] LocationViewModel location)
        {
            if (ModelState.IsValid)
            {
                _locationService.Create(location);
                return RedirectToAction("Index");
            }

            return View(location);
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationViewModel location = _locationService.FindById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Location/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationId,LocationName,Address,City,State,ZipCode,Phone,Email,ClosedSunday")] LocationViewModel location)
        {
            if (ModelState.IsValid)
            {
                _locationService.Save(location);
                return RedirectToAction("Index");
            }
            return View(location);
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationViewModel location = _locationService.FindById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _locationService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _locationService.Dispose();
            }
            base.Dispose(disposing);
        }

        int pageSize = 3;
        int pageNumber = (page ?? 1);
        return View(locations.ToPagedList(pageNumber, pageList);
    }
}
