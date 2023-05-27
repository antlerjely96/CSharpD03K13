using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace demoCRUD
{
    public partial class CategoryList : Form
    {
        //chuỗi để config kết nối
        private static string ConnectionString =
            "server = localhost; user id = root; password = ; database = d03k13csharp";
        //Tạo kết nối
        private MySqlConnection Connection = new MySqlConnection(ConnectionString);
        //Biến sql
        private string sql;
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            //Query
            sql = "SELECT * FROM categories";
            //Tạo đối tượng MySqlDataAdapter để chạy query và lấy dữ liệu
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Connection);
            //Tạo đối tượng DataTable để chứa dữ liệu lấy ược từ adapter
            DataTable dataTable = new DataTable();
            //Lưu dữ liệu từ adapter vào dataTable
            adapter.Fill(dataTable);
            //Lưu dataTable vào DataGridView
            dgvCategoryList.DataSource = dataTable;
        }

        private void btnAddNewCat_Click(object sender, EventArgs e)
        {
            //Cho phép tương tác với nút Save và ô input nhập tên
            btnSaveCat.Enabled = true;
            tbCatName.Enabled = true;
            //Không cho tương tác với nút Add new
            btnAddNewCat.Enabled = false;
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu ở ô input nhập tên
            string CatName = tbCatName.Text;
            //Viết query
            sql = "INSERT INTO categories(name) VALUES ('" + CatName + "')";
            //Tạo command bằng đối tượng MySqlCommand để chạy query
            MySqlCommand command = new MySqlCommand(sql, Connection);
            //Mở kết nối
            Connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            Connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Thêm thành công");
            //Load lại DâataGridView
            CategoryList_Load(null, null);
            //Không cho tương tác với nút Save và ô input nhập tên
            btnSaveCat.Enabled = false;
            tbCatName.Enabled = false;
            //Cho tương tác với nút Add new
            btnAddNewCat.Enabled = true;
        }

        private void dgvCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dữ liệu ở hàng đang được chọn
            string CatId = dgvCategoryList.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string CatName = dgvCategoryList.Rows[e.RowIndex].Cells["name"].Value.ToString();
            
            //enable các ô input và btnUpdate
            tbCatName.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNewCat.Enabled = false;
            
            //Đổ dữ liệu vào input
            tbCatId.Text = CatId;
            tbCatName.Text = CatName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu trong ô input
            string CatId = tbCatId.Text;
            string CatName = tbCatName.Text;
            //Query
            sql = "UPDATE categories SET name = '" + CatName + "' WHERE id = '" + CatId + "'";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, Connection);
            //Mở kết nối
            Connection.Open();
            //chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            Connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Sửa thành công");
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            tbCatName.Enabled = false;
            btnAddNewCat.Enabled = true;
            //Load lại danh sách
            CategoryList_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Lấy id bản ghi cần xóa
            string CatId = tbCatId.Text;
            //Query
            sql = "DELETE FROM categories WHERE id = '" + CatId + "'";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, Connection);
            //Mở kết nối
            Connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            Connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Xóa thành công");
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            tbCatName.Enabled = false;
            btnAddNewCat.Enabled = true;
            //Load lại danh sách
            CategoryList_Load(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbCatName.Enabled = false;
            btnSaveCat.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddNewCat.Enabled = true;

            tbCatId.Text = "";
            tbCatName.Text = "";
        }
    }
}