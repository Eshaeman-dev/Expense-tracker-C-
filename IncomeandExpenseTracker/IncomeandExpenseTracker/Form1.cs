using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Diagnostics.Eventing.Reader;
using IncomeandExpenseTracker.Properties;
using System.Collections.Generic;
using System.Runtime;

namespace IncomeandExpenseTracker
{
    public partial class Form1 :Form
    {
        string connectionString = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implementation for label click event
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            regform.Show();
            this.Hide();
        }

        public static string username;
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {

                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string selectData = "Select * from users WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            username = login_username.Text;
                            MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mform= new MainForm();
                            mform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }
        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = (show_password.Checked) ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}