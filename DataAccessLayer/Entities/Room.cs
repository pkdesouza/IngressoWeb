using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class Room
    {
        public Room()
        {
            Session = new HashSet<Session>();
        }

        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int MovieTheater { get; set; }

        public MovieTheater MovieTheaterNavigation { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}
