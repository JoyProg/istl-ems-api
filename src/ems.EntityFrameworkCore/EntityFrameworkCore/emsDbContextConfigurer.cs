using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ems.EntityFrameworkCore
{
    public static class emsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<emsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<emsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
