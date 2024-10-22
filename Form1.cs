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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Jacob Pedroso\OneDrive\Documents\CAFE-INIZIO.mdf;Integrated Security=True;Connect Timeout=30";

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
            string username = txtUSERNAME.Text;
            string password = txtPASSWORD.Text;

            // Admin login
            if (username.ToLower() == "admin" && password.ToLower() == "admin")
            {
                IsAdmin = true;
                Main mainForm = new Main();
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

                            // Fetch employee name
                            SqlCommand nameCmd = new SqlCommand("SELECT EmpName FROM EmployeeTbl WHERE EmpName=@User AND EmpPass=@Pass", conn);
                            nameCmd.Parameters.AddWithValue("@User", username);
                            nameCmd.Parameters.AddWithValue("@Pass", password);

                            var result = nameCmd.ExecuteScalar();
                            if (result != null)
                            {
                                employeeName = result.ToString();
                            }

                            // Pass the employee name to the Main form
                            IsAdmin = false;
                            Main mainForm = new Main(employeeName); // Pass employee name to Main form
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
