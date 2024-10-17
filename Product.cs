using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_INIZIO
{
    public partial class Product : Form
    {
        private int Key = 0;

        public Product()
        {
            InitializeComponent();
            DisplayProduct();
            // Bind the double-click event for ProductDGV
            ProductDGV.CellDoubleClick += new DataGridViewCellEventHandler(ProductDGV_CellDoubleClick);
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HCDC-\Documents\Cafe-Inizio-DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayProduct()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string Query = "Select * from ProductTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Clear()
        {
            PrNameTb.Text = "";
            PrCatCb.Text = "";
            PrQtyTb.Text = "";
            PrPriceTb.Text = "";
            Key = 0;
        }


        private void label1_Click(object sender, EventArgs e)
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

        private void PrNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrCatCb.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ProductTbl (PrName,PrCat,PrQty,PrPrice) values(@PN,@PC,@PQ,@PP)", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PrCatCb.Text);
                    cmd.Parameters.AddWithValue("@PQ", PrQtyTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added");
                    Con.Close();
                    DisplayProduct();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void ProductDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDGV.Rows[e.RowIndex];

                // Fill the TextBoxes and ComboBox with the selected row's data
                PrNameTb.Text = row.Cells["PrName"].Value.ToString();
                PrCatCb.Text = row.Cells["PrCat"].Value.ToString();
                PrQtyTb.Text = row.Cells["PrQty"].Value.ToString();
                PrPriceTb.Text = row.Cells["PrPrice"].Value.ToString();

                // Retrieve the product ID from the selected row
                if (row.Cells["PrID"].Value != DBNull.Value && int.TryParse(row.Cells["PrID"].Value.ToString(), out int prID))
                {
                    Key = prID; // Set the key (PrID) for future operations (edit/delete)
                }
                else
                {
                    Key = 0; // Reset key if invalid
                }
            }
        }


        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrCatCb.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET PrName = @PN, PrCat = @PC, PrQty = @PQ, PrPrice = @PP WHERE PrID = @EKey", Con);
                cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                cmd.Parameters.AddWithValue("@PC", PrCatCb.Text);
                cmd.Parameters.AddWithValue("@PQ", PrQtyTb.Text);
                cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                cmd.Parameters.AddWithValue("@EKey", Key);  // Use the class-level Key

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No record updated. Please check if the correct row is selected.");
                }

                DisplayProduct();
                Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HCDC-\Documents\Cafe-Inizio-DB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM ProductTbl WHERE PrID = @PrID", con))
                    {
                        cmd.Parameters.AddWithValue("@PrID", Key);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                            DisplayProduct();
                            Clear();
                            Key = 0;
                        }
                        else
                        {
                            MessageBox.Show("No product found with the selected ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}