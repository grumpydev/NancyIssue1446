using Nancy;

namespace WebApplication7
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    using Nancy.Owin;

    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/{name?}"] = _ =>
                {
                    var sb = new StringBuilder();

                    sb.AppendFormat("Request Url: {0}\n", Request.Url.ToString());
                    sb.AppendFormat("Paraneter: {0}\n", _.name);

                    var environment = Context.GetOwinEnvironment();

                    foreach (var envKey in environment.Keys)
                    {
                        sb.AppendFormat("{0} : {1}\n", envKey, environment[envKey]);
                    }

                    return sb.ToString().Replace("\n", "<br/>");
                };
        }
    }
}