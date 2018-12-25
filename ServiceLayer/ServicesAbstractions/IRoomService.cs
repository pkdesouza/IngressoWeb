using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServicesAbstractions
{
	public interface IRoomService
	{
		Task<IEnumerable<ListMovieTheaterRoomModel>> GetMovieTheatersAsync();

		Task<IEnumerable<ListRoomModel>> GetRoomsAsync(int id);

		Task AddRoomAsync(CreateRoomModel createRoomModel);

		Task EditRoomAsync(EditRoomModel editRoomModel);

		Task DeleteRoomAsync(DeleteRoomModel deleteRoom);

		Task<DetailsRoomModel> DetailsRoomAsync(int Id);

		Task<GetCreateRoomModel> GetCreateRoomAsync(int Id);

		bool ValidateRoom(int movieTheater, int roomNumber, out string errorMessage);
	}
}
