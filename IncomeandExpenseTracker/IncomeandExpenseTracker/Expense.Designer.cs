namespace IncomeandExpenseTracker
{
    partial class Expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expense_deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expense_clearbtn = new System.Windows.Forms.Button();
            this.expense_updatebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expense_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.expense_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expense_cost = new System.Windows.Forms.TextBox();
            this.expense_item = new System.Windows.Forms.TextBox();
            this.expense_category = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expense_addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(136, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Item:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Category:";
            // 
            // expense_deletebtn
            // 
            this.expense_deletebtn.BackColor = System.Drawing.Color.Gray;
            this.expense_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_deletebtn.ForeColor = System.Drawing.Color.White;
            this.expense_deletebtn.Location = new System.Drawing.Point(578, 186);
            this.expense_deletebtn.Name = "expense_deletebtn";
            this.expense_deletebtn.Size = new System.Drawing.Size(87, 50);
            this.expense_deletebtn.TabIndex = 16;
            this.expense_deletebtn.Text = "Delete";
            this.expense_deletebtn.UseVisualStyleBackColor = false;
            this.expense_deletebtn.Click += new System.EventHandler(this.expense_deletebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Expense list";
            // 
            // expense_clearbtn
            // 
            this.expense_clearbtn.BackColor = System.Drawing.Color.Gray;
            this.expense_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_clearbtn.ForeColor = System.Drawing.Color.White;
            this.expense_clearbtn.Location = new System.Drawing.Point(454, 186);
            this.expense_clearbtn.Name = "expense_clearbtn";
            this.expense_clearbtn.Size = new System.Drawing.Size(87, 50);
            this.expense_clearbtn.TabIndex = 15;
            this.expense_clearbtn.Text = "Clear";
            this.expense_clearbtn.UseVisualStyleBackColor = false;
            this.expense_clearbtn.Click += new System.EventHandler(this.expense_clearbtn_Click);
            // 
            // expense_updatebtn
            // 
            this.expense_updatebtn.BackColor = System.Drawing.Color.Gray;
            this.expense_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_updatebtn.ForeColor = System.Drawing.Color.White;
            this.expense_updatebtn.Location = new System.Drawing.Point(336, 186);
            this.expense_updatebtn.Name = "expense_updatebtn";
            this.expense_updatebtn.Size = new System.Drawing.Size(87, 50);
            this.expense_updatebtn.TabIndex = 14;
            this.expense_updatebtn.Text = "Update";
            this.expense_updatebtn.UseVisualStyleBackColor = false;
            this.expense_updatebtn.Click += new System.EventHandler(this.expense_updatebtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(17, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // expense_date
            // 
            this.expense_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_date.Location = new System.Drawing.Point(578, 108);
            this.expense_date.Name = "expense_date";
            this.expense_date.Size = new System.Drawing.Size(269, 26);
            this.expense_date.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date:";
            // 
            // expense_description
            // 
            this.expense_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_description.Location = new System.Drawing.Point(578, 18);
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            this.expense_description.Size = new System.Drawing.Size(271, 72);
            this.expense_description.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description:";
            // 
            // expense_cost
            // 
            this.expense_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_cost.Location = new System.Drawing.Point(194, 111);
            this.expense_cost.Name = "expense_cost";
            this.expense_cost.Size = new System.Drawing.Size(198, 26);
            this.expense_cost.TabIndex = 7;
            // 
            // expense_item
            // 
            this.expense_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_item.Location = new System.Drawing.Point(194, 66);
            this.expense_item.Name = "expense_item";
            this.expense_item.Size = new System.Drawing.Size(198, 26);
            this.expense_item.TabIndex = 5;
            // 
            // expense_category
            // 
            this.expense_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_category.FormattingEnabled = true;
            this.expense_category.Items.AddRange(new object[] {
            "Gadget"});
            this.expense_category.Location = new System.Drawing.Point(190, 18);
            this.expense_category.Name = "expense_category";
            this.expense_category.Size = new System.Drawing.Size(198, 28);
            this.expense_category.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.expense_deletebtn);
            this.panel2.Controls.Add(this.expense_clearbtn);
            this.panel2.Controls.Add(this.expense_updatebtn);
            this.panel2.Controls.Add(this.expense_addbtn);
            this.panel2.Controls.Add(this.expense_date);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.expense_description);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.expense_cost);
            this.panel2.Controls.Add(this.expense_item);
            this.panel2.Controls.Add(this.expense_category);
            this.panel2.Location = new System.Drawing.Point(8, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 249);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // expense_addbtn
            // 
            this.expense_addbtn.BackColor = System.Drawing.Color.Gray;
            this.expense_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_addbtn.ForeColor = System.Drawing.Color.White;
            this.expense_addbtn.Location = new System.Drawing.Point(213, 186);
            this.expense_addbtn.Name = "expense_addbtn";
            this.expense_addbtn.Size = new System.Drawing.Size(87, 50);
            this.expense_addbtn.TabIndex = 13;
            this.expense_addbtn.Text = "Add";
            this.expense_addbtn.UseVisualStyleBackColor = false;
            this.expense_addbtn.Click += new System.EventHandler(this.expense_addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 220);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Expense";
            this.Size = new System.Drawing.Size(961, 516);
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button expense_deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button expense_clearbtn;
        private System.Windows.Forms.Button expense_updatebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker expense_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expense_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expense_cost;
        private System.Windows.Forms.TextBox expense_item;
        private System.Windows.Forms.ComboBox expense_category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button expense_addbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}