using DataAccessLayer.Entities;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer;
using ServiceLayer.Services;
using ServiceLayer.ServicesAbstractions;

namespace WebLayer.Utilities
{
	public static class DependencyInjectionService
	{
		public static IServiceCollection RegisterDependencyServices(
			this IServiceCollection services)
		{
			services.AddTransient<IMovieService, MovieService>();
			services.AddTransient<IMovieTheaterService, MovieTheaterService>();
			services.AddTransient<IRoomService, RoomService>();
			services.AddTransient<ISessionService, SessionService>();
			services.AddTransient<IngressoWebContext, IngressoWebContext>();

			return services;
		}
	}
}
