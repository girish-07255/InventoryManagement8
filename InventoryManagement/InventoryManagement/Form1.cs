using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        // SQL Server Connection
        private string connectionString =
            @"Server=localhost;Database=InventoryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            // Connect buttons to their event handlers
            btnAdd1.Click += btnAdd_Click;
            btnView1.Click += btnView_Click;
            btnUpdate1.Click += btnUpdate_Click;
            btnDelete1.Click += btnDelete_Click;
            btnClear1.Click += btnClear_Click;

            // Connect DataGridView event
            dataGridView2.CellClick += dataGridView1_CellClick;
        }

        // FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // VALIDATE INPUT
        private bool ValidateInput(bool checkID = false)
        {
            if (checkID)
            {
                if (!int.TryParse(txtID1.Text, out int id) || id <= 0)
                {
                    MessageBox.Show("Enter a valid Product ID.");
                    txtID1.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtName1.Text))
            {
                MessageBox.Show("Enter Product Name.");
                txtName1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCategory1.Text))
            {
                MessageBox.Show("Enter Category.");
                txtCategory1.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity1.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Enter a valid Quantity.");
                txtQuantity1.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice1.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Enter a valid Price.");
                txtPrice1.Focus();
                return false;
            }

            return true;
        }

        // ADD PRODUCT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Products
                                    (ProductName, Category, Quantity, Price)
                                    VALUES (@Name, @Category, @Quantity, @Price)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = txtName1.Text;
                        cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = txtCategory1.Text;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = int.Parse(txtQuantity1.Text);

                        SqlParameter priceParameter =
                            cmd.Parameters.Add("@Price", SqlDbType.Decimal);

                        priceParameter.Precision = 10;
                        priceParameter.Scale = 2;
                        priceParameter.Value = decimal.Parse(txtPrice1.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product Added Successfully!");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Product: " + ex.Message);
            }
        }

        // VIEW PRODUCTS
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // LOAD PRODUCTS
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Products";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Products: " + ex.Message);
            }
        }

        // UPDATE PRODUCT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true))
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Products SET
                                    ProductName = @Name,
                                    Category = @Category,
                                    Quantity = @Quantity,
                                    Price = @Price
                                    WHERE ProductID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = txtName1.Text;
                        cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = txtCategory1.Text;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = int.Parse(txtQuantity1.Text);

                        SqlParameter priceParameter =
                            cmd.Parameters.Add("@Price", SqlDbType.Decimal);

                        priceParameter.Precision = 10;
                        priceParameter.Scale = 2;
                        priceParameter.Value = decimal.Parse(txtPrice1.Text);

                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID1.Text);

                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        MessageBox.Show(result > 0
                            ? "Product Updated Successfully!"
                            : "Product Not Found!");
                    }
                }

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Product: " + ex.Message);
            }
        }

        // DELETE PRODUCT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID1.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Enter a valid Product ID.");
                txtID1.Focus();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Products WHERE ProductID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        MessageBox.Show(result > 0
                            ? "Product Deleted Successfully!"
                            : "Product Not Found!");
                    }
                }

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting Product: " + ex.Message);
            }
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // CLEAR ALL FIELDS
        private void ClearFields()
        {
            txtID1.Clear();
            txtName1.Clear();
            txtCategory1.Clear();
            txtQuantity1.Clear();
            txtPrice1.Clear();

            txtName1.Focus();
        }

        // SELECT PRODUCT FROM DATAGRIDVIEW
        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtID1.Text = Convert.ToString(row.Cells["ProductID"].Value);
            txtName1.Text = Convert.ToString(row.Cells["ProductName"].Value);
            txtCategory1.Text = Convert.ToString(row.Cells["Category"].Value);
            txtQuantity1.Text = Convert.ToString(row.Cells["Quantity"].Value);
            txtPrice1.Text = Convert.ToString(row.Cells["Price"].Value);
        }
    }
}
