using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC_Ventas_Respuestos.Startup))]
namespace EC_Ventas_Respuestos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
