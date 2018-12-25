using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServicesAbstractions
{
	public interface ISessionService
	{
		Task<IEnumerable<ListSessionMovieTheaterModel>> GetMovieTheatersAsync();

		Task<IEnumerable<ListSessionModel>> GetSessionsAsync(int id);

		Task AddSessionAsync(CreateSessionModel createSessionModel);

		Task EditSessionAsync(EditSessionModel editSessionModel);

		Task DeleteSessionAsync(DeleteSessionModel deleteSession);

		Task<DetailsSessionModel> DetailsSessionAsync(int Id);

		Task<GetCreateSessionModel> GetCreateSessionAsync(int Id);
	}
}
