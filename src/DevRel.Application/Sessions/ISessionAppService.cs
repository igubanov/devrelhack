using System.Threading.Tasks;
using Abp.Application.Services;
using DevRel.Sessions.Dto;

namespace DevRel.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
