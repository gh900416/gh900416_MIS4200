using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gh900416_MIS4200.Startup))]
namespace gh900416_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
