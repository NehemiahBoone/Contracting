using System.ComponentModel.DataAnnotations;

namespace Contracting.Models
{
  public class Job
  {
    [Required]
    public string Location { get; set; }
    public string Description { get; set; }

    [Required]
    public string Contact { get; set; }
    public decimal HourlyPay { get; set; }
    public int Id { get; set; }
  }
}