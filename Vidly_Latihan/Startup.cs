using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_Latihan.Startup))]
namespace Vidly_Latihan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
