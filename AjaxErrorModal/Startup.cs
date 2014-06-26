using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxErrorModal.Startup))]
namespace AjaxErrorModal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
