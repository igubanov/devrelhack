using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DevRel.Controllers
{
    public abstract class DevRelControllerBase: AbpController
    {
        protected DevRelControllerBase()
        {
            LocalizationSourceName = DevRelConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
