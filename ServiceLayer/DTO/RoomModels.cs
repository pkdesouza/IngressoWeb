using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ServiceLayer.DTO
{
	public abstract class RoomBaseModel
	{
		public int Id { get; set; }
		public int RoomNumber { get; set; }
		public int Capacity { get; set; }
		public int MovieTheater { get; set; }

		protected void ValidateRoomModel(out string message)
		{
			if (Capacity < 1 || !Regex.IsMatch(Capacity.ToString(), @"^\d{0,4}$"))
				message = "Capacidade inválida";
			else if (RoomNumber < 1 || !Regex.IsMatch(RoomNumber.ToString(), @"^\d{0,4}$"))
				message = "Número da sala inválido";
			else
				message = String.Empty;
		}
	}
	public class ListMovieTheaterRoomModel : RoomBaseModel
	{
		public int IdMovieTheater { get; set; }
		public string NameMovieTheater { get; set; }
		public string CityNameMovieTheater { get; set; }
		public string StateMovieTheater { get; set; }
		public int QuantityRooms { get; set; }
	}

	public class ListRoomModel : RoomBaseModel
	{
		public int IdMovieTheater { get; set; }
		public string NameMovieTheater { get; set; }
	}
	public class CreateRoomModel : RoomBaseModel
	{
		public int IdMovieTheater { get; set; }
		public string NameMovieTheater { get; set; }


		public bool ValidateCreateModel(out string message)
		{
			message = String.Empty;
			base.ValidateRoomModel(out message);
			return message == String.Empty;
		}
	}

	public class DetailsRoomModel : RoomBaseModel
	{
		public int QuantitySessions { get; set; }
	}

	public class GetCreateRoomModel : RoomBaseModel
	{

	}

	public class EditRoomModel : RoomBaseModel
	{
		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			base.ValidateRoomModel(out message);
			if (!(Id > 0))
				message = "Dados inválidos";
			return message == String.Empty;
		}
	}

	public class DeleteRoomModel : RoomBaseModel
	{

		public bool ValidateDeleteModel(out string message)
		{
			message = String.Empty;
			if (!(Id > 0))
				message = "Dados inválidos";
			return message == String.Empty;
		}
	}
}
