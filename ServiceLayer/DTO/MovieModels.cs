using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DataAccessLayer.Enum;
using ServiceLayer.Utilities;
namespace ServiceLayer.DTO
{
	public abstract class MovieBaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Synopsis { get; set; }
		public string Image { get; set; }
		public string Trailer { get; set; }

		public void ValidateMovieModel(out string message) {
			message = String.Empty;
			if (String.IsNullOrWhiteSpace(Name))
				message = "Preencha o nome do filme";
			else if (!(Name.Length > 2))
				message = "O nome do filme deve conter no mimino 3 letras";
			else if (String.IsNullOrWhiteSpace(Synopsis))
				message = "Preencha a sinopse do filme";
			else if(!(Synopsis.Length >= 30))
				message = "A sinopse deve conter no mimino 30 letras";
		}
	}

	public class ListMovieModel : MovieBaseModel
	{
		public int AgeRating { get; set; }
		public decimal Price { get; set; }
		public int ReleaseYear { get; set; }
	}

	public class DetailsMovieModel : MovieBaseModel
	{
		public int AgeRating { get; set; }
		public decimal Price { get; set; }
		public int ReleaseYear { get; set; }
		public DateTime? RegistrationDate { get; set; }
		public DateTime? LastModificationDate { get; set; }
		public bool Active { get; set; }
	}

	public class CreateMovieModel : MovieBaseModel
	{
		public int AgeRating { get; set; }
		public string Price { get; set; }
		public int ReleaseYear { get; set; }

		public bool ValidateCreateModel(out string message) {
			var ageRating = (EnumAgeRating) AgeRating;
			decimal priceOut;
			message = String.Empty;
			base.ValidateMovieModel(out message);
			if (!ageRating.GetAllAgeRatings().Contains((int)ageRating))
				message = "Classificação indicativa inválida";
			else if (ReleaseYear > DateTime.Now.AddYears(2).Year || ReleaseYear < 1900)
				message = "Ano de Lancemento inválido";
			else if (String.IsNullOrEmpty(Price) || !Decimal.TryParse(Price, out priceOut))
				message = "Preço informado inválido";
			else
				Price = priceOut.ToString("0.##");
			return message == String.Empty;
		}
	}

	public class EditMovieModel : MovieBaseModel
	{
		public int AgeRating { get; set; }
		public string Price { get; set; }
		public int ReleaseYear { get; set; }

		public bool ValidateEditModel(out string message)
		{
			message = String.Empty;
			base.ValidateMovieModel(out message);
			var ageRating = (EnumAgeRating)AgeRating;
			if (!ageRating.GetAllAgeRatings().Contains((int)ageRating))
				message = "Classificação indicativa inválida";
			else if (ReleaseYear > DateTime.Now.AddYears(2).Year || ReleaseYear < 1900)
				message = "Ano de Lancemento inválido";
			else if (!(Id > 0))
				message = "Dados incorretos";
			return message == String.Empty;
		}
	}

	public class DeleteMovieModel : MovieBaseModel
	{
		public bool ValidateDeleteModel(out string message)
		{
			message = String.Empty;
			if (!(Id > 0))
				message = "Dados incorretos";
			return message == String.Empty;
		}
	}
}
