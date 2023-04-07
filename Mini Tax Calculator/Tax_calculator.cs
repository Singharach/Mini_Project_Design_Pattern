public class TaxCalculator
{
    private ITaxCalculationStrategy _taxCalculationStrategy;



    public TaxCalculator(ITaxCalculationStrategy taxCalculationStrategy)
    {
        _taxCalculationStrategy = taxCalculationStrategy;
    }



    public decimal CalculateTax(decimal income)
    {
        return _taxCalculationStrategy.CalculateTax(income);
    }
}

