using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class City
    {
        public City()
        {
            MovieTheater = new HashSet<MovieTheater>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public ICollection<MovieTheater> MovieTheater { get; set; }
    }
}
