using Nancy;

namespace WebApplication7
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/{name?}"] = _ => _.name;
        }
    }
}