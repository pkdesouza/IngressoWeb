using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.DTO
{
	public abstract class SessionBaseModel
	{
		public int Id { get; set; }
		public int Movie { get; set; }
		public int Room { get; set; }
		public DateTime StartDate { get ; set; }
		public DateTime EndDate { get; set; }

		protected void ValidateRoomModel(out string message)
		{
			if (Movie < 1)
				message = "Selecione um filme";
			else if (Room < 1)
				message = "Selecione uma sala";
			else
				message = String.Empty;
		}
	}
	public class ListSessionMovieTheaterModel : SessionBaseModel
	{
		public string NameMovieTheater { get; set; }
		public string CityNameMovieTheater { get; set; }
		public string StateMovieTheater { get; set; }
		public int QuantitySessions { get; set; }
	}

	public class ListSessionModel : SessionBaseModel
	{
		public string NameMovieTheater { get; set; }
		public string NameMovie { get; set; }
		public int RoomNumber { get; set; }
	}
	public class CreateSessionModel : SessionBaseModel
	{
		public int MovieTheater { get; set; }
		public bool ValidateCreateModel(out string message)
		{
			message = String.Empty;
			base.ValidateRoomModel(out message);
			if (StartDate < DateTime.Now)
				message = "Inicio da sessão não pode ser antecessor a momento atual";
			else if (EndDate < DateTime.Now)
				message = "O fim da sessão não pode ser antecessor a momento atual";
			else if (StartDate > EndDate)
				message = "O inicio da sessão não pode ser posterior a final da sessão";
			else if (StartDate.AddHours(6) < EndDate)
				message = "Sessão não pode ter duração superior a 6 horas de duração";
			else if (StartDate.AddHours(1) > EndDate)
				message = "Sessão não pode ter duração inferior a 1 hora de duração";
			else if (Id < 1)
				message = "Dados inválidos, favor recarregue a página e tente novamente";
			return message == String.Empty;
		}
	}

	public class DetailsSessionModel : SessionBaseModel
	{
		public List<DetailsRoomModel> ListRooms { get; set; }
		public List<ListMovieModel> ListMovies { get; set; }
	}

	public class GetCreateSessionModel : SessionBaseModel
	{
		public List<DetailsRoomModel> ListRooms { get; set; }
		public List<ListMovieModel> ListMovies { get; set; }
		public int MovieTheater { get; set; }
	}

	public class EditSessionModel : SessionBaseModel
	{
		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			base.ValidateRoomModel(out message);
			if (StartDate < DateTime.Now)
				message = "Inicio da sessão não pode ser antecessor a momento atual";
			else if (EndDate < DateTime.Now)
				message = "O fim da sessão não pode ser antecessor a momento atual";
			else if (StartDate > EndDate)
				message = "O inicio da sessão não pode ser posterior a final da sessão";
			else if (StartDate.AddHours(6) < EndDate)
				message = "Sessão não pode ter duração superior a 6 horas de duração";
			else if (StartDate.AddHours(1) > EndDate)
				message = "Sessão não pode ter duração inferior a 1 hora de duração";
			else if (Id < 1)
				message = "Dados inválidos, favor recarregue a página e tente novamente";
			return message == String.Empty;
		}
	}

	public class DeleteSessionModel : SessionBaseModel
	{
		public bool ValidateDeleteModel(out string message)
		{
			message = String.Empty;
			if (Id < 1)
				message = "Dados inválidos, favor recarregue a página e tente novamente";
			return message == String.Empty;
		}
	}
}
