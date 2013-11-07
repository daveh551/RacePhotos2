using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RacePhotos2.Startup))]
namespace RacePhotos2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
