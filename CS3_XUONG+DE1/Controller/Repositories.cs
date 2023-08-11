using CS3_XUONG_DE1.Context;
using CS3_XUONG_DE1.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_XUONG_DE1.Controller
{
    internal class Repositories
    {
        DBContext db = new DBContext();

        public List<LoaiXm> getLoaiXe()
        {
            return db.LoaiXms.ToList();
        }
        public List<XeMay> GetXeMays(string find)
        { 
            if(find == null)
            {
                return db.XeMays.ToList();
            }
            return db.XeMays.Where(x => x.Ten.Trim().ToLower().Contains(find.Trim().ToLower())).ToList();
        }

        public bool AddXeMay( XeMay xemay)
        {
            if(xemay == null) 
            {
                return false;
            }
            xemay.Id = new Guid();
            db.XeMays.Add(xemay);
            db.SaveChanges();
            return true;
        }

        public bool DeleteXeMay(Guid? id )
        {
            var xeMaYExist = db.XeMays.FirstOrDefault(x => x.Id == id);
            if(xeMaYExist == null)
            {
                return false;
            }
            db.XeMays.Remove(xeMaYExist);
            db.SaveChanges();
            return true;
        }
    }
}
