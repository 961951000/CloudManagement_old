using System.Data.Entity;
using UserManagement.Data.Models;

namespace UserManagement.WebApi.DatabaseContext
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() : base("name=SqlServerConnection") { }

        public DbSet<User> User { get; set; }

        public DbSet<Enterprise> Enterprise { get; set; }

    }
}
