using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.ServicesAbstractions;

namespace WebLayer.Controllers
{
    public class MovieTheaterController : Controller
    {
		private readonly IMovieTheaterService MovieTheaterService;

		public MovieTheaterController(IMovieTheaterService movieTheaterService)
		{
			MovieTheaterService = movieTheaterService;
		}

		[HttpGet]
		public async Task<IActionResult> Index() => View(await MovieTheaterService.GetMovieTheatersAsync());

		[HttpGet]
		public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMovieTheaterModel createMovieTheater)
        {
			var errorMessage = String.Empty;
			if (!createMovieTheater.ValidateEditModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieTheaterService.AddMovieTheaterAsync(createMovieTheater);
			return RedirectToAction(nameof(Index));
		}

        public async Task<IActionResult> Edit(int id) => View(await MovieTheaterService.DetailsMovieTheaterAsync(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditMovieTheaterModel editMovieTheater)
        {
			var errorMessage = String.Empty;
			if (!editMovieTheater.ValidateEditModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieTheaterService.EditMovieTheaterAsync(editMovieTheater);
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Delete(int id) => View(await MovieTheaterService.DetailsMovieTheaterAsync(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteMovieTheaterModel deleteMovieTheater)
        {
			var errorMessage = String.Empty;
			if (!deleteMovieTheater.ValidateEditModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await MovieTheaterService.DeleteMovieTheaterAsync(deleteMovieTheater.Id);
			return RedirectToAction(nameof(Index));
        }
    }
}