using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ServiceLayer.DTO
{
	public abstract class MovieTheaterBaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string StreetName { get; set; }
		public int ZipCode { get; set; }
		public int NumberAddress { get; set; }
		public string CityName { get; set; }
		public string State { get; set; }

		protected void ValidateMovieModel(out string message) {

		    if (String.IsNullOrWhiteSpace(Name) || !(Name.Length > 3))
				message = "O nome do cinema deve conter no mínimo 4 caracteres";
			else if (String.IsNullOrWhiteSpace(StreetName) || !(StreetName.Length > 3))
				message = "A rua deve conter no mínimo 4 caracteres";
			else if (!Regex.IsMatch(ZipCode.ToString(), @"^\d{8}$"))
				message = "Cep com formato inválido";
			else if (!Regex.IsMatch(NumberAddress.ToString(), @"^\d{0,6}$"))
				message = "Quantidade de digitos inválida";
			else if (String.IsNullOrWhiteSpace(CityName) || !(CityName.Length > 2))
				message = "Informe uma cidade válida";
			else if (String.IsNullOrWhiteSpace(State) || !Regex.IsMatch(State, @"^[A-Z]{2}$"))
				message = "Informe um Estado válido Ex: RJ";
			else
				message = "";
		}
	}

	public class ListMovieTheaterModel : MovieTheaterBaseModel
	{

	}

	public class CreateMovieTheaterModel : MovieTheaterBaseModel
	{
		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			base.ValidateMovieModel(out message);
			return message == String.Empty;
		}
	}

	public class DetailsMovieTheaterModel : MovieTheaterBaseModel
	{
	}

	public class EditMovieTheaterModel : MovieTheaterBaseModel
	{
		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			base.ValidateMovieModel(out message);
			if (!(Id > 0))
				message = "Dados inválidos";
			return message == String.Empty;
		}
	}

	public class DeleteMovieTheaterModel : MovieTheaterBaseModel
	{

		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			if (!(Id > 0))
				message = "Dados inválidos";
			return message == String.Empty;
		}
	}
}