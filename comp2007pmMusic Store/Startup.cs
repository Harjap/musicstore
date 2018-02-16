using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp2007pmMusic_Store.Startup))]
namespace comp2007pmMusic_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
