using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Students")]
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Age { get; set; }
    }
}