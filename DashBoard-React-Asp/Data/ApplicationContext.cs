using Microsoft.EntityFrameworkCore;
using DashBoard_React_Asp.Data.Models;

namespace DashBoard_React_Asp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Board> Board { get; set; }
        public DbSet<Thread> Thread { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}