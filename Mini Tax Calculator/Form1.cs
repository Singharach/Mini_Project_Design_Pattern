namespace Mini_Tax_Calculator
{
    public partial class Form1 : Form
    {
        private TaxCalculator _taxCalculator;
        public Form1()
        {
            InitializeComponent();

            _taxCalculator = new TaxCalculator(new ProgressiveTaxCalculationStrategy());
            _taxCalculator = new TaxCalculator(new FlatTaxCalculationStrategy());
        }

        private void progressiveTaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (progressiveTaxRadioButton.Checked)
            {
                _taxCalculator = new TaxCalculator(new ProgressiveTaxCalculationStrategy());
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(incomeTextBox.Text);

            decimal tax = _taxCalculator.CalculateTax(income);

            taxLabel.Text = $"ภาษี: {tax:C}";
        }

        private void flatTaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flatTaxRadioButton.Checked)
            {
                _taxCalculator = new TaxCalculator(new FlatTaxCalculationStrategy());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void taxLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Net_income net_Income = new Net_income();

            decimal income_year = decimal.Parse(income_per_year.Text);
            decimal expense = decimal.Parse(expenses.Text);
            decimal discounts = decimal.Parse(discount.Text);

            decimal netIncome = net_Income.CalculateNetIncome(income_year, expense, discounts);

            net_income.Text = $"เงินได้สุทธิ:  {netIncome:C}";
            incomeTextBox.Text = netIncome.ToString();

        }
    }
}