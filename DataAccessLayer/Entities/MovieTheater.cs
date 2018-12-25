using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class MovieTheater
    {
        public MovieTheater()
        {
            Room = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberAddress { get; set; }
        public int ZipCode { get; set; }
        public int City { get; set; }
		public string StreetName { get; set; }
		public bool Active { get; set; }

		public City CityNavigation { get; set; }
        public ICollection<Room> Room { get; set; }
    }
}
