using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RADtestExam.Startup))]
namespace RADtestExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
