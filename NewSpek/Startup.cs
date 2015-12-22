using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewSpek.Startup))]
namespace NewSpek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
