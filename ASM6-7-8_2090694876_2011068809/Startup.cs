using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASM6_7_8_2090694876_2011068809.Startup))]
namespace ASM6_7_8_2090694876_2011068809
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
