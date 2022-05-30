using Abp.Authorization;
using ems.Authorization.Roles;
using ems.Authorization.Users;

namespace ems.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
