using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresBakeryTreatFlavor.Models
{
  public class PierresBakeryTreatFlavorContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set;}
    public PierresBakeryTreatFlavorContext(DbContextOptions options) : base(options) { }
  }
}