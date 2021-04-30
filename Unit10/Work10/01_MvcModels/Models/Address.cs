using System.ComponentModel;

namespace _01_MvcModels.Models
{
  public class Address
  {
    [DisplayName("Адрес 1")]
    public string Line1 { get; set; }

    [DisplayName("Адрес 2")]
    public string Line2 { get; set; }

    [DisplayName("Город")]
    public string City { get; set; }

    [DisplayName("Почтовый индекс")]
    public string PostalCode { get; set; }

    [DisplayName("Страна")]
    public string Country { get; set; }
  }
}