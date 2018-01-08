using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QMSweb.Startup))]
namespace QMSweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
