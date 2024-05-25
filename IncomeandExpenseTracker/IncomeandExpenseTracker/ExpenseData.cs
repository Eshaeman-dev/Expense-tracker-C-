using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IncomeandExpenseTracker
{
    internal class ExpenseData
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public int Id { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateExpense { get; set; }

        public List<ExpenseData> expenseListData()
        {
            List<ExpenseData> listData = new List<ExpenseData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM expenses";

                using (SqlCommand command = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpenseData eData = new ExpenseData
                        {
                            Id = (int)reader["id"],
                            Category = reader["category"].ToString(),
                            Item = reader["item"].ToString(),
                            Cost = reader["cost"].ToString(),
                            Description = reader["description"].ToString(),
                            DateExpense = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy")
                        };

                        listData.Add(eData);
                    }
                }
            }
            return listData;
        }
    }
}
