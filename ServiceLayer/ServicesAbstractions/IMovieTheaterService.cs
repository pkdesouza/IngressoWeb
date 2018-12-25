using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServicesAbstractions
{
	public interface IMovieTheaterService
	{
		Task<IEnumerable<ListMovieTheaterModel>> GetMovieTheatersAsync();

		Task AddMovieTheaterAsync(CreateMovieTheaterModel createMovieTheaterModel);

		Task EditMovieTheaterAsync(EditMovieTheaterModel editMovieTheaterModel);

		Task DeleteMovieTheaterAsync(int id);

		Task<DetailsMovieTheaterModel> DetailsMovieTheaterAsync(int Id);
	}
}
