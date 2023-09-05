namespace Colour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox.MouseEnter += TextBox_MouseEnter; // Attach MouseEnter event handler
            txtBox.MouseLeave += TextBox_MouseLeave;
        }
        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Yellow; // Change background color to yellow on MouseEnter
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.White; // Change background color to white on MouseLeave
        }
    }
}