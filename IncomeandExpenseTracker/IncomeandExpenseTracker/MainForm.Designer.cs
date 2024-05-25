namespace IncomeandExpenseTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Expense_btn = new System.Windows.Forms.Button();
            this.Income_btn = new System.Windows.Forms.Button();
            this.Category_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.greetuser = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dashboardForm11 = new IncomeandExpenseTracker.DashBoard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashBoard1 = new IncomeandExpenseTracker.DashBoard();
            this.add_Category1 = new IncomeandExpenseTracker.Add_Category();
            this.income1 = new IncomeandExpenseTracker.Income();
            this.expense1 = new IncomeandExpenseTracker.Expense();
            this.dashBoard2 = new IncomeandExpenseTracker.DashBoard();
            this.add_Category2 = new IncomeandExpenseTracker.Add_Category();
            this.expense2 = new IncomeandExpenseTracker.Expense();
            this.income2 = new IncomeandExpenseTracker.Income();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1141, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 15;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Income and Expense Tracker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 589);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Expense_btn);
            this.panel2.Controls.Add(this.Income_btn);
            this.panel2.Controls.Add(this.Category_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Controls.Add(this.greetuser);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 589);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(16, 539);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(31, 305);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(31, 267);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(31, 228);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(31, 188);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Gray;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(12, 535);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(189, 33);
            this.Logout_btn.TabIndex = 6;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // Expense_btn
            // 
            this.Expense_btn.BackColor = System.Drawing.Color.Gray;
            this.Expense_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_btn.ForeColor = System.Drawing.Color.White;
            this.Expense_btn.Location = new System.Drawing.Point(13, 300);
            this.Expense_btn.Name = "Expense_btn";
            this.Expense_btn.Size = new System.Drawing.Size(189, 33);
            this.Expense_btn.TabIndex = 5;
            this.Expense_btn.Text = "Expense";
            this.Expense_btn.UseVisualStyleBackColor = false;
            this.Expense_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Income_btn
            // 
            this.Income_btn.BackColor = System.Drawing.Color.Gray;
            this.Income_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_btn.ForeColor = System.Drawing.Color.White;
            this.Income_btn.Location = new System.Drawing.Point(13, 262);
            this.Income_btn.Name = "Income_btn";
            this.Income_btn.Size = new System.Drawing.Size(189, 32);
            this.Income_btn.TabIndex = 4;
            this.Income_btn.Text = "Income";
            this.Income_btn.UseVisualStyleBackColor = false;
            this.Income_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Category_btn
            // 
            this.Category_btn.BackColor = System.Drawing.Color.Gray;
            this.Category_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_btn.ForeColor = System.Drawing.Color.White;
            this.Category_btn.Location = new System.Drawing.Point(13, 223);
            this.Category_btn.Name = "Category_btn";
            this.Category_btn.Size = new System.Drawing.Size(189, 33);
            this.Category_btn.TabIndex = 3;
            this.Category_btn.Text = "Add Category";
            this.Category_btn.UseVisualStyleBackColor = false;
            this.Category_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.Color.Gray;
            this.Dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 178);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(189, 39);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "DashBoard";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // greetuser
            // 
            this.greetuser.AutoSize = true;
            this.greetuser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetuser.ForeColor = System.Drawing.Color.White;
            this.greetuser.Location = new System.Drawing.Point(12, 135);
            this.greetuser.Name = "greetuser";
            this.greetuser.Size = new System.Drawing.Size(92, 23);
            this.greetuser.TabIndex = 1;
            this.greetuser.Text = "Welcome,";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(54, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "DashBoard";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(54, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // dashboardForm11
            // 
            this.dashboardForm11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardForm11.Location = new System.Drawing.Point(221, 38);
            this.dashboardForm11.Name = "dashboardForm11";
            this.dashboardForm11.Size = new System.Drawing.Size(800, 582);
            this.dashboardForm11.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashBoard1.Location = new System.Drawing.Point(217, 40);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(941, 589);
            this.dashBoard1.TabIndex = 22;
            // 
            // add_Category1
            // 
            this.add_Category1.Location = new System.Drawing.Point(221, 38);
            this.add_Category1.Name = "add_Category1";
            this.add_Category1.Size = new System.Drawing.Size(962, 591);
            this.add_Category1.TabIndex = 23;
            // 
            // income1
            // 
            this.income1.Location = new System.Drawing.Point(229, 38);
            this.income1.Name = "income1";
            this.income1.Size = new System.Drawing.Size(954, 591);
            this.income1.TabIndex = 24;
            // 
            // expense1
            // 
            this.expense1.Location = new System.Drawing.Point(218, 38);
            this.expense1.Name = "expense1";
            this.expense1.Size = new System.Drawing.Size(965, 591);
            this.expense1.TabIndex = 25;
            // 
            // dashBoard2
            // 
            this.dashBoard2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashBoard2.Location = new System.Drawing.Point(218, 43);
            this.dashBoard2.Name = "dashBoard2";
            this.dashBoard2.Size = new System.Drawing.Size(965, 582);
            this.dashBoard2.TabIndex = 26;
            // 
            // add_Category2
            // 
            this.add_Category2.Location = new System.Drawing.Point(221, 38);
            this.add_Category2.Name = "add_Category2";
            this.add_Category2.Size = new System.Drawing.Size(962, 591);
            this.add_Category2.TabIndex = 27;
            // 
            // expense2
            // 
            this.expense2.Location = new System.Drawing.Point(218, 41);
            this.expense2.Name = "expense2";
            this.expense2.Size = new System.Drawing.Size(961, 587);
            this.expense2.TabIndex = 28;
            // 
            // income2
            // 
            this.income2.Location = new System.Drawing.Point(218, 39);
            this.income2.Name = "income2";
            this.income2.Size = new System.Drawing.Size(963, 590);
            this.income2.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 629);
            this.Controls.Add(this.income2);
            this.Controls.Add(this.expense2);
            this.Controls.Add(this.add_Category2);
            this.Controls.Add(this.dashBoard2);
            this.Controls.Add(this.expense1);
            this.Controls.Add(this.income1);
            this.Controls.Add(this.add_Category1);
            this.Controls.Add(this.dashBoard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label greetuser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Expense_btn;
        private System.Windows.Forms.Button Income_btn;
        private System.Windows.Forms.Button Category_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private DashBoard dashboardForm11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DashBoard dashBoard1;
        private Add_Category add_Category1;
        private Income income1;
        private Expense expense1;
        private DashBoard dashBoard2;
        private Add_Category add_Category2;
        private Expense expense2;
        private Income income2;
    }
}