using System;
namespace Configuration.Options
{
	public class RoleOptions
	{
		public List<string> Viewers { get;set }
		public List<string> StandardUsers { get; set; }
		public List<string> TechnicalSupport { get; set; }
		public List<string> Admin { get; set; }
	}
}

