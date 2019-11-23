using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exam_Aviran_Ben_David.Startup))]
namespace Exam_Aviran_Ben_David
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
