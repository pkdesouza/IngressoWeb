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
	public class RoomService : IRoomService
	{
		private readonly IngressoWebContext Context;

		public RoomService(IngressoWebContext context)
		{
			Context = context;
		}

		public async Task AddRoomAsync(CreateRoomModel createRoomModel)
		{
			await Context.Room.AddAsync(new Room
			{
				RoomNumber = createRoomModel.RoomNumber,
				Capacity = createRoomModel.Capacity,
				MovieTheater = createRoomModel.Id
			});
			await Context.SaveChangesAsync();
		}

		public async Task DeleteRoomAsync(DeleteRoomModel deleteRoom)
		{
			var sessions = Context.Session.Where(x => x.Room == deleteRoom.Id);
			Context.Session.RemoveRange(sessions);
			Context.Room.Remove(await Context.Room.FindAsync(deleteRoom.Id));
			await Context.SaveChangesAsync();
		}

		public async Task<DetailsRoomModel> DetailsRoomAsync(int Id)
		{
			return await Context.Room.Select(x => new DetailsRoomModel
			{
				Id = x.Id,
				QuantitySessions = x.Session.Count(),
				Capacity = x.Capacity,
				RoomNumber = x.RoomNumber
			}).FirstOrDefaultAsync(x => x.Id == Id);
		}

		public async Task EditRoomAsync(EditRoomModel editRoomModel)
		{
			var room = await Context.Room.FindAsync(editRoomModel.Id);
			room.RoomNumber = editRoomModel.RoomNumber;
			room.Capacity = editRoomModel.Capacity;
			await Context.SaveChangesAsync();
		}

		public async Task<GetCreateRoomModel> GetCreateRoomAsync(int Id)
		{
			return new GetCreateRoomModel { Id = Id};
		}

		public async Task<IEnumerable<ListMovieTheaterRoomModel>> GetMovieTheatersAsync()
		{
			return await Context.MovieTheater.AsNoTracking().Where(x => x.Active).Select(x => new ListMovieTheaterRoomModel
			{
				IdMovieTheater = x.Id,
				NameMovieTheater = x.Name,
				CityNameMovieTheater = x.CityNavigation.Name,
				StateMovieTheater = x.CityNavigation.State,
				QuantityRooms = x.Room.Count()
			}).ToListAsync();
		}

		public async Task<IEnumerable<ListRoomModel>> GetRoomsAsync(int id)
		{
			return await Context.Room.AsNoTracking().Where(x => x.MovieTheater == id && x.MovieTheaterNavigation.Active).Select(x => new ListRoomModel
			{
				Id = x.Id,
				Capacity = x.Capacity,
				IdMovieTheater = x.MovieTheater,
				RoomNumber = x.RoomNumber,
				NameMovieTheater = x.MovieTheaterNavigation.Name
			}).ToListAsync();
		}

		public bool ValidateRoom(int movieTheater, int roomNumber, out string errorMessage)
		{
			errorMessage = "Número de sala já existente, favor digite outro número";
			return Context.Room.FirstOrDefault(x => x.MovieTheater == movieTheater && x.RoomNumber == roomNumber) == null;
		}
	}
}
