using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AudMVCBaza.Startup))]
namespace AudMVCBaza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
