using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookish.Web3.Startup))]
namespace Bookish.Web3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
