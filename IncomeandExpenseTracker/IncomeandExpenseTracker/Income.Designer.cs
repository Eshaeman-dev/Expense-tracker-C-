﻿namespace IncomeandExpenseTracker
{
    partial class Income
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
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.income_deletebtn = new System.Windows.Forms.Button();
            this.income_clearbtn = new System.Windows.Forms.Button();
            this.income_updatebtn = new System.Windows.Forms.Button();
            this.income_addbtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.income_income = new System.Windows.Forms.TextBox();
            this.income_item = new System.Windows.Forms.TextBox();
            this.income_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(877, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 16;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 218);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income list";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.income_deletebtn);
            this.panel2.Controls.Add(this.income_clearbtn);
            this.panel2.Controls.Add(this.income_updatebtn);
            this.panel2.Controls.Add(this.income_addbtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.income_description);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.income_income);
            this.panel2.Controls.Add(this.income_item);
            this.panel2.Controls.Add(this.income_category);
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 218);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Income:";
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // income_deletebtn
            // 
            this.income_deletebtn.BackColor = System.Drawing.Color.Gray;
            this.income_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deletebtn.ForeColor = System.Drawing.Color.White;
            this.income_deletebtn.Location = new System.Drawing.Point(566, 152);
            this.income_deletebtn.Name = "income_deletebtn";
            this.income_deletebtn.Size = new System.Drawing.Size(87, 50);
            this.income_deletebtn.TabIndex = 16;
            this.income_deletebtn.Text = "Delete";
            this.income_deletebtn.UseVisualStyleBackColor = false;
            // 
            // income_clearbtn
            // 
            this.income_clearbtn.BackColor = System.Drawing.Color.Gray;
            this.income_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearbtn.ForeColor = System.Drawing.Color.White;
            this.income_clearbtn.Location = new System.Drawing.Point(450, 152);
            this.income_clearbtn.Name = "income_clearbtn";
            this.income_clearbtn.Size = new System.Drawing.Size(87, 50);
            this.income_clearbtn.TabIndex = 15;
            this.income_clearbtn.Text = "Clear";
            this.income_clearbtn.UseVisualStyleBackColor = false;
            this.income_clearbtn.Click += new System.EventHandler(this.income_clearbtn_Click);
            // 
            // income_updatebtn
            // 
            this.income_updatebtn.BackColor = System.Drawing.Color.Gray;
            this.income_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_updatebtn.ForeColor = System.Drawing.Color.White;
            this.income_updatebtn.Location = new System.Drawing.Point(333, 152);
            this.income_updatebtn.Name = "income_updatebtn";
            this.income_updatebtn.Size = new System.Drawing.Size(87, 50);
            this.income_updatebtn.TabIndex = 14;
            this.income_updatebtn.Text = "Update";
            this.income_updatebtn.UseVisualStyleBackColor = false;
            this.income_updatebtn.Click += new System.EventHandler(this.category_updatebtn_Click);
            // 
            // income_addbtn
            // 
            this.income_addbtn.BackColor = System.Drawing.Color.Gray;
            this.income_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addbtn.ForeColor = System.Drawing.Color.White;
            this.income_addbtn.Location = new System.Drawing.Point(212, 152);
            this.income_addbtn.Name = "income_addbtn";
            this.income_addbtn.Size = new System.Drawing.Size(87, 50);
            this.income_addbtn.TabIndex = 13;
            this.income_addbtn.Text = "Add";
            this.income_addbtn.UseVisualStyleBackColor = false;
            this.income_addbtn.Click += new System.EventHandler(this.income_addbtn_Click);
            // 
            // income_date
            // 
            this.income_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_date.Location = new System.Drawing.Point(578, 108);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(269, 26);
            this.income_date.TabIndex = 12;
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
            // income_description
            // 
            this.income_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_description.Location = new System.Drawing.Point(578, 18);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(271, 72);
            this.income_description.TabIndex = 9;
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // income_income
            // 
            this.income_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_income.Location = new System.Drawing.Point(194, 111);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(198, 26);
            this.income_income.TabIndex = 7;
            // 
            // income_item
            // 
            this.income_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_item.Location = new System.Drawing.Point(194, 66);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(198, 26);
            this.income_item.TabIndex = 5;
            // 
            // income_category
            // 
            this.income_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_category.FormattingEnabled = true;
            this.income_category.Items.AddRange(new object[] {
            "Allownce",
            "Scholarship"});
            this.income_category.Location = new System.Drawing.Point(194, 20);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(198, 28);
            this.income_category.TabIndex = 2;
            this.income_category.SelectedIndexChanged += new System.EventHandler(this.income_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Income:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Name = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox income_category;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button income_addbtn;
        private System.Windows.Forms.Button income_updatebtn;
        private System.Windows.Forms.Button income_clearbtn;
        private System.Windows.Forms.Button income_deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}