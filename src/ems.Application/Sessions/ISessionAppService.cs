using System.Threading.Tasks;
using Abp.Application.Services;
using ems.Sessions.Dto;

namespace ems.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
