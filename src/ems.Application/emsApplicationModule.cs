using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ems.Authorization;

namespace ems
{
    [DependsOn(
        typeof(emsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class emsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<emsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(emsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
