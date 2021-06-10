using Boilerplate.Core.Models;
using Boilerplate.Infra.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Infra.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FornecedorMapConfig>();
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //base.OnModelCreating(builder);
        }
    } 
}
