using Microsoft.Owin;
using Owin;
using System.IO;

[assembly: OwinStartupAttribute(typeof(Vidly.Startup))]
namespace Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            FileInfo fi = new FileInfo("AppSettings.template.config");
            if (!File.Exists("AppSettings.config"))
                //File.Move("AppSettings.template.config", "AppSettings.config");
                fi.MoveTo("AppSettings.config");
            ConfigureAuth(app);
        }
    }
}
