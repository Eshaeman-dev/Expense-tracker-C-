using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeandExpenseTracker
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True;");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();

            this.Hide();
        }
        
        private void register_Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = (register_Showpassword.Checked) ? '*' : '\0';
            register_cPassword.PasswordChar = (register_Showpassword.Checked) ? '*' : '\0';

        }
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * from users WHERE username=@username";
                        using(SqlCommand checkUser=new SqlCommand(selectUsername,connect)) {
                            checkUser.Parameters.AddWithValue("@username",register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if(table.Rows.Count != 0)
                            {
                                string tempUsername =register_username.Text.Substring(0,1).ToUpper()+register_username.Text.Substring(1);
                                MessageBox.Show(tempUsername+"is  existing already","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Inavid Password, At least 8 characters are needed!","Error Mesaage",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }

                            else if (register_password.Text!=register_cPassword.Text)
                            {
                                MessageBox.Show("Password does not match!", "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "Insert into users(username,password,date_create)Values (@username,@password,@date)";

                                using(SqlCommand insertUser=new SqlCommand(insertData,connect)) { 
                                    insertUser.Parameters.AddWithValue("@username",register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@password", register_password.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date",today);
                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginform = new Form1();
                                    loginform.Show();

                                    this.Hide();
                                }

                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Failed ConnectionL"+ex , "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
