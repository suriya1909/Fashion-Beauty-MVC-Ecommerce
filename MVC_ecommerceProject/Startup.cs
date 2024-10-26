using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ecommerceProject.Startup))]
namespace MVC_ecommerceProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
