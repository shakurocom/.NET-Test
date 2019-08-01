using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TG.Exam.WebMVC.Startup))]
namespace TG.Exam.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
