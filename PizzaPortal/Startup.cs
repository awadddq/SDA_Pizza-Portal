using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaPortal.Startup))]
namespace PizzaPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
