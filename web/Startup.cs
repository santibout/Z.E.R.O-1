using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Z.E.R.O_1.web.Startup))]
namespace Z.E.R.O_1.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
