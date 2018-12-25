using DataAccessLayer.Entities;
using ServiceLayer.DTO;
using ServiceLayer.ServicesAbstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
	public class MovieTheaterService : IMovieTheaterService
	{
		private readonly IngressoWebContext Context;

		public MovieTheaterService(IngressoWebContext context)
		{
			Context = context;
		}

		public async Task AddMovieTheaterAsync(CreateMovieTheaterModel createMovieTheaterModel)
		{
			await Context.MovieTheater.AddAsync(new MovieTheater
			{
				Name = createMovieTheaterModel.Name,
				NumberAddress = createMovieTheaterModel.NumberAddress,
				StreetName = createMovieTheaterModel.StreetName,
				ZipCode = createMovieTheaterModel.ZipCode,
				CityNavigation = new City
				{
					Name = createMovieTheaterModel.CityName,
					State = createMovieTheaterModel.State
				}
			});
			await Context.SaveChangesAsync();
		}

		public async Task DeleteMovieTheaterAsync(int id)
		{
			var movieTheater = await Context.MovieTheater.FindAsync(id);
			movieTheater.Active = false;
			await Context.SaveChangesAsync();
		}

		public async Task<DetailsMovieTheaterModel> DetailsMovieTheaterAsync(int Id)
		{
			return await Context.MovieTheater.Where(x => x.Id == Id && x.Active)
			.Select(x => new DetailsMovieTheaterModel
			{
				Id = x.Id,
				Name = x.Name,
				ZipCode = x.ZipCode,
				NumberAddress = x.NumberAddress,
				StreetName = x.StreetName,
				State = x.CityNavigation.State,
				CityName = x.CityNavigation.Name
			}).FirstOrDefaultAsync();
		}

		public async Task EditMovieTheaterAsync(EditMovieTheaterModel editMovieTheaterModel)
		{
			var city = await Context.City.Where(a => a.Name == editMovieTheaterModel.CityName && a.State == editMovieTheaterModel.State).FirstOrDefaultAsync();
			if(city == null)
			{
				city = new City
				{
					Name = editMovieTheaterModel.CityName,
					State = editMovieTheaterModel.State
				};
				await Context.City.AddAsync(city);
				await Context.SaveChangesAsync();
			}

			var movieTheater = await Context.MovieTheater.FindAsync(editMovieTheaterModel.Id);
			movieTheater.Name = editMovieTheaterModel.Name;
			movieTheater.NumberAddress = editMovieTheaterModel.NumberAddress;
			movieTheater.StreetName = editMovieTheaterModel.StreetName;
			movieTheater.ZipCode = editMovieTheaterModel.ZipCode;
			movieTheater.City = city.Id;
			await Context.SaveChangesAsync();
		}

		public async Task<IEnumerable<ListMovieTheaterModel>> GetMovieTheatersAsync()
		{
			return await Context.MovieTheater.Where(a => a.Active).Select(x => new ListMovieTheaterModel
			{
				Id = x.Id,
				Name = x.Name,
				ZipCode = x.ZipCode,
				StreetName = x.StreetName,
				NumberAddress = x.NumberAddress,
				State = x.CityNavigation.State,
				CityName = x.CityNavigation.Name
			}).ToListAsync();
		}
	}

}
