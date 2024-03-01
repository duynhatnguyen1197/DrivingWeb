using System;
using Configuration.Options;

namespace Configuration
{
	public interface IAppConfiguration
	{
		ProxyOptions ProxyOptions { get; }
		RedisOptions RedisOptions { get; }
		ConnectionStringOptions ConnectionStringOptions { get; }
	}
}

