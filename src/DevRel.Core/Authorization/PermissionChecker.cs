using Abp.Authorization;
using DevRel.Authorization.Roles;
using DevRel.Authorization.Users;

namespace DevRel.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
