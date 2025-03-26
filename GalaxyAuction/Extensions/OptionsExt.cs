using GalaxyAuction_Core.Common;

namespace GalaxyAuction.Extensions
{
	public static class OptionsExt
	{
		public static IServiceCollection AddInFrastructureLayer(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<StripeSettings>(options => configuration.GetSection("StripeSettings").Bind(options));
			return services;
		}
	}
}