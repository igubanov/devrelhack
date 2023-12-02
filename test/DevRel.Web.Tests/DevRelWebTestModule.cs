using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevRel.EntityFrameworkCore;
using DevRel.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DevRel.Web.Tests
{
    [DependsOn(
        typeof(DevRelWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DevRelWebTestModule : AbpModule
    {
        public DevRelWebTestModule(DevRelEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DevRelWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DevRelWebMvcModule).Assembly);
        }
    }
}