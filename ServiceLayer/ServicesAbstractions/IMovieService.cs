using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServicesAbstractions
{
	public interface IMovieService
	{
		Task<IEnumerable<ListMovieModel>> GetMoviesAsync();

		Task AddMovieAsync(CreateMovieModel createMovieModel);

		Task<DetailsMovieModel> DetailMovieAsync(int Id);

		Task EditMovieAsync(EditMovieModel editMovieModel);

		Task DeleteMovieAsync(int id);
	}
}
