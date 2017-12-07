using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EducationWebsite.Startup))]
namespace EducationWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
