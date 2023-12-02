using System.Threading.Tasks;
using Abp.Application.Services;
using DevRel.Authorization.Accounts.Dto;

namespace DevRel.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
