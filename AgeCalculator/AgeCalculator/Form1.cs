namespace AgeCalculator
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dateTimePicker1.Value;
            TimeSpan age = DateTime.Today - dateOfBirth;
            int years = (int)(age.TotalDays / 365.25);
            MessageBox.Show("Your age is: " + years.ToString());

        }
    }
}