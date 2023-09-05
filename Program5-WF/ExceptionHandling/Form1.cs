namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input from textboxes
                double number1 = double.Parse(txtNumber1.Text);
                double number2 = double.Parse(txtNumber2.Text);

                // Perform the calculation
                double result = number1 + number2;

                // Display the result
                lblResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                // Handle FormatException (non-numeric input)
                lblResult.Text = "Error: Invalid input. Please enter numeric values.";
            }
            catch (OverflowException)
            {
                // Handle OverflowException (input exceeds the range of a double)
                lblResult.Text = "Error: Input exceeds the valid range.";
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                lblResult.Text = "Error: " + ex.Message;
            }
        }
    
    }
}