using System.Threading.Tasks;
using Abp.Application.Services;
using ems.Authorization.Accounts.Dto;

namespace ems.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
