using System;
using Configuration.Options;

namespace DrivingWeb.Intialization.Extensions
{
	public static class OptionExtension
	{
		public static IServiceCollection RegisterOptions(this IServiceCollection services, IConfiguration config)
		{
			return services
				.AddOptions()
				.Configure<ProxyOptions>(config)
				.Configure<ConnectionStringOptions>(config)
				.Configure<RedisOptions>(config);
		}
        public static IServiceCollection ConfigureOptions(this IServiceCollection services, IConfiguration config)
        {
			return services
				.Configure<ProxyOptions>(config)
				.Configure<RoleOptions>(o =>
				{
					o.Admin = new List<string>(config["Roles:Admins"].Split(','));
                    o.TechnicalSupport = new List<string>(config["Roles:TechnicalSupports"].Split(','));
                    o.StandardUsers = new List<string>(config["Roles:StandardUsers"].Split(','));
                    o.Viewers = new List<string>(config["Roles:Viewers"].Split(','));
                })
				.Configure<ConnectionStringOptions>(o =>
				{
					o.Database = config["ConnectionStrings:Database"];
				})
				.Configure<RedisOptions>(o => config.GetSection("Redis").Bind(o));
        }
    }
}

