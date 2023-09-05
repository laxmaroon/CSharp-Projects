namespace Practice2
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        RichTextBox richTextBox;
        Form childForm;
        string filename1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();

            openFileDialog.Filter = "Rich Text Files (*tf)|*.rtf";
            openFileDialog.ShowDialog();

            filename1= openFileDialog.FileName;
            label1.Text = filename1;

            childForm = new Form();
            richTextBox = new RichTextBox();

            childForm.Controls.Add(richTextBox);

            richTextBox.LoadFile(filename1);
            richTextBox.LoadFile(filename1);
            childForm.Show();

            richTextBox.Size = childForm.ClientSize;
            childForm.Resize += new EventHandler(childForm_Resize);

            buttonEdit.Enabled = true;
            buttonSave.Enabled = true;

        }

         private void childForm_Resize(object sender, EventArgs e)
        {
            richTextBox.Size= childForm.ClientSize;

        }
        private void childForm_Minimised(object sender, EventArgs e)
        {
            childForm.MinimizeBox = true;
            childForm.Show();
        }

        private void childForm_Maximised(object sender, EventArgs e)
        {
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            richTextBox.ReadOnly=!richTextBox.ReadOnly;
            richTextBox1.ReadOnly = !richTextBox1.ReadOnly;


        }
    }
}