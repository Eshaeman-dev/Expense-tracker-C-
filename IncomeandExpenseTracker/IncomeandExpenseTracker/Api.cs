using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mscc.GenerativeAI;
using System.Data.SqlClient;
using System.Reflection;
namespace IncomeandExpenseTracker
{
    public partial class Api : UserControl
    {
        private readonly string connectionString = @"Data Source=DESKTOP-OIUHF71\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True";
        private readonly string apiKey = "AIzaSyCDGZ83reHFikKhibGvJOlkOOTY_qjgaQ0";
        private GenerativeModel model;
        public Api()
        {
            InitializeComponent();
            var googleAI = new GoogleAI(apiKey);
            model = googleAI.GenerativeModel(Model.GeminiPro);
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }


        }

        private void Api_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string prompt = GeneratePromptFromDatabaseData();

            // Make request to Google Gemini API
            try
            {
                string response = await GenerateResponse(prompt);
                DisplayFormattedResponse(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async Task<string> GenerateResponse(string prompt)
        {
            try
            {
                var generationConfig = new GenerationConfig
                {
                    Temperature = (float?)0.8,
                    TopP = (float?)0.9
                };
                var request = new GenerateContentRequest(prompt, generationConfig);
                var response = await model.GenerateContent(request);
                return response.Text;
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating content from Google Gemini API.", ex);
            }
        }

        private string GeneratePromptFromDatabaseData()
        {
            var transactions = GetTransactionsFromDatabase();

            // Group transactions by weeks or months as needed
            var transactionsByMonth = transactions.GroupBy(t => new { t.Date.Year, t.Date.Month })
                                                   .Select(g => new
                                                   {
                                                       Month = $"{g.Key.Year}-{g.Key.Month}",
                                                       Income = g.Where(t => t.IsIncome).Sum(t => t.Amount),
                                                       Expenses = g.Where(t => !t.IsIncome).Sum(t => t.Amount),
                                                       Details = g.ToList()
                                                   }).ToList();

            var transactionsByWeek = transactions.GroupBy(t => new { t.Date.Year, Week = GetWeekOfYear(t.Date) })
                                                 .Select(g => new
                                                 {
                                                     Week = $"{g.Key.Year}-W{g.Key.Week}",
                                                     Income = g.Where(t => t.IsIncome).Sum(t => t.Amount),
                                                     Expenses = g.Where(t => !t.IsIncome).Sum(t => t.Amount),
                                                     Details = g.ToList()
                                                 }).ToList();

            StringBuilder promptBuilder = new StringBuilder();
            promptBuilder.AppendLine("Using the data provided, generate detailed suggestions for reducing expenses and increasing income for the user. The suggestions should be practical, actionable, and personalized based on the income and expense patterns observed in the weekly and monthly data. Ensure the response is well-formatted with clear headings and bullet points for easy readability. Consider the following aspects while generating suggestions: Income Enhancement, Expense Reduction, Budget Management and Long-term Financial Planning: ");

            foreach (var monthData in transactionsByMonth)
            {
                promptBuilder.AppendLine($"Month: {monthData.Month}");
                promptBuilder.AppendLine($"Total Income: ${monthData.Income}");
                promptBuilder.AppendLine($"Total Expenses: ${monthData.Expenses}");

                foreach (var transaction in monthData.Details)
                {
                    string transactionType = transaction.IsIncome ? "Income" : "Expense";
                    promptBuilder.AppendLine($"- {transactionType}: {transaction.Category}, Amount: ${transaction.Amount}, Date: {transaction.Date.ToShortDateString()}");
                }
            }

            foreach (var weekData in transactionsByWeek)
            {
                promptBuilder.AppendLine($"Week: {weekData.Week}");
                promptBuilder.AppendLine($"Total Income: ${weekData.Income}");
                promptBuilder.AppendLine($"Total Expenses: ${weekData.Expenses}");

                foreach (var transaction in weekData.Details)
                {
                    string transactionType = transaction.IsIncome ? "Income" : "Expense";
                    promptBuilder.AppendLine($"- {transactionType}: {transaction.Category}, Amount: ${transaction.Amount}, Date: {transaction.Date.ToShortDateString()}");
                }
            }

            promptBuilder.AppendLine("Please analyze the data and provide comprehensive suggestions for reducing expenses and increasing income for the user based on the provided weekly and monthly income and expense records");
            txtPrompt.Text = promptBuilder.ToString();

            return promptBuilder.ToString();
        }

        private List<Transaction> GetTransactionsFromDatabase()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get expenses
                using (SqlCommand cmd = new SqlCommand("SELECT category, item, cost, description, date_expense FROM expenses", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new Transaction
                        {
                            Category = reader["category"].ToString(),
                            Amount = Convert.ToDouble(reader["cost"]),
                            Date = Convert.ToDateTime(reader["date_expense"]),
                            IsIncome = false
                        });
                    }
                }

                // Get income
                using (SqlCommand cmd = new SqlCommand("SELECT category, item, income, description, date_income FROM income", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new Transaction
                        {
                            Category = reader["category"].ToString(),
                            Amount = Convert.ToDouble(reader["income"]),
                            Date = Convert.ToDateTime(reader["date_income"]),
                            IsIncome = true
                        });
                    }
                }
            }

            return transactions;
        }
        private static int GetWeekOfYear(DateTime date)
        {
            var dfi = System.Globalization.DateTimeFormatInfo.CurrentInfo;
            var calendar = dfi.Calendar;
            return calendar.GetWeekOfYear(date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }

private void DisplayFormattedResponse(string response)
        {
            txtResponse.Clear();

            // Split the response into lines
            string[] lines = response.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                if (line.StartsWith("**") && line.EndsWith("**"))
                {
                    // Format as heading
                    txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Bold);
                    txtResponse.AppendText(line.Trim('*') + Environment.NewLine);
                }
                else if (line.StartsWith("- "))
                {
                    // Format as bullet point
                    txtResponse.SelectionBullet = true;
                    txtResponse.AppendText(line + Environment.NewLine);
                    txtResponse.SelectionBullet = false;
                }
                else
                {
                    // Default formatting
                    txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Regular);
                    txtResponse.AppendText(line + Environment.NewLine);
                }
            }
        }

    }
    public class Transaction
    {
        public string Category { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncome { get; set; }
    }
}
