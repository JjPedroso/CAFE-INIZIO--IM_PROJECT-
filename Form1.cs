using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_INIZIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSUBMIT_Click(object sender, EventArgs e)
        {
 
            string username = txtUSERNAME.Text;
            string password = txtPASSWORD.Text;


            if (username == "admin" && password == "admin")
            {
 
                Main mainForm = new Main(); 
                mainForm.Show();
                this.Hide(); 
            }
            else
            {
              
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
