using System;
using Microsoft.Extensions.DependencyInjection;
namespace DrivingWeb
{
	public  class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration)
		{
			Configuration = (IConfigurationRoot)configuration;
			ThreadPool.SetMinThreads(100, 1);
		}

		public void ConfigureService(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Duy API", Version = "1.0" });
			});
			services.AddControllers()
				.AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase);
			services.AddApiVersioning();
		}
	}
}

