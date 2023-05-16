using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB3_B.Startup))]
namespace LAB3_B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
