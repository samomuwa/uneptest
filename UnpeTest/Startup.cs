using Microsoft.Owin;
using Owin;
using UnpeTest.Models;
using Microsoft.EntityFrameworkCore;
[assembly: OwinStartupAttribute(typeof(UnpeTest.Startup))]
namespace UnpeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
       
    }
}
