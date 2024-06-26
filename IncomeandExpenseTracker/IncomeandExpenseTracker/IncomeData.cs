﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IncomeandExpenseTracker
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";

        public int Id { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM income";

                using (SqlCommand command = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData
                        {
                            Id = (int)reader["id"],
                            Category = reader["category"].ToString(),
                            Item = reader["item"].ToString(),
                            Cost = reader["income"].ToString(),
                            Description = reader["description"].ToString(),
                            DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy")
                        };

                        listData.Add(iData);
                    }
                }
            }
            return listData;
        }
    }
}
