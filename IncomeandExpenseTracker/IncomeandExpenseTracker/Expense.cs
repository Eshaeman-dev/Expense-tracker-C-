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
    public partial class Expense : UserControl
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public Expense()
        {
            InitializeComponent();
            displayCategorylist();
            displayExpenseData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayCategorylist();
            displayExpenseData();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayExpenseData()
        {
            ExpenseData expenseData = new ExpenseData();
            List<ExpenseData> listData = expenseData.expenseListData();
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
                    command.Parameters.AddWithValue("@type", "Expenses");
                    command.Parameters.AddWithValue("@status", "Active");

                    expense_category.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        expense_category.Items.Add(reader["category"].ToString());
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }

        private void expense_addbtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 ||
                string.IsNullOrEmpty(expense_item.Text) ||
                string.IsNullOrEmpty(expense_cost.Text) ||
                string.IsNullOrEmpty(expense_description.Text))
            {
                MessageBox.Show("Please Fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO expenses (category, item, cost, description, date_expense, " +
                        "date_insert) VALUES (@cat, @item, @cost, @desc, @date_ex, @date)";

                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                        command.Parameters.AddWithValue("@item", expense_item.Text);
                        command.Parameters.AddWithValue("@cost", expense_cost.Text);
                        command.Parameters.AddWithValue("@desc", expense_description.Text);
                        command.Parameters.AddWithValue("@date_ex", expense_date.Value);
                        command.Parameters.AddWithValue("@date", DateTime.Today);

                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayExpenseData();
        }

        public void clearFields()
        {
            expense_category.SelectedIndex = -1;
            expense_item.Text="";
            expense_cost.Text="";
            expense_description.Text="";
            expense_date.Value = DateTime.Today;
        }

        private void expense_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updatebtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 ||
              string.IsNullOrEmpty(expense_item.Text) ||
              string.IsNullOrEmpty(expense_cost.Text) ||
              string.IsNullOrEmpty(expense_description.Text))
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID:" + getID + "?", "Configuration Message", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE expenses SET category=@cat, item=@item, cost=@cost, description=@desc, date_expense=@date_ex " +
                            " WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                            command.Parameters.AddWithValue("@item", expense_item.Text);
                            command.Parameters.AddWithValue("@cost", expense_cost.Text);
                            command.Parameters.AddWithValue("@desc", expense_description.Text);
                            command.Parameters.AddWithValue("@date_ex", expense_date.Value);
                            command.Parameters.AddWithValue("@date", DateTime.Today);
                            command.Parameters.AddWithValue("@id", getID);
                            
                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
            }
                displayExpenseData();
            
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_cost.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                expense_date.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
        }

        private void expense_deletebtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 ||
             string.IsNullOrEmpty(expense_item.Text) ||
             string.IsNullOrEmpty(expense_cost.Text) ||
             string.IsNullOrEmpty(expense_description.Text))
            {
                MessageBox.Show("Please select item Fist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID + "?", "Configuration Message", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM expenses WHERE id=@id";

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
            displayExpenseData();
        }
    }
}
