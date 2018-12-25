using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class Movie
    {
        public Movie()
        {
            Session = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public int AgeRating { get; set; }
        public decimal Price { get; set; }
        public int ReleaseYear { get; set; }
		public string Image { get; set; }
		public string Trailer { get; set; }
		public DateTime? RegistrationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public bool Active { get; set; }

        public ICollection<Session> Session { get; set; }
    }
}
