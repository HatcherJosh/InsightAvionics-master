using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsightAvionics.Startup))]
namespace InsightAvionics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
