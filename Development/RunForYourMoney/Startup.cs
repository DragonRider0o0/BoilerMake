using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunForYourMoney.Startup))]
namespace RunForYourMoney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
