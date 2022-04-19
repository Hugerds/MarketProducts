using MercadoProdutos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MercadoProdutos
{
    public class MercadoProdutosContext : IdentityDbContext <User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Market> Market { get; set; }
        public DbSet<ProductMarket> ProductMarket { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<ProductMedia> ProductMedia { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Address> Address { get; set; }
        public MercadoProdutosContext(DbContextOptions<MercadoProdutosContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(x => new {x.UserId, x.RoleId});
                userRole.HasOne(x => x.Role)
                .WithMany(r=> r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

                userRole.HasOne(x => x.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            });
        }
    }
}
