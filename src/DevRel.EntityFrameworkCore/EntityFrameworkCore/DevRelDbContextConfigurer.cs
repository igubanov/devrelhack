using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DevRel.EntityFrameworkCore
{
    public static class DevRelDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DevRelDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DevRelDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
