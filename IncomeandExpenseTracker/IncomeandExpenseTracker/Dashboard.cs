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
    public partial class DashBoard : UserControl
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public DashBoard()
        {
            InitializeComponent();
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();

            expensesTodayIncome();
            expensesYesterdayIncome();
            expensesThisMonth();
            expenseThisYear();

            incometotalIncome();
            expensetotalExpense();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();

            expensesTodayIncome();
            expensesYesterdayIncome();
            expensesThisMonth();
            expenseThisYear();

            incometotalIncome();
            expensetotalExpense();

        }
        //INCOME SUM

        public void incomeTodayIncome()
        {

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income=@date_in";

                using(SqlCommand command=new SqlCommand(query,connect))
                {
                    DateTime today= DateTime.Today;
                    command.Parameters.AddWithValue("@date_in",today);

                    object result=command.ExecuteScalar();
                    if(result != DBNull.Value ) {
                    decimal todayCost= Convert.ToDecimal(result);
                     income_todayincome.Text=todayCost.ToString("C");
                    }
                    else
                    {
                        income_todayincome.Text = "$ 0.00" ;
                    }
                }
            }
        }
        public void incomeYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                // Correct the SQL query syntax
                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = CONVERT(DATE, DATEADD(day, -1, GETDATE()))";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        income_yesterdayincome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayincome.Text = "$0.00";
                    }
                }
            }

        }
    
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <=@endMonth";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startMonth", startMonth);
                    command.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        income_thisMonthincome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thisMonthincome.Text = "$0.00";
                    }
                }
            } 
        }
        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today= DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear =startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startYear", startYear);
                    command.Parameters.AddWithValue("@endYear", endYear);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        income_thisYearincome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisYearincome.Text = "$0.00";
                    }
                }
            }

        }

        public void incometotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) from income";

                using (SqlCommand command = new SqlCommand(query, connect))
                {

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalIncome.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        totalIncome.Text = "$ 0.00";
                    }
                }
            }
        }

        //EXPENSES
        public void expensesTodayIncome()
        {

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense=@date_ex";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    command.Parameters.AddWithValue("@date_ex", today);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        expense_today.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        expense_today.Text = "$ 0.00";
                    }
                }
            }
        }
        public void expensesYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                // Correct the SQL query syntax
                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = CONVERT(DATE, DATEADD(day, -1, GETDATE()))";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                       expense_yesterday.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expense_yesterday.Text = "$0.00";
                    }
                }
            }

        }
        public void expensesThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <=@endMonth";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startMonth", startMonth);
                    command.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        expense_thisMonth.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expense_thisMonth.Text = "$0.00";
                    }
                }
            }
        }
        public void expenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startYear", startYear);
                    command.Parameters.AddWithValue("@endYear", endYear);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expense_thisYear.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expense_thisYear.Text = "$0.00";
                    }
                }
            }

        }
        public void expensetotalExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) from expenses";

                using (SqlCommand command = new SqlCommand(query, connect))
                {

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                      totalExpense.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        totalExpense.Text = "$ 0.00";
                    }
                }
            }
        }

    }
}
