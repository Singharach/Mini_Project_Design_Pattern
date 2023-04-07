namespace Mini_Tax_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flatTaxRadioButton = new RadioButton();
            progressiveTaxRadioButton = new RadioButton();
            calculateButton = new Button();
            taxLabel = new Label();
            incomeTextBox = new TextBox();
            income = new Label();
            income_per_year = new TextBox();
            expenses = new TextBox();
            discount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            minus2 = new Label();
            minus = new Label();
            net_income = new Label();
            Equle = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flatTaxRadioButton
            // 
            flatTaxRadioButton.AutoSize = true;
            flatTaxRadioButton.Location = new Point(521, 28);
            flatTaxRadioButton.Name = "flatTaxRadioButton";
            flatTaxRadioButton.Size = new Size(109, 24);
            flatTaxRadioButton.TabIndex = 0;
            flatTaxRadioButton.TabStop = true;
            flatTaxRadioButton.Text = "ภาษีอัตราคงที่";
            flatTaxRadioButton.UseVisualStyleBackColor = true;
            flatTaxRadioButton.CheckedChanged += flatTaxRadioButton_CheckedChanged;
            // 
            // progressiveTaxRadioButton
            // 
            progressiveTaxRadioButton.AutoSize = true;
            progressiveTaxRadioButton.Location = new Point(521, 58);
            progressiveTaxRadioButton.Name = "progressiveTaxRadioButton";
            progressiveTaxRadioButton.Size = new Size(133, 24);
            progressiveTaxRadioButton.TabIndex = 1;
            progressiveTaxRadioButton.TabStop = true;
            progressiveTaxRadioButton.Text = "ภาษีอัตราก้าวหน้า";
            progressiveTaxRadioButton.UseVisualStyleBackColor = true;
            progressiveTaxRadioButton.CheckedChanged += progressiveTaxRadioButton_CheckedChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(660, 26);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Submit";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new Point(230, 26);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(45, 20);
            taxLabel.TabIndex = 3;
            taxLabel.Text = "ภาษี : ";
            taxLabel.Click += taxLabel_Click;
            // 
            // incomeTextBox
            // 
            incomeTextBox.Location = new Point(104, 159);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new Size(125, 27);
            incomeTextBox.TabIndex = 4;
            incomeTextBox.Text = "0";
            // 
            // income
            // 
            income.AutoSize = true;
            income.BackColor = Color.Transparent;
            income.Location = new Point(21, 162);
            income.Name = "income";
            income.Size = new Size(77, 20);
            income.TabIndex = 5;
            income.Text = "เงินได้สุทธิ : ";
            // 
            // income_per_year
            // 
            income_per_year.Location = new Point(18, 65);
            income_per_year.Name = "income_per_year";
            income_per_year.Size = new Size(125, 27);
            income_per_year.TabIndex = 6;
            income_per_year.Text = "0";
            // 
            // expenses
            // 
            expenses.Location = new Point(181, 65);
            expenses.Name = "expenses";
            expenses.Size = new Size(125, 27);
            expenses.TabIndex = 7;
            expenses.Text = "0";
            // 
            // discount
            // 
            discount.Location = new Point(336, 65);
            discount.Name = "discount";
            discount.Size = new Size(125, 27);
            discount.TabIndex = 8;
            discount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 9;
            label1.Text = "เงินได้ทั้งปี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 34);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 10;
            label2.Text = "ค่าใช้จ่าย";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 34);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 11;
            label3.Text = "ค่าลดหย่อน";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(minus2);
            groupBox1.Controls.Add(minus);
            groupBox1.Controls.Add(net_income);
            groupBox1.Controls.Add(Equle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(income_per_year);
            groupBox1.Controls.Add(discount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(expenses);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 107);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "เงินได้สุทธิ";
            // 
            // button1
            // 
            button1.Location = new Point(660, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // minus2
            // 
            minus2.AutoSize = true;
            minus2.Location = new Point(312, 34);
            minus2.Name = "minus2";
            minus2.Size = new Size(15, 20);
            minus2.TabIndex = 16;
            minus2.Text = "-";
            // 
            // minus
            // 
            minus.AutoSize = true;
            minus.Location = new Point(153, 34);
            minus.Name = "minus";
            minus.Size = new Size(15, 20);
            minus.TabIndex = 15;
            minus.Text = "-";
            // 
            // net_income
            // 
            net_income.AutoSize = true;
            net_income.Location = new Point(501, 68);
            net_income.Name = "net_income";
            net_income.Size = new Size(77, 20);
            net_income.TabIndex = 14;
            net_income.Text = "เงินได้สุทธิ : ";
            // 
            // Equle
            // 
            Equle.AutoSize = true;
            Equle.Location = new Point(476, 68);
            Equle.Name = "Equle";
            Equle.Size = new Size(19, 20);
            Equle.TabIndex = 13;
            Equle.Text = "=";
            Equle.Click += label4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(calculateButton);
            groupBox2.Controls.Add(flatTaxRadioButton);
            groupBox2.Controls.Add(taxLabel);
            groupBox2.Controls.Add(progressiveTaxRadioButton);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 302);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tax";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(6, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(509, 224);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(income);
            Controls.Add(incomeTextBox);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tax Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton flatTaxRadioButton;
        private RadioButton progressiveTaxRadioButton;
        private Button calculateButton;
        private Label taxLabel;
        private TextBox incomeTextBox;
        private Label income;
        private TextBox income_per_year;
        private TextBox expenses;
        private TextBox discount;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label net_income;
        private Label Equle;
        private Label minus2;
        private Label minus;
        private Button button1;
        private GroupBox groupBox2;
        private ListBox listBox1;
    }
}