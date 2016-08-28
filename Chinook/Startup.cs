using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chinook.Startup))]
namespace Chinook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
