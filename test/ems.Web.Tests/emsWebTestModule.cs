using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ems.EntityFrameworkCore;
using ems.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ems.Web.Tests
{
    [DependsOn(
        typeof(emsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class emsWebTestModule : AbpModule
    {
        public emsWebTestModule(emsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(emsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(emsWebMvcModule).Assembly);
        }
    }
}