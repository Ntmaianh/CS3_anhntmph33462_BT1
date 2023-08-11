using CS3_XUONG_DE1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_XUONG_DE1.Controller
{
    internal class Services
    {
        Repositories _res = new Repositories();
        public List<LoaiXm> getLoaiXe()
        {
            return _res.getLoaiXe();
        }
        public List<XeMay> getXeMay(string find)
        {
            return _res.GetXeMays(find);
        }
        public void AddXeMay(XeMay xemay)
        {
            if (_res.AddXeMay(xemay))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void XoaXeMay(Guid? id)
        {
            if (_res.DeleteXeMay(id))
            {
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
