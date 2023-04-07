public class Net_income
{
    public decimal CalculateNetIncome(decimal income_per_year, decimal expenses, decimal discount)
    {
        decimal net_income = 0;

        net_income += income_per_year - expenses - discount;

        return net_income;
    }
}

