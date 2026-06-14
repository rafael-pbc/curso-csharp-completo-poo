using System.Globalization;

class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    // O ': base(name, price)' repassa os dados para o construtor da classe pai
    public ImportedProduct(string name, double price, double customsFee)
        : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }

    // 'override' substitui o comportamento do método da classe pai
    public override string PriceTag()
    {
        return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
               $"(Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    }
}