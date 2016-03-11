using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstTDDTest.Startup))]
namespace FirstTDDTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
