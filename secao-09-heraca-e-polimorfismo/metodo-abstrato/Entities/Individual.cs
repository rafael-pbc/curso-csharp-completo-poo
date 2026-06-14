using System;
class Individual : TaxPayer
{
    public double HealthExpenditures { get; set; }

    public Individual(string name, double anualIncome, double healthExpenditures)
        : base(name, anualIncome)
    {
        HealthExpenditures = healthExpenditures;
    }

    public override double Tax()
    {
        double basicTax;

        if (AnualIncome < 20000.0)
        {
            basicTax = AnualIncome * 0.15;
        }
        else
        {
            basicTax = AnualIncome * 0.25;
        }

        double taxDeduction = HealthExpenditures * 0.5;
        double totalTax = basicTax - taxDeduction;

        return (totalTax < 0.0) ? 0.0 : totalTax;
    }
}