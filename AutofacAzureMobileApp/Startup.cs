using Autofac;
using Autofac.Integration.WebApi;
using AutofacAzureMobileApp.App_Start;
using Microsoft.Owin;
using Newtonsoft.Json;
using Owin;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(AutofacAzureMobileApp.Startup))]

namespace AutofacAzureMobileApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            CreateContainer(config);

            MobileAppConfig.Configure(app, config);  
            app.UseWebApi(config);
        }

        private void CreateContainer(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //register module
            builder.Register(p => new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects });

            //you can use builder.registermodule or also builder.registertype based on your structure and requirements.

            var container = builder.Build();

           config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            
            
        }
    }
}