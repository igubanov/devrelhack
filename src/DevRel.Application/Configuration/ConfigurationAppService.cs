using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DevRel.Configuration.Dto;

namespace DevRel.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DevRelAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
