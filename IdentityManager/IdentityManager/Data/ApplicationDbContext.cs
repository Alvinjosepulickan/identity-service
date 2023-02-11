using IdentityManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
