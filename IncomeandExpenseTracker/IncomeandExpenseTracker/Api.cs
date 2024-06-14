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
    public partial class Api : UserControl
    {
        public Api()
        {
            InitializeComponent();
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
    }
}
