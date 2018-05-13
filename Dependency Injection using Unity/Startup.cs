using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dependency_Injection_using_Unity.Startup))]
namespace Dependency_Injection_using_Unity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
