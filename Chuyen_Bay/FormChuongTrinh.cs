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
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private Button button_Them;
        private Button button_Sua;
        private Button button_Xoa;
        private Button button_NhapLai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox text_MaChuyenBay;
        private TextBox text_ThoiGianBay;
        private TextBox text_SLgheHang2;
        private TextBox text_SLgheHang1;
        private ComboBox combo_SanBayDi;
        private ComboBox combo_SanBayDen;
        private DateTimePicker dateTimePicker_Ngay;

        private void InitializeComponent()
        {
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_NhapLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_MaChuyenBay = new System.Windows.Forms.TextBox();
            this.text_ThoiGianBay = new System.Windows.Forms.TextBox();
            this.text_SLgheHang2 = new System.Windows.Forms.TextBox();
            this.text_SLgheHang1 = new System.Windows.Forms.TextBox();
            this.combo_SanBayDi = new System.Windows.Forms.ComboBox();
            this.combo_SanBayDen = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_ThongTin = new System.Windows.Forms.DataGridView();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLgheHang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLgheHang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(519, 115);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(97, 34);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);

            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(519, 170);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(97, 34);
            this.button_Sua.TabIndex = 1;
            this.button_Sua.Text = "SỬA";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(519, 228);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(97, 34);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "XÓA";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_NhapLai
            // 
            this.button_NhapLai.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhapLai.Location = new System.Drawing.Point(519, 287);
            this.button_NhapLai.Name = "button_NhapLai";
            this.button_NhapLai.Size = new System.Drawing.Size(97, 34);
            this.button_NhapLai.TabIndex = 3;
            this.button_NhapLai.Text = "NHẬP LẠI";
            this.button_NhapLai.UseVisualStyleBackColor = true;
            this.button_NhapLai.Click += new System.EventHandler(this.button_NhapLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sân bay đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sân bay đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thời gian bay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng ghế hàng 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng ghế hàng 2";
            // 
            // text_MaChuyenBay
            // 
            this.text_MaChuyenBay.Location = new System.Drawing.Point(163, 96);
            this.text_MaChuyenBay.Name = "text_MaChuyenBay";
            this.text_MaChuyenBay.Size = new System.Drawing.Size(213, 20);
            this.text_MaChuyenBay.TabIndex = 11;
            // 
            // text_ThoiGianBay
            // 
            this.text_ThoiGianBay.Location = new System.Drawing.Point(163, 255);
            this.text_ThoiGianBay.Name = "text_ThoiGianBay";
            this.text_ThoiGianBay.Size = new System.Drawing.Size(213, 20);
            this.text_ThoiGianBay.TabIndex = 12;
            // 
            // text_SLgheHang2
            // 
            this.text_SLgheHang2.Location = new System.Drawing.Point(163, 337);
            this.text_SLgheHang2.Name = "text_SLgheHang2";
            this.text_SLgheHang2.Size = new System.Drawing.Size(213, 20);
            this.text_SLgheHang2.TabIndex = 13;
            // 
            // text_SLgheHang1
            // 
            this.text_SLgheHang1.Location = new System.Drawing.Point(163, 295);
            this.text_SLgheHang1.Name = "text_SLgheHang1";
            this.text_SLgheHang1.Size = new System.Drawing.Size(213, 20);
            this.text_SLgheHang1.TabIndex = 14;
            // 
            // combo_SanBayDi
            // 
            this.combo_SanBayDi.FormattingEnabled = true;
            this.combo_SanBayDi.Location = new System.Drawing.Point(163, 132);
            this.combo_SanBayDi.Name = "combo_SanBayDi";
            this.combo_SanBayDi.Size = new System.Drawing.Size(213, 21);
            this.combo_SanBayDi.TabIndex = 15;
            this.combo_SanBayDi.DropDown += new System.EventHandler(this.combo_SanBayDi_DropDown);
            this.combo_SanBayDi.SelectedIndexChanged += new System.EventHandler(this.combo_SanBayDi_SelectedIndexChanged);
            // 
            // combo_SanBayDen
            // 
            this.combo_SanBayDen.FormattingEnabled = true;
            this.combo_SanBayDen.Location = new System.Drawing.Point(163, 174);
            this.combo_SanBayDen.Name = "combo_SanBayDen";
            this.combo_SanBayDen.Size = new System.Drawing.Size(213, 21);
            this.combo_SanBayDen.TabIndex = 16;
            this.combo_SanBayDen.DropDown += new System.EventHandler(this.combo_SanBayDen_DropDown);
            this.combo_SanBayDen.SelectedIndexChanged += new System.EventHandler(this.combo_SanBayDen_SelectedIndexChanged);
            // 
            // dateTimePicker_Ngay
            // 
            this.dateTimePicker_Ngay.Location = new System.Drawing.Point(163, 213);
            this.dateTimePicker_Ngay.Name = "dateTimePicker_Ngay";
            this.dateTimePicker_Ngay.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker_Ngay.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(327, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // dataGridView_ThongTin
            // 
            this.dataGridView_ThongTin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenBay,
            this.SanBayDi,
            this.SanBayDen,
            this.Ngay,
            this.ThoiGianBay,
            this.SLgheHang1,
            this.SLgheHang2});
            this.dataGridView_ThongTin.Location = new System.Drawing.Point(1, 363);
            this.dataGridView_ThongTin.Name = "dataGridView_ThongTin";
            this.dataGridView_ThongTin.Size = new System.Drawing.Size(739, 106);
            this.dataGridView_ThongTin.TabIndex = 19;
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.HeaderText = "Mã Chuyến Bay";
            this.MaChuyenBay.Name = "MaChuyenBay";
            // 
            // SanBayDi
            // 
            this.SanBayDi.HeaderText = "Sân Bay Đi";
            this.SanBayDi.Name = "SanBayDi";
            // 
            // SanBayDen
            // 
            this.SanBayDen.HeaderText = "Sân Bay Đến";
            this.SanBayDen.Name = "SanBayDen";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ThoiGianBay.Name = "ThoiGianBay";
            // 
            // SLgheHang1
            // 
            this.SLgheHang1.HeaderText = "Số Lượng Ghế Hàng 1";
            this.SLgheHang1.Name = "SLgheHang1";
            // 
            // SLgheHang2
            // 
            this.SLgheHang2.HeaderText = "Số Lượng Ghế Hàng 2";
            this.SLgheHang2.Name = "SLgheHang2";
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 475);
            this.Controls.Add(this.dataGridView_ThongTin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker_Ngay);
            this.Controls.Add(this.combo_SanBayDen);
            this.Controls.Add(this.combo_SanBayDi);
            this.Controls.Add(this.text_SLgheHang1);
            this.Controls.Add(this.text_SLgheHang2);
            this.Controls.Add(this.text_ThoiGianBay);
            this.Controls.Add(this.text_MaChuyenBay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_NhapLai);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Name = "FormChuongTrinh";
            this.Text = "Quản lý chuyến bay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu tất cả các điều khiển đều có giá trị
                if (string.IsNullOrWhiteSpace(text_MaChuyenBay.Text) || combo_SanBayDi.SelectedIndex == -1 ||
                    combo_SanBayDen.SelectedIndex == -1 || string.IsNullOrWhiteSpace(text_ThoiGianBay.Text) ||
                    string.IsNullOrWhiteSpace(text_SLgheHang1.Text) || string.IsNullOrWhiteSpace(text_SLgheHang2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ các điều khiển
                string maChuyenBay = text_MaChuyenBay.Text;
                string sanBayDi = combo_SanBayDi.SelectedItem.ToString();
                string sanBayDen = combo_SanBayDen.SelectedItem.ToString();
                DateTime ngay = dateTimePicker_Ngay.Value;
                int thoiGianBay = int.Parse(text_ThoiGianBay.Text);
                int SLgheHang1 = int.Parse(text_SLgheHang1.Text);
                int SLgheHang2 = int.Parse(text_SLgheHang2.Text);

                // Thêm dữ liệu vào DataGridView
                dataGridView_ThongTin.Rows.Add(maChuyenBay, sanBayDi, sanBayDen, ngay.ToString("MM/dd/yyyy"), thoiGianBay, SLgheHang1, SLgheHang2);

                // Xóa các điều khiển sau khi thêm
                text_MaChuyenBay.Clear();
                combo_SanBayDi.SelectedIndex = -1;
                combo_SanBayDen.SelectedIndex = -1;
                dateTimePicker_Ngay.Value = DateTime.Now;
                text_ThoiGianBay.Clear();
                text_SLgheHang1.Clear();
                text_SLgheHang2.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho số lượng ghế và thời gian bay.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin chuyến bay đã chọn
            if (dataGridView_ThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_ThongTin.SelectedRows[0];
                row.Cells[0].Value = text_MaChuyenBay.Text;
                row.Cells[1].Value = combo_SanBayDi.SelectedItem.ToString();
                row.Cells[2].Value = combo_SanBayDen.SelectedItem.ToString();
                row.Cells[3].Value = dateTimePicker_Ngay.Value.ToString("MM/dd/yyyy");
                row.Cells[4].Value = int.Parse(text_ThoiGianBay.Text);
                row.Cells[5].Value = int.Parse(text_SLgheHang1.Text);
                row.Cells[6].Value = int.Parse(text_SLgheHang2.Text);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa thông tin chuyến bay đã chọn
            if (dataGridView_ThongTin.SelectedRows.Count > 0)
            {
                dataGridView_ThongTin.Rows.RemoveAt(dataGridView_ThongTin.SelectedRows[0].Index);
            }
        }

        private void button_NhapLai_Click(object sender, EventArgs e)
        {
            // Nhập lại các điều khiển
            text_ThoiGianBay.Clear();
            combo_SanBayDi.SelectedIndex = -1;
            combo_SanBayDen.SelectedIndex = -1;
            dateTimePicker_Ngay.Value = DateTime.Now;
            text_ThoiGianBay.Clear();
            text_SLgheHang1.Clear();
            text_SLgheHang2.Clear();
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void combo_SanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combo_SanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combo_SanBayDi_DropDown(object sender, EventArgs e)
        {
            combo_SanBayDi.Items.Clear();//khi vài sẽ clear hết đi rồi mới nạp các item vào danh sách
            combo_SanBayDi.Items.Add("Nội Bài");
            combo_SanBayDi.Items.Add("Tân Sân Nhất");
            combo_SanBayDi.Items.Add("Vân Đồn");
            combo_SanBayDi.Items.Add("Đà Nẵng");
            combo_SanBayDi.Items.Add("Phú Quốc");
        }

        private void combo_SanBayDen_DropDown(object sender, EventArgs e)
        {
            combo_SanBayDen.Items.Clear();
            combo_SanBayDen.Items.Add("Nội Bài");
            combo_SanBayDen.Items.Add("Tân Sân Nhất");
            combo_SanBayDen.Items.Add("Vân Đồn");
            combo_SanBayDen.Items.Add("Đà Nẵng");
            combo_SanBayDen.Items.Add("Phú Quốc");
        }

        private void button_Them_Click_1(object sender, EventArgs e)
        {

        }
    }
}
