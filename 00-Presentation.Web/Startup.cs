﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_00_Presentation.Web.Startup))]
namespace _00_Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
