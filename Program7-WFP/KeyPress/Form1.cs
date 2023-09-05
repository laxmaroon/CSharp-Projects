using System;
using System.Drawing;
using System.Windows.Forms;
namespace KeyPress
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
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Display the pressed key in a label
            lblKeyPressed.Text = "Pressed Key: " + e.KeyCode;

            // Change the text color based on the arrow key pressed
            if (e.KeyCode == Keys.Up)
                lblKeyPressed.ForeColor = Color.Red;
            else if (e.KeyCode == Keys.Down)
                lblKeyPressed.ForeColor = Color.Blue;
            else if (e.KeyCode == Keys.Left)
                lblKeyPressed.ForeColor = Color.Green;
            else if (e.KeyCode == Keys.Right)
                lblKeyPressed.ForeColor = Color.Orange;
            else
                lblKeyPressed.ForeColor = Color.Black;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent beep sound when non-character keys are pressed
            e.Handled = true;
        }
    }
}