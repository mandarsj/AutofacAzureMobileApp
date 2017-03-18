using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Config;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AutofacAzureMobileApp.App_Start
{
    public static class MobileAppConfig
    {
        public static void Configure(IAppBuilder app, HttpConfiguration config)
        {
            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();


        }
    }
}