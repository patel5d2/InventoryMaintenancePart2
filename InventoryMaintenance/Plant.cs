// Dharmin Patel
// The Plant class signifies inheritance by extending the InvItem class.
public class Plant : InvItem
{
    public string Size { get; set; }

    public Plant() { }

    public Plant(int itemNo, string description, decimal price, string size)
        : base(itemNo, description, price)
    {
        Size = size;
    }

    // Override the GetDisplayText method to include Size
    public override string GetDisplayText() => $"{ItemNo}    {Size} {Description} ({Price:c})";
}
