using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PysselPost.Startup))]
namespace PysselPost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
