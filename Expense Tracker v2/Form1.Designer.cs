namespace Expense_Tracker_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAmount = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Location = new System.Drawing.Point(98, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(52, 16);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "Amount";
            this.txtAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNote
            // 
            this.txtNote.AutoSize = true;
            this.txtNote.Location = new System.Drawing.Point(98, 63);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(36, 16);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "Note";
            this.txtNote.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoSize = true;
            this.cmbCategory.Location = new System.Drawing.Point(98, 113);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(62, 16);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Text = "Category";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(98, 186);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 16);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(98, 252);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(39, 16);
            this.type.TabIndex = 4;
            this.type.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "      ";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(174, 188);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 8;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.Location = new System.Drawing.Point(174, 248);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(72, 20);
            this.rbIncome.TabIndex = 9;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = true;
            // 
            // rbExpense
            // 
            this.rbExpense.AutoSize = true;
            this.rbExpense.Location = new System.Drawing.Point(303, 248);
            this.rbExpense.Name = "rbExpense";
            this.rbExpense.Size = new System.Drawing.Size(81, 20);
            this.rbExpense.TabIndex = 10;
            this.rbExpense.TabStop = true;
            this.rbExpense.Text = "Expense";
            this.rbExpense.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbExpense);
            this.Controls.Add(this.rbIncome);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label txtNote;
        private System.Windows.Forms.Label cmbCategory;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

