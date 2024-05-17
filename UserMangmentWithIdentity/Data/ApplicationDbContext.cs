using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserMangmentWithIdentity.Models;

namespace UserMangmentWithIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("Users","Secuirty") ;
            builder.Entity<IdentityRole>().ToTable("Roles", "Secuirty");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Secuirty");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Secuirty");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Secuirty");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Secuirty");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Secuirty");


        }


    }
}
