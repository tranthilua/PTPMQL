﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("tests")]
    public class test
    {
        [Key]
        public int MyProperty { get; set; }
    }
}