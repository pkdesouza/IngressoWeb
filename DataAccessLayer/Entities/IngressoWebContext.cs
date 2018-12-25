using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Entities
{
    public partial class IngressoWebContext : DbContext
    {
        public IngressoWebContext()
        {
        }

        public IngressoWebContext(DbContextOptions<IngressoWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieTheater> MovieTheater { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Session> Session { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				//optionsBuilder.UseSqlServer("Server=PKBOOK;Database=IngressoWeb;Trusted_Connection=True;");
				optionsBuilder.UseSqlServer("Data Source=sql5035.site4now.net;Initial Catalog=DB_A43E3C_ingressoWeb;User ID=DB_A43E3C_ingressoWeb_admin;Password=ingresso@123;");
			}
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModificationDate)
                    .HasColumnName("lastModificationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

				entity.Property(e => e.Image)
					.HasColumnName("image")
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.Property(e => e.Trailer)
					.HasColumnName("trailer")
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.AgeRating).HasColumnName("ageRating");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registrationDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReleaseYear).HasColumnName("releaseYear");

                entity.Property(e => e.Synopsis)
                    .HasColumnName("synopsis")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovieTheater>(entity =>
            {
                entity.HasIndex(e => new { e.NumberAddress, e.ZipCode })
                    .HasName("movieTheaterPK")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

				entity.Property(e => e.StreetName)
				   .IsRequired()
				   .HasColumnName("streetName")
				   .HasMaxLength(100)
				   .IsUnicode(false);

				entity.Property(e => e.Active)
				   .HasColumnName("active")
				   .HasDefaultValueSql("((1))");

				entity.Property(e => e.NumberAddress).HasColumnName("numberAddress");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.MovieTheater)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieTheat__city__403A8C7D");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasIndex(e => new { e.RoomNumber, e.MovieTheater })
                    .HasName("roomPK")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.MovieTheater).HasColumnName("movieTheater");

                entity.Property(e => e.RoomNumber).HasColumnName("roomNumber");

                entity.HasOne(d => d.MovieTheaterNavigation)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.MovieTheater)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__movieTheat__44FF419A");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasIndex(e => new { e.Movie, e.Room, e.StartDate })
                    .HasName("sessionPK")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Movie).HasColumnName("movie");

                entity.Property(e => e.Room).HasColumnName("room");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MovieNavigation)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.Movie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Session__movie__49C3F6B7");

                entity.HasOne(d => d.RoomNavigation)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.Room)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Session__room__48CFD27E");
            });
        }
    }
}
