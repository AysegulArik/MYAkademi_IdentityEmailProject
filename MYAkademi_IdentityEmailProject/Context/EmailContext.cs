using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYAkademi_IdentityEmailProject.Entities;

namespace MYAkademi_IdentityEmailProject.Context
{
    public class EmailContext:IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N0BN8PV\\SQLEXPRESS; Database=IdentityEmailDb; integrated security=True; Trust Server Certificate=True;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
