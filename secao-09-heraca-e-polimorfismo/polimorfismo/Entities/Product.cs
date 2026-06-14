using System.Globalization;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // 'virtual' permite que as classes filhas modifiquem o comportamento deste método
    public virtual string PriceTag()
    {
        return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}