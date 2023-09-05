using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderApp1
{
    public partial class Form1 : Form
    { 
    
    
        delegate void UpdateLabelDelegate(int value);
        private void lblValue_Click(object sender, EventArgs e)
        {

        }
        public Form1()
    {
        InitializeComponent();
    }

 

    private void SldValue_Scroll(object sender, EventArgs e)
    {
        UpdateLabel(sldValue.Value);
    }

      
        private void UpdateLabel(int value)
    {
        if (lblValue.InvokeRequired)
        {
            UpdateLabelDelegate updateDelegate = new UpdateLabelDelegate(UpdateLabel);
            lblValue.Invoke(updateDelegate, new object[] { value });
        }
        else
        {
            lblValue.Text = value.ToString();
        }
    }

        private void sldValue_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            sldValue.Scroll += SldValue_Scroll;

        }
    }
}
 
