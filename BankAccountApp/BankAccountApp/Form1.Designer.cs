namespace BankAccountApp
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
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = " Owner\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 229);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 31);
            textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 227);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(203, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(405, 29);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 62;
            BankAccountGrid.Size = new Size(691, 225);
            BankAccountGrid.TabIndex = 5;
            BankAccountGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(510, 276);
            button1.Name = "button1";
            button1.Size = new Size(191, 57);
            button1.TabIndex = 6;
            button1.Text = "Deposit ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(717, 276);
            button2.Name = "button2";
            button2.Size = new Size(195, 57);
            button2.TabIndex = 7;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(107, 94);
            button4.Name = "button4";
            button4.Size = new Size(203, 34);
            button4.TabIndex = 9;
            button4.Text = "Create Account";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BankAccountGrid);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DataGridView BankAccountGrid;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}
