namespace api.Models;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; } = String.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    //Foreign Key
    public int? StockId { get; set; }
    public Stocks? Stocks { get; set; }
}