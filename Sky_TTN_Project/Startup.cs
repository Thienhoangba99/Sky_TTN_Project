using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sky_TTN_Project.Startup))]
namespace Sky_TTN_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
