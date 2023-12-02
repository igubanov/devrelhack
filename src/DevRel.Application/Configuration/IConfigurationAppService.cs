using System.Threading.Tasks;
using DevRel.Configuration.Dto;

namespace DevRel.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
