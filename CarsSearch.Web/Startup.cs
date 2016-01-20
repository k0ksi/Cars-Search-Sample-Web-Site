using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsSearch.Web.Startup))]
namespace CarsSearch.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
