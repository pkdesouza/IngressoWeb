using DataAccessLayer.Enum;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServiceLayer.Utilities
{
	public static class EnumExtensions
	{
		public static int[] GetAllAgeRatings(this EnumAgeRating enumAge)
		{
			return new int[] {
				(int)EnumAgeRating.Livre,
				(int)EnumAgeRating.Dez,
				(int)EnumAgeRating.Doze,
				(int)EnumAgeRating.Quartoze,
				(int)EnumAgeRating.Desseis,
				(int)EnumAgeRating.Dezoito,
			};
		}
	}
}
