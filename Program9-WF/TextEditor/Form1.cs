namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RichTextBox richTextBox;
        Form childForm;
        string fileName1;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
            // Show the OpenFileDialog control. 
            openFileDialog.ShowDialog();
      
            fileName1=openFileDialog.FileName;
            label1.Text = fileName1;
            // Display the child form.
            // childForm.Show();
            // Create a new child form.
            childForm = new Form();

            // Add a RichTextBox control to the child form.

            richTextBox = new RichTextBox();
            childForm.Controls.Add(richTextBox);
            // Load the specified text file into the

            richTextBox.LoadFile(fileName1);
            richTextBox1.LoadFile(fileName1);
            childForm.Show();

            // Display the child form. childForm.Show();
            richTextBox.Size = childForm.ClientSize;
            childForm.Resize += new EventHandler(childForm_Resize);
            //childForm.MaximumSizeChanged += new EventHandler(childForm_Maximized); //childForm.MinimumSizeChanged += new EventHandler(childForm_Minimized);

            buttonEdit.Enabled = true;
            buttonSave.Enabled = true;
        }
        private void childForm_Resize(object sender, EventArgs e)
        {
            // Resize the RichTextBox control to fill the form 
            richTextBox.Size = childForm.ClientSize;
        }
        private void childForm_Maximized(object sender, EventArgs e)
        {
            // Maximize the RichTextBox control. 
            childForm.MaximizeBox = true;
            childForm.Show();
        }
        private void childForm_Minimized(object sender, EventArgs e)

        {

            // Minimize the RichTextBox control. 
            childForm.MinimizeBox = true;
            childForm.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            richTextBox.SaveFile(fileName1);
            richTextBox1.LoadFile(fileName1);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            richTextBox.ReadOnly = !richTextBox.ReadOnly;
            richTextBox1.ReadOnly = !richTextBox1.ReadOnly;

        }
    }
}