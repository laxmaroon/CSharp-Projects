namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dateTimePicker1.Value;
            TimeSpan age = DateTime.Today - dateOfBirth;
            int years = (int)(age.TotalDays / 365.25);
            MessageBox.Show("Your age is: " + years.ToString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}