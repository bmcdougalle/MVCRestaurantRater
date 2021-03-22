using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRestaurantRater.Startup))]
namespace MVCRestaurantRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
