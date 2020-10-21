using System.ComponentModel.DataAnnotations;

namespace Contracting.Models
{
  public class Contractor
  {
    [Required]
    public string Name { get; set; }
    public string Address { get; set; }

    [Required]
    public string Contact { get; set; }
    public string Skills { get; set; }
    public int Id { get; set; }
    public string CreatorId { get; set; }
  }
}