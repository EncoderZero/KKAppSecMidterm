using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Midterm.Startup))]
namespace Midterm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
