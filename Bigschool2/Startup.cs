using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschool2.Startup))]
namespace Bigschool2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
