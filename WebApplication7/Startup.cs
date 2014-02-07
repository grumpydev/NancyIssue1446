using Owin;

namespace WebApplication7
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseNancy();
        }
    }
}