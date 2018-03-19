using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FingerArt.Startup))]
namespace FingerArt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
