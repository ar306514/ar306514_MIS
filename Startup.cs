using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(risner_MIS4200.Startup))]
namespace risner_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
