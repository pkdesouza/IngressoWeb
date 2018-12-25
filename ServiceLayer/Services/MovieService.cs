using ServiceLayer.DTO;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using ServiceLayer.ServicesAbstractions;

namespace ServiceLayer
{
	public class MovieService : IMovieService
	{
		private readonly IngressoWebContext Context;

		public MovieService(IngressoWebContext context)
		{
			Context = context;
		}

		public async Task<IEnumerable<ListMovieModel>> GetMoviesAsync()
		{

			return await Context.Movie.Where(x => x.Active).Select(m => new ListMovieModel
			{
				Id = m.Id,
				Name = m.Name,
				Price = m.Price,
				ReleaseYear = m.ReleaseYear,
				Image = m.Image
			}).ToListAsync();
		}

		public async Task AddMovieAsync(CreateMovieModel createMovieModel)
		{
			await Context.Movie.AddAsync(new Movie()
			{
				Name = createMovieModel.Name,
				Synopsis = createMovieModel.Synopsis,
				AgeRating = createMovieModel.AgeRating,
				Price = Convert.ToDecimal(createMovieModel.Price),
				ReleaseYear = createMovieModel.ReleaseYear,
				Image = createMovieModel.Image,
				Trailer = createMovieModel.Trailer
			});
			await Context.SaveChangesAsync();
		}

		public async Task<DetailsMovieModel> DetailMovieAsync(int Id)
		{
			return await Context.Movie.Where(x => x.Active && x.Id == Id)
			.Select(m => new DetailsMovieModel
			{
				Id = m.Id,
				Name = m.Name,
				Price = m.Price,
				AgeRating = m.AgeRating,
				Synopsis = m.Synopsis,
				ReleaseYear = m.ReleaseYear,
				Active = m.Active,
				LastModificationDate = m.LastModificationDate,
				RegistrationDate = m.RegistrationDate,
				Image = m.Image,
				Trailer= m.Trailer
			}).FirstOrDefaultAsync();
		}

		public async Task EditMovieAsync(EditMovieModel editMovieModel)
		{
			var movie = Context.Movie.Find(editMovieModel.Id);
			movie.Name = editMovieModel.Name;
			movie.AgeRating = editMovieModel.AgeRating;
			movie.ReleaseYear = editMovieModel.ReleaseYear;
			movie.Synopsis = editMovieModel.Synopsis;
			movie.LastModificationDate = DateTime.Now;
			movie.Trailer = editMovieModel.Trailer;
			movie.Image = editMovieModel.Image;
			await Context.SaveChangesAsync();
		}

		public async Task DeleteMovieAsync(int id)
		{
			var movie = await Context.Movie.FindAsync(id);
			if (await Context.Session.Where(x => x.Movie == id).FirstOrDefaultAsync() == null)
				Context.Movie.Remove(movie);
			else
				movie.Active = false;
			await Context.SaveChangesAsync();
		}
	}
}
