using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nop.Plugin.Widget.Slider.Startup))]
namespace Nop.Plugin.Widget.Slider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
