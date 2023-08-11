using CS3_XUONG_DE1.Controller;
using CS3_XUONG_DE1.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3_XUONG_DE1.View
{
    public partial class QuanLiXe : Form
    {
        Services services = new Services();
        Guid _idWhenClick;
        public QuanLiXe()
        {
            InitializeComponent();
        }

        private void QuanLiXe_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtTen.Text = "";
            txtMoTa.Text = "";
            txtGiaNhap.Text = "";
            txtSl.Text = "";
        }
        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void LoadData(string find)
        {
            int stt = 1;
            dgvXeMay.ColumnCount = 7;
            dgvXeMay.Columns[0].Name = "Id";
            dgvXeMay.Columns[1].Name = "STT";
            dgvXeMay.Columns[2].Name = "Tên Xe";
            dgvXeMay.Columns[3].Name = "Mô tả";
            dgvXeMay.Columns[4].Name = "Số lượng";
            dgvXeMay.Columns[5].Name = "Loại xe";
            dgvXeMay.Columns[6].Name = "Gía nhập";
            dgvXeMay.Columns[0].Visible = false;
            dgvXeMay.Columns[6].Visible = false;
            dgvXeMay.Rows.Clear();

            foreach (var item in services.getXeMay(find))
            {
                var loaiXe = services.getLoaiXe().FirstOrDefault(x => x.Id == item.IdLxm);


                dgvXeMay.Rows.Add(item.Id, stt++, item.Ten, item.Mota, item.SoLuong, loaiXe == null ? "xe nhái" : loaiXe.Ten , item.GiaNhap);


            }
        }

        private void txtHienThi_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                services.XoaXeMay(_idWhenClick);
                LoadData(null);
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi rồi!");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                XeMay xemay = new XeMay();
                xemay.Ten = txtTen.Text;
                xemay.Mota = txtMoTa.Text;
                if (CheckGiaNhap() == true)
                {
                    xemay.GiaNhap = decimal.Parse(txtGiaNhap.Text);
                }
                else
                {
                  MessageBox.Show("Nhập sai thông tin vui lòng nhập lại !","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    return;

                }
                int ma = 0;
                if(services.getXeMay(null).Any(x => x.Ma == ma.ToString()))
                {
                    ma++;
                }
                xemay.Ma = ma.ToString();
                xemay.SoLuong = int.Parse(txtSl.Text);
                services.AddXeMay(xemay);
                LoadData(null);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi rồi!");
            }


        }
        public bool CheckGiaNhap()
        {
            int giaNhap = int.Parse(txtGiaNhap.Text);
            if (giaNhap < 0)
            {
                MessageBox.Show("Vui lòng nhập giá lớn hơn 0");
                return false;
            }
            else if (!Regex.IsMatch(txtGiaNhap.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Gía nhập chỉ được phép nhập số nguyên");
                return false;
            }
            return true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0 || txtTimKiem.Text == null)
            {
                LoadData(null);
            }
            else
            {
                LoadData(txtTimKiem.Text);
            }
        }

        private void dgvXeMay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idWhenClick = Guid.Parse(dgvXeMay.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTen.Text = dgvXeMay.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMoTa.Text = dgvXeMay.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSl.Text = dgvXeMay.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGiaNhap.Text = dgvXeMay.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}