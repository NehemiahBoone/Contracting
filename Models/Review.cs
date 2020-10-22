namespace Contracting.Models
{
  public class Review
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Rating { get; set; }
    public int ContractorId { get; set; }
  }
}