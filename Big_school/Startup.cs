using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Big_school.Startup))]
namespace Big_school
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
