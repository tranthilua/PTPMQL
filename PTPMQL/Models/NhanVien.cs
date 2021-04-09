using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PTPMQL.Models
{
    public class NhanVien : Person
    {
        public string NhanVienID { get; set; }
        public int CongTy { get; set; }
    }
}