using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BioFortStat.Startup))]
namespace BioFortStat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
