using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DevRel.Authorization.Roles;
using DevRel.Authorization.Users;
using DevRel.MultiTenancy;

namespace DevRel.EntityFrameworkCore
{
    public class DevRelDbContext : AbpZeroDbContext<Tenant, Role, User, DevRelDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DevRelDbContext(DbContextOptions<DevRelDbContext> options)
            : base(options)
        {
        }
    }
}
