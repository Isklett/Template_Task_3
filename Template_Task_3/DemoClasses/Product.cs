namespace Template_Task_3.DemoClasses;

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock 
    { 
        get; 
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Stock can't be negative, kept old value");
                return;
            }
            field = value;
        }
    }

    public Product(string code, string name, decimal price, int stock)
    {
        Code = code;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"{Code}: {Name}, {Price} kr, saldo: {Stock}";
    }
}
