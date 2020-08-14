using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresBakeryTreatFlavor.Models
{
  public class PierresBakeryTreatFlavorContextFactory : IDesignTimeDbContextFactory<PierresBakeryTreatFlavorContext>
  {

    PierresBakeryTreatFlavorContext IDesignTimeDbContextFactory<PierresBakeryTreatFlavorContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierresBakeryTreatFlavorContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PierresBakeryTreatFlavorContext(builder.Options);
    }
  }
}