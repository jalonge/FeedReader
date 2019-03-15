using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedsReader.UI.Startup))]
namespace FeedsReader.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
