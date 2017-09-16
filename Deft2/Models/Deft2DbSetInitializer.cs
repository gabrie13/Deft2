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

            base.Seed(context);
        }
    }
}