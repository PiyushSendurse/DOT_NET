namespace BusinessObjectLayer;
public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageURL { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public float UnitPrice { get; set; }
    public int Balance { get; set; }
    public string PaymentTerm { get; set; }
    public string Delivery { get; set; }

    public Product() {}
    public Product(int productId, string title, string category,
                    string description, float unitPrice, int balance)
    {
        this.Id = productId;
        this.Title = title;
        this.Category = category;
        this.Description = description;
        this.UnitPrice = unitPrice;
        this.Balance = balance;

    }

}
