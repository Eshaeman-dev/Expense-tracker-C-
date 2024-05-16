using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeandExpenseTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Close", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard db= new Dashboard();
            db.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Category add_Category = new Add_Category();
            add_Category.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to logout","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 logoutfrom= new Form1();
                logoutfrom.Show();
                this.Hide() ;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
