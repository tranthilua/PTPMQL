using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("QuanLy")]
    public class QuanLy
    { 
        [Key]
        public string MaQuanLy { get; set; }
        public string TenQuanLy { get; set; }
        public string DiaChi { get; set; }


    }
}