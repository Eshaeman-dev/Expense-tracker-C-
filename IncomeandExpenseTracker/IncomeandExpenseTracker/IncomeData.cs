using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeandExpenseTracker
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";
               public int id{  get; set; }
        public string Category { get; set; }
        public string Item { get; set; }

        public string Cost { get; set; }

        public string Desription { get; set; }
        public string DateIncome { get; set; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData= new List<IncomeData>();

            using(SqlConnection connect= new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM income";

                using (SqlCommand command = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.id = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Desription = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);
                    }
                }
            }
            return listData;
        }


    }
}
