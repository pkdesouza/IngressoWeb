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
    public class SessionController : Controller
    {
		private readonly ISessionService SessionService;

		public SessionController(ISessionService sessionService)
		{
			SessionService = sessionService;
		}

		[HttpGet]
		public async Task<IActionResult> Index() => View(await SessionService.GetMovieTheatersAsync());

		[HttpGet]
		public async Task<IActionResult> Sessions(int id) => View(await SessionService.GetSessionsAsync(id));

		[HttpGet]
		public async Task<IActionResult> Details(int id) => View(await SessionService.DetailsSessionAsync(id));

		[HttpGet]
		public async Task<IActionResult> Create(int id) => View(await SessionService.GetCreateSessionAsync(id));

		[HttpGet]
		public async Task<IActionResult> Edit(int id) => View(await SessionService.DetailsSessionAsync(id));

		[HttpGet]
		public async Task<IActionResult> Delete(int id) => View(await SessionService.DetailsSessionAsync(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateSessionModel createSession)
        {
			var errorMessage = String.Empty;
			if (!createSession.ValidateCreateModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View(await SessionService.GetCreateSessionAsync(createSession.Id));
			}
			await SessionService.AddSessionAsync(createSession);
			return RedirectToAction(nameof(Index));
		}
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditSessionModel editSession)
        {
			var errorMessage = String.Empty;
			if (!editSession.ValidateEditModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View(await SessionService.DetailsSessionAsync(editSession.Id));
			}
			await SessionService.EditSessionAsync(editSession);
			return RedirectToAction(nameof(Index));
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteSessionModel deleteSession)
        {
			var errorMessage = String.Empty;
			if (!deleteSession.ValidateDeleteModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View(await SessionService.DetailsSessionAsync(deleteSession.Id));
			}
			await SessionService.DeleteSessionAsync(deleteSession);
			return RedirectToAction(nameof(Index));
		}
    }
}