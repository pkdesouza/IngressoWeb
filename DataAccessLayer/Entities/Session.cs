using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class Session
    {
        public int Id { get; set; }
        public int Movie { get; set; }
        public int Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Movie MovieNavigation { get; set; }
        public Room RoomNavigation { get; set; }
    }
}
