using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotel_OpticalSource.Startup))]
namespace Hotel_OpticalSource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
