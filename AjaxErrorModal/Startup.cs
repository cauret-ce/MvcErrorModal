using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAjaxErrorModal.Startup))]
namespace MvcAjaxErrorModal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
