namespace Calculator
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
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(249, 137);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(125, 27);
            this.txtNumber2.TabIndex = 0;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(168, 107);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(75, 20);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number 1";
            this.lblNumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(249, 182);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(151, 28);
            this.cmbOperator.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(278, 237);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(249, 104);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(125, 27);
            this.txtNumber1.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(289, 322);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(123, 190);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(120, 20);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Select Operation";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(168, 144);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(75, 20);
            this.lblNumber2.TabIndex = 7;
            this.lblNumber2.Text = "Number 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumber2;
        private Label lblNumber1;
        private ComboBox cmbOperator;
        private Button btnCalculate;
        private TextBox txtNumber1;
        private Label lblResult;
        private Label lblOperator;
        private Label lblNumber2;
    }
}