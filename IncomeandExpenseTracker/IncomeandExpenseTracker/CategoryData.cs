using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeandExpenseTracker
{
    internal class CategoryData
    {
        string stringConnection = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";
        public int ID {  get; set; }    
        public string Category {  get; set; }
        public string Type { get; set; }
        public string Status {  get; set; }
        public string Date { get; set; }

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listdata= new List<CategoryData>();

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";
                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                  SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status= reader["status"].ToString();
                        cData.Date =((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                      
                        listdata.Add(cData);
                    }
                }
            }
            return listdata;
        }

    }
}
