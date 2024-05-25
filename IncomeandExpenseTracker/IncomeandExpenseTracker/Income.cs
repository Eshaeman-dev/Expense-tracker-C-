using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeandExpenseTracker
{
    public partial class Income : UserControl
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public Income()
        {
            InitializeComponent();
            displayCategorylist();
            displayIncomeData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayCategorylist();
            displayIncomeData();
        }

        public void displayIncomeData()
        {
            IncomeData incomeData = new IncomeData();
            List<IncomeData> listData = incomeData.incomeListData();
            dataGridView1.DataSource = listData;
        }

        public void displayCategorylist()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT category FROM categories WHERE type=@type AND status=@status";

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
               if( MessageBox.Show("Are you sure you want to update ID:"+getID+"?","Configuration Message",MessageBoxButtons.YesNo
                   , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE income SET category=@cat, item=@item, income=@income, description=@desc, date_income=@date_in WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            command.Parameters.AddWithValue("@item", income_item.Text);
                            command.Parameters.AddWithValue("@income", income_income.Text);
                            command.Parameters.AddWithValue("@desc", income_description.Text);
                            command.Parameters.AddWithValue("@date_in", income_date.Value);
                            command.Parameters.AddWithValue("@id", getID);

                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
               
            }
            displayIncomeData();
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

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert) VALUES (@cat, @item, @income, @desc, @date_in, @date)";

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
            displayIncomeData();
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
                income_item.Text = row.Cells[2].Value.ToString();
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void income_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add functionality for category selection change, if necessary
        }

        private void income_deletebtn_Click(object sender, EventArgs e)
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
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID + "?", "Configuration Message", MessageBoxButtons.YesNo
                  , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM income WHERE  id=@id";

                        using (SqlCommand command = new SqlCommand(deleteData, connect))
                        {

                            command.Parameters.AddWithValue("@id", getID);

                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
                   
            }
            displayIncomeData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void income_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void income_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void income_income_TextChanged(object sender, EventArgs e)
        {

        }

        private void income_item_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
