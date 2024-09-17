// Dharmin Patel
public class Supply : InvItem
{
    public string Manufacturer { get; set; }

    public Supply() { }

    public Supply(int itemNo, string description, decimal price, string manufacturer)
        : base(itemNo, description, price)
    {
        Manufacturer = manufacturer;
    }

    // Override the GetDisplayText method to include Manufacturer
    public override string GetDisplayText() => $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
}
