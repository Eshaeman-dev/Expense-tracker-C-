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
    public partial class Add_Category : UserControl
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";
        public Add_Category()
        {
            InitializeComponent();

            displayCategoryList();
        }
        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listdata = cData.categoryListData();

            dataGridView1.DataSource = listdata;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void category_addbtn_Click(object sender, EventArgs e)
        {
            if (category_caegory.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string insertData = "INSERT INTO categories (category, type, status, date_insert) VALUES (@cat, @type, @status, @date)";

                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", category_caegory.Text.Trim());
                        command.Parameters.AddWithValue("@type", category_type.SelectedItem);
                        command.Parameters.AddWithValue("@status", category_status.SelectedItem);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date", today);

                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("starting!");
            try {
                if (e.RowIndex >= 0) 
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                     getID = Convert.ToInt32(row.Cells[0].Value);
                    category_caegory.Text = row.Cells[1].Value.ToString();
                    MessageBox.Show(row.Cells[1].Value.ToString());

                    string typeValue = row.Cells[2].Value.ToString();
                    if (category_type.Items.Contains(typeValue))
                    {
                        category_type.SelectedItem = typeValue;
                    }

                    string statusValue = row.Cells[3].Value.ToString();
                    if (category_status.Items.Contains(statusValue))
                    {
                        category_status.SelectedItem = statusValue;
                    }
                }
                else
                {
                    MessageBox.Show("no row found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void category_updatebtn_Click(object sender, EventArgs e)
        {
            if (category_caegory.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are u sure you want to update ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();
                        string updateData = "UPDATE  categories SET category=@cat, type=@type, status=@status WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@id", getID);
                            command.Parameters.AddWithValue("@cat", category_caegory.Text.Trim());
                            command.Parameters.AddWithValue("@type", category_type.SelectedItem);
                            command.Parameters.AddWithValue("@status", category_status.SelectedItem);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }

            }
            displayCategoryList();
        }
        public void clearFields()
        {
            category_caegory.Text = "";
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;
        }
        private void category_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

    }
        }
    
