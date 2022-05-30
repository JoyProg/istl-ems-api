using System.Threading.Tasks;
using ems.Configuration.Dto;

namespace ems.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
