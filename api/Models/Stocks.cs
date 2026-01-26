using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace api.Models;

public class Stocks
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = string.Empty;    
    [Column(TypeName = "decimal(18,2)")]

    public string Symbol { get; set; } = string.Empty;

    public decimal Purchase { get; set; }
    [Column(TypeName = "decimal(18,2)")]

    public decimal LastDiv { get; set; }

    public string Industry { get; set; } = string.Empty;

    public long MarketCap { get; set; }

    public List<XmlComment> Comments { get; set; } = new List<XmlComment>();

}