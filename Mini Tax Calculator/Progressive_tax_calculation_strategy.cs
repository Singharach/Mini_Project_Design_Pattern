
public class ProgressiveTaxCalculationStrategy : ITaxCalculationStrategy
{
    public decimal CalculateTax(decimal income)
    {
        decimal tax = 0;

        if (income > 5000000)
        {
            tax += (income - 5000000) * 0.35m;
            income = 5000000;
        }
        if (income > 2000000)
        {
            tax += (income - 2000000) * 0.3m;
            income = 2000000;
        }
        if (income > 1000000)
        {
            tax += (income - 1000000) * 0.25m;
            income = 1000000;
        }
        if (income > 750000)
        {
            tax += (income - 750000) * 0.2m;
            income = 750000;
        }
        if (income > 500000)
        {
            tax += (income - 500000) * 0.15m;
            income = 500000;
        }
        if (income > 300000)
        {
            tax += (income - 300000) * 0.1m;
            income = 300000;
        }
        if (income > 150000)
        {
            tax += (income - 150000) * 0.05m;
        }

        return tax;
    }
}


