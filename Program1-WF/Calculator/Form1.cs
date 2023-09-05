namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                double result = 0;

                switch (cmbOperator.Text)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            MessageBox.Show("Cannot divide by zero!");
                        break;
                }

                lblResult.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }
    }
}