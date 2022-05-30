using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ems.Configuration.Dto;

namespace ems.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : emsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
