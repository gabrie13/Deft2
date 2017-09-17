﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Deft2.Models;
using Deft2.Services;

namespace Deft2.Controllers
{
    public class PositionController : Controller
    {
        private Deft2DB db = new Deft2DB();
        private readonly IPositionService _positionService = new PositionService();

        // GET: Position
        // ADDED SEARCH PARAMETER TO INDEX METHOD
        public ActionResult Index(string searchString)
        {
            var positions = from p in db.Positions
                            select p;
        if (!String.IsNullOrEmpty(searchString))
        {
            positions = positions.Where(partial => partial.PositionTitle.Contains(searchString));
        }
            return View(_positionService.GetAll());
        }

        // GET: Position/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionViewModel position = _positionService.FindById(id.Value);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // GET: Position/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Position/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PositionId,PositionTitle")] PositionViewModel position)
        {
            if (ModelState.IsValid)
            {
                _positionService.Create(position);
                return RedirectToAction("Index");
            }

            return View(position);
        }

        // GET: Position/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionViewModel position = _positionService.FindById(id.Value);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Position/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PositionId,PositionTitle")] PositionViewModel position)
        {
            if (ModelState.IsValid)
            {
                _positionService.Save(position);
                return RedirectToAction("Index");
            }
            return View(position);
        }

        // GET: Position/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionViewModel position = _positionService.FindById(id.Value);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Position/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PositionViewModel position = _positionService.FindById(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _positionService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
