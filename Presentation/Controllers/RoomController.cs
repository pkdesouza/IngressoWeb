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
    public class RoomController : Controller
    {
		private readonly IRoomService RoomService;

		public RoomController(IRoomService movieService)
		{
			RoomService = movieService;
		}

		[HttpGet]
		public async Task<IActionResult> Index() => View(await RoomService.GetMovieTheatersAsync());

		[HttpGet]
		public async Task<IActionResult> Rooms(int id) => View(await RoomService.GetRoomsAsync(id));

		[HttpGet]
		public async Task<IActionResult> Details(int id) => View(await RoomService.DetailsRoomAsync(id));

		[HttpGet]
		public async Task<IActionResult> Create(int id) => View(await RoomService.GetCreateRoomAsync(id));

		[HttpGet]
		public async Task<IActionResult> Edit(int id) => View(await RoomService.DetailsRoomAsync(id));

		[HttpGet]
		public async Task<IActionResult> Delete(int id) => View(await RoomService.DetailsRoomAsync(id));

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateRoomModel createRoom)
		{
			var errorMessage = String.Empty;
			if (!createRoom.ValidateCreateModel(out errorMessage))
				ModelState.AddModelError(string.Empty, errorMessage);
			else if (!RoomService.ValidateRoom(createRoom.Id, createRoom.RoomNumber, out errorMessage))
				ModelState.AddModelError(string.Empty, errorMessage);
			else
			{
				await RoomService.AddRoomAsync(createRoom);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditRoomModel editRoom)
        {
			var errorMessage = String.Empty;
			if (!editRoom.ValidateEditModel(out errorMessage))
				ModelState.AddModelError(string.Empty, errorMessage);
			else if (!RoomService.ValidateRoom(editRoom.MovieTheater, editRoom.RoomNumber, out errorMessage))
				ModelState.AddModelError(string.Empty, errorMessage);
			else
			{
				await RoomService.EditRoomAsync(editRoom);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteRoomModel deleteRoom)
        {
			var errorMessage = String.Empty;
			if (!deleteRoom.ValidateDeleteModel(out errorMessage))
			{
				ModelState.AddModelError(string.Empty, errorMessage);
				return View();
			}
			await RoomService.DeleteRoomAsync(deleteRoom);
			return RedirectToAction(nameof(Index));
		}
    }
}