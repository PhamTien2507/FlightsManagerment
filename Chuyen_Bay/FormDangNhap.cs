using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuyen_Bay
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button_DangNhap_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string tenDangNhap = text_TenDangNhap.Text;
            string matKhau = text_MatKhau.Text;

            // Kiểm tra thông tin đăng nhập 
            if (tenDangNhap == "phamtien" && matKhau == "123")
            {
                // Đăng nhập thành công, mở form chính và đóng form đăng nhập
                FormChuongTrinh mainForm = new FormChuongTrinh();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại, hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            Application.Exit();
        }
    }
}
