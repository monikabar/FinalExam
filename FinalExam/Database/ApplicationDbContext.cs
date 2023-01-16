using FinalExam.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserLogin> UsersLogins { get; set; }
        public DbSet<UserAccount> UsersAccounts { get; set; }
        public DbSet<UserAddress> UsersAddresses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
