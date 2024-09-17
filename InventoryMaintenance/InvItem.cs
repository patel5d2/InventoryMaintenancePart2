// Dharmin Patel
public class InvItem
{
    public InvItem() { }

    public InvItem(int itemNo, string description, decimal price)
    {
        ItemNo = itemNo;
        Description = description;
        Price = price;
    }

    public int ItemNo { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // Virtual method that can be overridden by derived classes
    public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
}
