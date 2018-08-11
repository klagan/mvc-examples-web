using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentication.Example.Startup))]
namespace Authentication.Example
{
    //This project works on the basis that the Identity.Example was ruin to create the users/roles etc
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
