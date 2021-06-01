using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.Model;

namespace DoAn1.Controllers
{
    class DiemController
    {
        public static bool ThemUser(Diem nguoichoi)
        {


            using (var _context = new DoAnCNTTEntities())
            {
                _context.Diems.Add(nguoichoi);
                _context.SaveChanges();
                return true;
            }

        }
        public static bool checkExistUser(string tenuser)
        {
            using (var _context = new DoAnCNTTEntities())
            {
                var user = from u in _context.Diems
                         where u.NameUser == tenuser
                         select u;
                if (user.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool UpdateUser(Diem nguoichoi)
        {
            try
            {
                using (var _context = new DoAnCNTTEntities())
                {
                    _context.Diems.AddOrUpdate(nguoichoi);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<Diem> danhsachdiemeasy()
        {
            using (var _context = new DoAnCNTTEntities())
            {
                var diem = (from x in _context.Diems.AsEnumerable() where x.CapDo==0
                            orderby x.Score descending
                            select x).Take(10)
                            .Select(x => new Diem
                            {
                                NameUser = x.NameUser,
                                Score = x.Score
                            }).ToList();
                return diem;
            }
        }
        public static List<Diem> danhsachdiemhard()
        {
            using (var _context = new DoAnCNTTEntities())
            {
                var diem = (from x in _context.Diems.AsEnumerable() where x.CapDo==1
                            orderby x.Score descending
                            select x).Take(10)
                            .Select(x => new Diem
                            {
                                NameUser = x.NameUser,
                                Score = x.Score
                            }).ToList();
                return diem;
            }
        }
    }
}
