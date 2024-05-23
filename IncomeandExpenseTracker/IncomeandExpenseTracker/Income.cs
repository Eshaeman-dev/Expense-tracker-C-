using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IncomeandExpenseTracker
{
    public partial class Income :Form
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public Income()
        {
            InitializeComponent();
            displayCategorylist();
            displayIncomeData();
        }
        public void displayIncomeData()
        {
            IncomeData iData=new IncomeData();
            List<IncomeData> listData=new List<IncomeData>();
            dataGridView1.DataSource=listData;
        }
        public void displayCategorylist()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "Select category from categories Where type=@type AND status=@status";

                using (SqlCommand command = new SqlCommand(selectData, connect))
                {
                    command.Parameters.AddWithValue("@type", "Income");
                    command.Parameters.AddWithValue("@status", "Active");

                    income_category.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["category"].ToString());
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            // Add any initialization code here, if necessary
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Add any custom painting code here, if necessary
        }

        private void category_updatebtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 ||
           string.IsNullOrEmpty(income_item.Text) ||
           string.IsNullOrEmpty(income_income.Text) ||
           string.IsNullOrEmpty(income_description.Text))
            {
                MessageBox.Show("Please select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "UPDATE income Set category=@cat, item=@item, income=@income,description=@desc" +
                        "date_income=@date_in WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        command.Parameters.AddWithValue("@item", income_item.Text);
                        command.Parameters.AddWithValue("@income", income_income.Text);
                        command.Parameters.AddWithValue("@desc", income_description.Text);
                        command.Parameters.AddWithValue("@date_in", income_date.Value);
                        command.Parameters.AddWithValue("@id", getID);

                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Add functionality for label click
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Add functionality for label click
        }

        private void income_addbtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 ||
                string.IsNullOrEmpty(income_item.Text) ||
                string.IsNullOrEmpty(income_income.Text) ||
                string.IsNullOrEmpty(income_description.Text))
            {
                MessageBox.Show("Please Fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "Insert into income(category, item, income, description, date_income, date_insert) Values" +
                                        "(@cat, @item, @income, @desc, @date_in, @date)";

                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        command.Parameters.AddWithValue("@item", income_item.Text);
                        command.Parameters.AddWithValue("@income", income_income.Text);
                        command.Parameters.AddWithValue("@desc", income_description.Text);
                        command.Parameters.AddWithValue("@date_in", income_date.Value);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date", today);

                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
        }
        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_income.Text = "";
            income_description.Text = "";

        }
        private void income_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text = row.Cells[1].Value.ToString();
                income_income.Text = row.Cells[1].Value.ToString();
                income_description.Text = row.Cells[1].Value.ToString();
                income_date.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());


            }
        }

        private void income_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
