using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.DTO;
using ServiceLayer.ServicesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
	public class SessionService : ISessionService
	{
		private readonly IngressoWebContext Context;

		public SessionService(IngressoWebContext context)
		{
			Context = context;
		}

		public async Task AddSessionAsync(CreateSessionModel createSessionModel)
		{
			await Context.Session.AddAsync(new Session
			{
				Movie = createSessionModel.Movie,
				Room = createSessionModel.Room,
				StartDate = createSessionModel.StartDate,
				EndDate = createSessionModel.EndDate
			});
			await Context.SaveChangesAsync();
		}

		public async Task DeleteSessionAsync(DeleteSessionModel deleteSession)
		{
			Context.Session.Remove(await Context.Session.FindAsync(deleteSession.Id));
			await Context.SaveChangesAsync();
		}

		public async Task<DetailsSessionModel> DetailsSessionAsync(int Id)
		{
			var ListMovies = await Context.Movie.Where(x => x.Active).Select(x => new ListMovieModel
			{
				Id = x.Id,
				Name = x.Name
			}).ToListAsync();

			return await Context.Session.Where(x => x.Id == Id).Select(x => new DetailsSessionModel
			{
				Id = x.Id,
				Movie = x.Movie,
				StartDate = x.StartDate,
				EndDate = x.EndDate,
				Room = x.Room,
				ListMovies = ListMovies,
				ListRooms = Context.Room.Where(a => a.MovieTheater == x.RoomNavigation.MovieTheater)
				.Select(a => new DetailsRoomModel
				{
					Id = a.Id,
					RoomNumber = a.RoomNumber
				}).ToList()
			}).FirstOrDefaultAsync();
		}
		public async Task EditSessionAsync(EditSessionModel editSessionModel)
		{
			var session = await Context.Session.FindAsync(editSessionModel.Id);
			session.Movie = editSessionModel.Movie;
			session.Room = editSessionModel.Room;
			session.StartDate = editSessionModel.StartDate;
			session.EndDate = editSessionModel.EndDate;
			await Context.SaveChangesAsync();
		}

		public async Task<GetCreateSessionModel> GetCreateSessionAsync(int Id)
		{
			var ListRooms = await Context.Room.Where(x => x.MovieTheater == Id && x.MovieTheaterNavigation.Active).Select(x => new DetailsRoomModel
				{
					Id = x.Id,
					RoomNumber = x.RoomNumber
				}).ToListAsync();
			var ListMovies = await Context.Movie.Where(x => x.Active).Select(x => new ListMovieModel {
					Id = x.Id,
					Name = x.Name
				}).ToListAsync();
			return new GetCreateSessionModel
			{
				ListMovies = ListMovies,
				ListRooms = ListRooms,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddHours(2),
				MovieTheater = Id
			};
		}

		public async Task<IEnumerable<ListSessionMovieTheaterModel>> GetMovieTheatersAsync()
		{
			return await Context.MovieTheater.AsNoTracking().Where(x => x.Active).Select(x => new ListSessionMovieTheaterModel
			{
				Id = x.Id,
				NameMovieTheater = x.Name,
				CityNameMovieTheater = x.CityNavigation.Name,
				StateMovieTheater = x.CityNavigation.State,
				QuantitySessions = Context.Session.Count(a => a.RoomNavigation.MovieTheater == x.Id)}
			).ToListAsync();
		}

		public async Task<IEnumerable<ListSessionModel>> GetSessionsAsync(int id)
		{
			return await (from s in Context.Session
						  join r in Context.Room on s.Room equals r.Id
						  join mt in Context.MovieTheater on r.MovieTheater equals mt.Id
						  join m in Context.Movie on s.Movie equals m.Id
						  where mt.Id == id
						  select new ListSessionModel
						  {
							  Id = s.Id,
							  StartDate = s.StartDate,
							  EndDate = s.EndDate,
							  Movie = s.Movie,
							  NameMovieTheater = mt.Name,
							  NameMovie = m.Name,
							  Room = r.Id,
							  RoomNumber = r.RoomNumber
						  }).ToListAsync();
		}
	}
}
