using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5HomeWorkW1.Startup))]
namespace MVC5HomeWorkW1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
