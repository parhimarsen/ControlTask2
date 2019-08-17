using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlTask2.Startup))]
namespace ControlTask2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
