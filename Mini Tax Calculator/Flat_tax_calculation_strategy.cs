public class FlatTaxCalculationStrategy : ITaxCalculationStrategy
{
    public decimal CalculateTax(decimal income)
    {
        return income * 0.15m;
    }
}
