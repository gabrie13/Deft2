using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Deft2.Models
{
    public class Deft2DbSetInitializer : DropCreateDatabaseAlways<Deft2DB>
    {
        protected override void Seed(Deft2DB context)
        {
            //  DB.POSITION SEEDED
            context.Positions.Add(new Position { PositionTitle = "Super User" });
            context.Positions.Add(new Position { PositionTitle = "Corporate Admin" });
            context.Positions.Add(new Position { PositionTitle = "Corporate Restricted" });
            context.Positions.Add(new Position { PositionTitle = "Maintanence" });
            context.Positions.Add(new Position { PositionTitle = "Director" });
            context.Positions.Add(new Position { PositionTitle = "Regional" });
            context.Positions.Add(new Position { PositionTitle = "General Manager" });
            context.Positions.Add(new Position { PositionTitle = "Asst General Manager" });
            context.Positions.Add(new Position { PositionTitle = "Kitchen Manager" });
            context.Positions.Add(new Position { PositionTitle = "Shift Lead" });
            context.Positions.Add(new Position { PositionTitle = "Prep Cook" });
            context.Positions.Add(new Position { PositionTitle = "Line Cook" });
            context.Positions.Add(new Position { PositionTitle = "Cashier" });
            context.Positions.Add(new Position { PositionTitle = "Lobby" });
            //  DB.POSITION END

            //  DB.LOCATION SEEDED
            context.Locations.Add(new Location { LocationName = "Corporate Office", Phone = "801-971-2554", Email = "brandon@rumbi.com", Address = "3865 Wasatch Blvd # 300", City = "Salt Lake City", State = "UT", ZipCode = "84109", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Chandler", Phone = "480-785-4537", Email = "chandler@rumbi.com", Address = "885 North 54th St STE #5", City = "Chandler", State = "AZ", ZipCode = "85226", ClosedSunday = false });
            context.Locations.Add(new Location { LocationName = "Mesa", Phone = "480-539-5593", Email = "mesa@rumbi.com", Address = "1902 South Val Vista Dr, STE 101", City = "Mesa", State = "AZ", ZipCode = "85201", ClosedSunday = false });
            context.Locations.Add(new Location { LocationName = "Franklin", Phone = "208-375-5864", Email = "franklin@rumbi.com", Address = "8675 West Franklin Rd", City = "Boise", State = "ID", ZipCode = "83709", ClosedSunday = false });
            context.Locations.Add(new Location { LocationName = "Idaho Falls", Phone = "208-525-9283", Email = "idahofalls@rumbi.com", Address = "2035 South 25th East", City = "Idaho Falls", State = "ID", ZipCode = "83406", ClosedSunday = false });
            context.Locations.Add(new Location { LocationName = "Meridian", Phone = "208-884-5511", Email = "meridian@rumbi.com", Address = "3327 North Eagle Rd #165", City = "Meridian", State = "ID", ZipCode = "83646", ClosedSunday = false });
            context.Locations.Add(new Location { LocationName = "4th South", Phone = "801-530-1000", Email = "4thsouth@rumbi.com", Address = "358 South 700 East", City = "Salt Lake City", State = "UT", ZipCode = "84102", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Bountiful", Phone = "801-294-0176", Email = "bountiful@rumbi.com", Address = "71 North 500 West STE #C", City = "West Bountiful", State = "UT", ZipCode = "84010", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Draper", Phone = "801-572-2558", Email = "draper@rumbi.com", Address = "148 East 12300 South STE B", City = "Draper", State = "UT", ZipCode = "84020", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Ft. Union", Phone = "801-568-3201", Email = "ftunion@rumbi.com", Address = "936 East Ft. Union Blvd Unit #66", City = "Midvale", State = "UT", ZipCode = "84047", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Jordan Landing", Phone = "801-280-9733", Email = "jlanding@rumbi.com", Address = "7251 South Plaza", City = "West Jordan", State = "UT", ZipCode = "84084", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Layton", Phone = "801-614-5020", Email = "layton@rumbi.com", Address = "748 West Antelope Dr STE A", City = "Layton", State = "UT", ZipCode = "84041", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Lehi", Phone = "801-756-3783", Email = "lehi@rumbi.com", Address = "987 West 500 North", City = "American Fork", State = "UT", ZipCode = "84003", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Logan", Phone = "435-753-4300", Email = "logan@rumbi.com", Address = "970 South Highway 89/91", City = "Logan", State = "UT", ZipCode = "84321", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Murray", Phone = "801-266-5700", Email = "murray@rumbi.com", Address = "5269 South State St", City = "Murray", State = "UT", ZipCode = "84107", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Orem", Phone = "801-655-1164", Email = "orem@rumbi.com", Address = "299 East University Pkwy", City = "Orem", State = "UT", ZipCode = "84058", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Provo", Phone = "801-607-1120", Email = "provo@rumbi.com", Address = "62 West Bulldog Blvd STE 104", City = "Provo", State = "UT", ZipCode = "84602", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Riverdale", Phone = "801-392-4440", Email = "riverdale@rumbi.com", Address = "41943 Riverdale Rd", City = "Riverdale", State = "UT", ZipCode = "84405", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Sandy", Phone = "801-523-3610", Email = "sandy@rumbi.com", Address = "10365 South State St", City = "Sandy", State = "UT", ZipCode = "84070", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "St.George", Phone = "435-429-1895", Email = "stgeorge@rumbi.com", Address = "740 West Telegraph St", City = "St George", State = "UT", ZipCode = "84780", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "Sugarhouse", Phone = "801-485-2277", Email = "sugarhouse@rumbi.com", Address = "675 East 2100 South", City = "Salt Lake City", State = "UT", ZipCode = "84106", ClosedSunday = true });
            context.Locations.Add(new Location { LocationName = "West Valley", Phone = "801-968-1537", Email = "westvalley@rumbi.com", Address = "3603 South 2700 West", City = "West Valley", State = "UT", ZipCode = "84119", ClosedSunday = true });
            //  DB.LOCATION END
            base.Seed(context);
        }
    }
}