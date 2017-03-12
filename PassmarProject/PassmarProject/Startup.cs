using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassmarProject.Startup))]
namespace PassmarProject
{
    public partial class Startup
    {

           public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
