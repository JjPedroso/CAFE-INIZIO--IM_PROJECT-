﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CAFE_INIZIO
{
    public partial class Order : Form
    {
        private int stock;
        private int productId;
        private int GrdTotal = 0;
        private int selectedCustomerId;
        private string selectedCustomerName;

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HCDC-\Documents\Cafe-Inizio-DB.mdf;Integrated Security=True;Connect Timeout=30";

        public Order()
        {
            InitializeComponent();
            SetupDataGridViews();
            GetCustomers();
            DisplayProduct();
            DisplayTransactions();
        }

        private void SetupDataGridViews()
        {
            // Setup BillDGV
            billDGV.Columns.Add("Id", "ID");
            billDGV.Columns.Add("ProductName", "Product Name");
            billDGV.Columns.Add("Quantity", "Quantity");
            billDGV.Columns.Add("Price", "Price");
            billDGV.Columns.Add("Total", "Total");

            // Setup ProductsDGV
            if (ProductsDGV != null)
            {
                ProductsDGV.CellDoubleClick += ProductDGV_CellDoubleClick;
            }
            else
            {
                MessageBox.Show("Product DataGridView not found. Please check your form design.");
            }

            // Setup BillDGV event handler
            billDGV.CellContentClick += new DataGridViewCellEventHandler(billDGV_CellContentClick);
        }

        private void GetCustomers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CustID, CustName FROM CustomerTbl";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    CustIDCb.DataSource = dt;
                    CustIDCb.ValueMember = "CustID";
                    CustIDCb.DisplayMember = "CustID";

                    CustIDCb.SelectedIndexChanged += CustIDCb_SelectedIndexChanged;

                    if (CustIDCb.Items.Count > 0)
                    {
                        CustIDCb.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void CustIDCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustIDCb.SelectedValue != null)
            {
                selectedCustomerId = Convert.ToInt32(CustIDCb.SelectedValue);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT CustName FROM CustomerTbl WHERE CustID = @CustID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CustID", selectedCustomerId);

                        selectedCustomerName = command.ExecuteScalar() as string ?? string.Empty;
                        CustNameTb.Text = selectedCustomerName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching customer name: " + ex.Message);
                    }
                }
            }
        }

        private void DisplayProduct()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PrId, PrName, PrCat, PrQty, PrPrice FROM ProductTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    ProductsDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void DisplayTransactions()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT BNum, BDate, CustId, CustName, EmpNme, Amt FROM BillTbl"; // Ensure these fields exist in your database
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    TransactionsDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }


        private void ProductDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductsDGV.Rows[e.RowIndex];
                productId = Convert.ToInt32(row.Cells["PrId"].Value);
                PrNameTb.Text = row.Cells["PrName"].Value.ToString();
                PrPriceTb.Text = row.Cells["PrPrice"].Value.ToString();
                stock = Convert.ToInt32(row.Cells["PrQty"].Value);
                PrQtyTb.Text = "1";
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrQtyTb.Text) || !int.TryParse(PrQtyTb.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (quantity > stock)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            if (productId == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int price = Convert.ToInt32(PrPriceTb.Text);
            int total = quantity * price;

            billDGV.Rows.Add(new object[]
            {
                billDGV.Rows.Count + 1,
                PrNameTb.Text,
                quantity,
                price,
                total
            });

            GrdTotal += total;
            TotalLbl.Text = $"PHP {GrdTotal}";

            UpdateStock(productId, quantity);
            ResetProductInputs();
            DisplayProduct(); // Refresh the product list
        }

        private void UpdateStock(int productId, int quantitySold)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE ProductTbl SET PrQty = PrQty - @QuantitySold WHERE PrId = @ProductId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock: {ex.Message}");
            }
        }

        private void ResetProductInputs()
        {
            PrNameTb.Text = string.Empty;
            PrQtyTb.Text = string.Empty;
            PrPriceTb.Text = string.Empty;
            productId = 0;
        }

        private string GetOrderDetails()
        {
            string orderDetails = $"Customer: {selectedCustomerId} - {selectedCustomerName}\n\n";
            orderDetails += "Products:\n";

            foreach (DataGridViewRow row in billDGV.Rows)
            {
                if (!row.IsNewRow)
                {
                    string productName = row.Cells[1].Value?.ToString() ?? "";
                    string quantity = row.Cells[2].Value?.ToString() ?? "";
                    string price = row.Cells[3].Value?.ToString() ?? "";
                    string total = row.Cells[4].Value?.ToString() ?? "";

                    orderDetails += $"{productName} x{quantity} @ {price} = {total}\n";
                }
            }

            orderDetails += $"\nTotal: PHP {GrdTotal}";
            return orderDetails;
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            if (billDGV.Rows.Count == 0 || selectedCustomerId == 0)
            {
                MessageBox.Show("Please add products to the bill and select a customer before finalizing the order.");
                return;
            }

            string orderSummary = GetOrderDetails();
            MessageBox.Show(orderSummary, "Order Summary");
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            ResetProductInputs();
        }

        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }

        private void InsertBill()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    int newBNum = GetNextBillNumber(Con);
                    SqlCommand cmd = new SqlCommand("INSERT INTO BillTbl (BNum, BDate, CustId, CustName, EmpNme, Amt) VALUES (@BN, @BD, @CI, @CN, @EN, @Am)", Con);
                    cmd.Parameters.AddWithValue("@BN", newBNum);
                    cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@CI", selectedCustomerId); // Use the selected customer ID
                    cmd.Parameters.AddWithValue("@CN", selectedCustomerName); // Use the customer name
                    cmd.Parameters.AddWithValue("@EN", "DefaultEmployeeName"); // Replace with actual employee name
                    cmd.Parameters.AddWithValue("@Am", GrdTotal); // Use the current GrdTotal

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved");
                }
                DisplayTransactions(); // Refresh the transaction display
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private int GetNextBillNumber(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(BNum), 0) + 1 FROM BillTbl", connection);
            return (int)cmd.ExecuteScalar();
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            InsertBill();
        }

        private void TransactionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle TransactionsDGV cell content click if needed
        }
 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CAFE INIZIO", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            e.Graphics.DrawString("TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(220, 40));

            int pos = 60;
            foreach (DataGridViewRow row in billDGV.Rows)
            {
                if (!row.IsNewRow)
                {
                    int PrId = Convert.ToInt32(row.Cells["Id"].Value);
                    string PrName = row.Cells["ProductName"].Value.ToString();
                    int PrQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal PrPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                    e.Graphics.DrawString($"{PrId}", new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(26, pos));
                    e.Graphics.DrawString($"{PrName}", new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(45, pos));
                    e.Graphics.DrawString("PRICE", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(45, pos + 15));
                    e.Graphics.DrawString("QUANTITY", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(150, pos + 15));
                    e.Graphics.DrawString($"{PrPrice:N2}", new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(45, pos + 30));
                    e.Graphics.DrawString($"{PrQty}", new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(150, pos + 30));
                    e.Graphics.DrawString($"₱ {total:N2}", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(220, pos + 30));
                    pos += 50;
                }
            }

            e.Graphics.DrawString("Grand Total:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(26, pos + 10));
            e.Graphics.DrawString($"PHP {GrdTotal:N2}", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(120, pos + 10));

            e.Graphics.DrawString("***THANK YOU FOR VISITING CAFE INIZIO***", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos + 30));

            billDGV.Rows.Clear();
            billDGV.Refresh();
            GrdTotal = 0;
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
            Order order = new Order();
            order.Show();
            this.Hide();
        }
    }
}