using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities;
using AspNetCore.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.Extensions
{
	public static class ServiceExtension{
		public static void ConfigureCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader());
			});
		}
		public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config["mysqlconnection:connectionString"];
			services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString));
		}
		public static void ConfigureRepositoryWrapper(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
		}


	}
}
