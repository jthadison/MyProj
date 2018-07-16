﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProj.Configuration;

namespace MyProj.Web.Host.Startup
{
    [DependsOn(
       typeof(MyProjWebCoreModule))]
    public class MyProjWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjWebHostModule).GetAssembly());
        }
    }
}
