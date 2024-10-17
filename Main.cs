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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void btnEMPLOYEE_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btnCOSTUMER_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer();
            costumer.Show();
            this.Hide();
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            try
            {
                using (Order order = new Order())
                {
                    this.Hide();
                    order.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Order form: " + ex.Message);
            }
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
