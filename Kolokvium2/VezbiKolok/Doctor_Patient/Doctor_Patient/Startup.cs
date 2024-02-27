using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doctor_Patient.Startup))]
namespace Doctor_Patient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
