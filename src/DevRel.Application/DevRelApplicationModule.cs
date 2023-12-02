using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevRel.Authorization;

namespace DevRel
{
    [DependsOn(
        typeof(DevRelCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DevRelApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DevRelAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DevRelApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
