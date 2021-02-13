using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeadsStates.Startup))]
namespace LeadsStates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
