using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace demoCRUD
{
    
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            //Kết nối lên db
            string connect = "server = localhost; user id = root; password = ; database =  d03k13csharp";
            MySqlConnection connection = new MySqlConnection(connect);
            //SQL
            string sql = "SELECT products.id, products.product_name, products.price, products.quantity, categories.name AS category_name FROM products INNER JOIN categories ON products.category_id = categories.id";
            //Tạo adapter để chạy sql
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connect);
            //Tạo datatable
            DataTable dataTable = new DataTable();
            //Đổ dữ liệu từ adapter vào datatable
            adapter.Fill(dataTable);
            //Đổ datatable vào DataGridView
            dgvProductList.DataSource = dataTable;
            
            //Lấy category để đổ comboBox
            
            //sql lấy category
            string SqlCategory = "SELECT * FROM categories";
            //tạo adapter
            MySqlDataAdapter categoryAdapter = new MySqlDataAdapter(SqlCategory, connection);
            //Tạo dataTable
            DataTable categoryDataTable = new DataTable();
            //Đổ dữ liệu từ adapter vào dataTable
            categoryAdapter.Fill(categoryDataTable);
            //Đổ dataTable vào comboBox
            cbCategoryName.DataSource = categoryDataTable;
            cbCategoryName.ValueMember = "id";
            cbCategoryName.DisplayMember = "name";
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            tbProductName.Enabled = true;
            tbProductPrice.Enabled = true;
            tbProductQuantity.Enabled = true;
            cbCategoryName.Enabled = true;
            btnSaveProduct.Enabled = true;
            btnAddNewProduct.Enabled = false;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ form về
            string proName = tbProductName.Text;
            string proQuantity = tbProductQuantity.Text;
            string proPrice = tbProductPrice.Text;
            string catName = cbCategoryName.SelectedValue.ToString();
            //Kết nối lên db
            string connect = "server = localhost; user id = root; password = ; database =  d03k13csharp";
            MySqlConnection connection = new MySqlConnection(connect);
            //SQL
            string sql = "INSERT INTO products(product_name, price, quantity, category_id) VALUES ('" + proName +
                         "', '" + proPrice + "', '" + proQuantity + "', '" + catName + "')";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Mở kết nối
            connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kêt nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Thêm thành công");
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            cbCategoryName.Enabled = false;
            btnSaveProduct.Enabled = false;
            btnAddNewProduct.Enabled = true;
            //Load lại list
            ProductList_Load(null, null);
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dữ liệu từ DataGridView
            string ProId = dgvProductList.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string ProName = dgvProductList.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
            string ProPrice = dgvProductList.Rows[e.RowIndex].Cells["price"].Value.ToString();
            string ProQuantity = dgvProductList.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            string ProCat = dgvProductList.Rows[e.RowIndex].Cells["category_name"].Value.ToString();
            //Đổ dữ liệu vào form
            tbProductId.Text = ProId;
            tbProductName.Text = ProName;
            tbProductPrice.Text = ProPrice;
            tbProductQuantity.Text = ProQuantity;
            cbCategoryName.SelectedIndex = cbCategoryName.FindString(ProCat);
            //
            tbProductName.Enabled = true;
            tbProductPrice.Enabled = true;
            tbProductQuantity.Enabled = true;
            cbCategoryName.Enabled = true;
            btnUpdateProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnAddNewProduct.Enabled = false;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu trong form
            string ProId = tbProductId.Text;
            string ProName = tbProductName.Text;
            string ProPrice = tbProductPrice.Text;
            string ProQuantity = tbProductQuantity.Text;
            string ProCat = cbCategoryName.SelectedValue.ToString();
            //Kết nối lên db
            string connect = "server = localhost; user id = root; password = ; database =  d03k13csharp";
            MySqlConnection connection = new MySqlConnection(connect);
            //SQL
            string sql =
                "UPDATE products SET product_name = '" + ProName + "', price = '" + ProPrice + "', quantity = '" + ProQuantity + "', category_id = '" + ProCat + "' WHERE id = '" + ProId + "'";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Mở kết nối
            connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Sửa thành công");
            //Load lại list
            ProductList_Load(null, null);
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            cbCategoryName.Enabled = false;
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddNewProduct.Enabled = true;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Lấy id cần delete
            string ProId = tbProductId.Text;
            //Kết nối lên db
            string connect = "server = localhost; user id = root; password = ; database =  d03k13csharp";
            MySqlConnection connection = new MySqlConnection(connect);
            //SQL
            string sql = "DELETE FROM products WHERE id = '" + ProId + "'";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Mở kết nối
            connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Xóa thành công");
            //Load lại list
            ProductList_Load(null, null);
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            cbCategoryName.Enabled = false;
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddNewProduct.Enabled = true;
        }

        private void btnResetPro_Click(object sender, EventArgs e)
        {
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            cbCategoryName.Enabled = false;
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddNewProduct.Enabled = true;
            btnSaveProduct.Enabled = false;
        }
    }
}