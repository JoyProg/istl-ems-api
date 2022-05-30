using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ems.Authorization.Roles;
using ems.Authorization.Users;
using ems.MultiTenancy;

namespace ems.EntityFrameworkCore
{
    public class emsDbContext : AbpZeroDbContext<Tenant, Role, User, emsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public emsDbContext(DbContextOptions<emsDbContext> options)
            : base(options)
        {
        }
    }
}
