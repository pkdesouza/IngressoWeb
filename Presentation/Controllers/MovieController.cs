using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.DTO;
using ServiceLayer.ServicesAbstractions;

namespace IngressoWeb.Controllers
{
	public class MovieController : Controller
	{
		private readonly IMovieService MovieService;

		public MovieController(IMovieService movieService)
		{
			MovieService = movieService;
		}

		[HttpGet]
		public async Task<IActionResult> Index() => View(await MovieService.GetMoviesAsync());

		[HttpGet]
		public async Task<IActionResult> Details(int id) => View(await MovieService.DetailMovieAsync(id));

		[HttpGet]
		public IActionResult Create() => View();

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateMovieModel movieModel)
		{
			var errorMessage = String.Empty;
			if (!movieModel.ValidateCreateModel(out errorMessage)) {
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieService.AddMovieAsync(movieModel);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) => View(await MovieService.DetailMovieAsync(id));

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(EditMovieModel editMovieModel)
		{
			var errorMessage = String.Empty;
			if (!editMovieModel.ValidateEditModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieService.EditMovieAsync(editMovieModel);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id) => View(await MovieService.DetailMovieAsync(id));

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(DeleteMovieModel deleteMovieModel)
		{
			var errorMessage = String.Empty;
			if (!deleteMovieModel.ValidateDeleteModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieService.DeleteMovieAsync(deleteMovieModel.Id);
			return RedirectToAction(nameof(Index));
		}
	}
}