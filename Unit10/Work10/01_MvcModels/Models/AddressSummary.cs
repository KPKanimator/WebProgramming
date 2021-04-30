using System.ComponentModel;

namespace _01_MvcModels.Models
{
  public class AddressSummary
  {
    [DisplayName("Город")]
    public string City { get; set; }
    public string Country { get; set; }
  }
}