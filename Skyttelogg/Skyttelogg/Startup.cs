using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skyttelogg.Startup))]
namespace Skyttelogg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
