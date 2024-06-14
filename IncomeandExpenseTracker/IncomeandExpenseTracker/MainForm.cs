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
            displayUsername();
            Api apiControl = new Api();
            apiControl.Dock = DockStyle.Fill; 
            this.Controls.Add(apiControl);
        }

        public void displayUsername()
        {
            string getUsername=Form1.username;
            greetuser.Text= "Welcome, "+getUsername.Substring(0,1).ToUpper()+getUsername.Substring(1);
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
            dashBoard2.Visible = true;
            add_Category2.Visible = false;
            income2.Visible = false;
            expense2.Visible = false;
            api1.Visible=false;

            DashBoard dForm= dashBoard2 as DashBoard;

            if(dForm != null)
            {
                dForm.refreshData();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashBoard2.Visible = false;
            add_Category2.Visible = true;
            income2.Visible = false;
            expense2.Visible = false;
            api1.Visible = false;

            Add_Category cform= add_Category2 as Add_Category;

            if(cform != null)
            {
                cform.refreshData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashBoard2.Visible = false;
            add_Category2.Visible = false;
            income2.Visible = true;
            expense2.Visible = false;
            api1.Visible = false;

            Income iForm= income2 as Income;
            if(iForm != null)
            {
                iForm.refreshData();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashBoard2.Visible = false;
            add_Category2.Visible = false;
            income2.Visible = false;
            expense2.Visible = true;
            api1.Visible = false;

            Expense eForm= expense2 as Expense;
            if(eForm != null)
            {
                eForm.refreshData();
            }
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

        private void add_Category1_Load(object sender, EventArgs e)
        {

        }

        private void income1_Load(object sender, EventArgs e)
        {

        }

        private void add_Category1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void dashBoard1_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click_2(object sender, EventArgs e)
        {
            dashBoard2.Visible = false;
            add_Category2.Visible = false;
            income2.Visible = false;
            expense2.Visible = false;
            api1.Visible = true;

            Api eForm = api1 as Api;
            if (eForm != null)
            {
                eForm.refreshData();
            }
        }
    }
}
