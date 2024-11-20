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

namespace CAFE_INIZIO
{
    public partial class Form1 : Form
    {
        public static bool IsAdmin { get; set; }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Jacob Pedroso\OneDrive\Documents\CAFE-INIZIO.mdf;Integrated Security=True;Connect Timeout=30;";

        public Form1()
        {
            InitializeComponent();
            IsAdmin = false;
        }

        private void txtUSERNAME_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPASSWORD_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSUBMIT_Click(object sender, EventArgs e)
        {
            string username = txtUSERNAME.Text.Trim();
            string password = txtPASSWORD.Text.Trim();

            // Admin login
            if (username.ToLower() == "admin" && password.ToLower() == "admin")
            {
                IsAdmin = true;
                Main mainForm = new Main("Admin"); // Pass "Admin" as the logged-in employee name
                mainForm.Show();
                this.Hide();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpName = @EmpName AND EmpPass = @EmpPass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpName", username);
                        cmd.Parameters.AddWithValue("@EmpPass", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Fetch the employee name after successful login
                            string employeeName = "";
                            SqlCommand nameCmd = new SqlCommand("SELECT EmpName FROM EmployeeTbl WHERE EmpName = @EmpName AND EmpPass = @EmpPass", conn);
                            nameCmd.Parameters.AddWithValue("@EmpName", username);
                            nameCmd.Parameters.AddWithValue("@EmpPass", password);

                            var result = nameCmd.ExecuteScalar();
                            if (result != null)
                            {
                                employeeName = result.ToString();
                            }

                            // Open the Main form and pass the employee name
                            IsAdmin = false;
                            Main mainForm = new Main(employeeName);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
    
