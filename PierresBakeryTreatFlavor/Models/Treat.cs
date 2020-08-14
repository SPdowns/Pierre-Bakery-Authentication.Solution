using System.Collections.Generic;

namespace PierresBakeryTreatFlavor.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavor = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Flavor { get; }
  }
}