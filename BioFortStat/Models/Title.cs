﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Title
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string TitleValue { get; set; }
        [StringLength(15)]
        public string TitleName { get; set; }
    }
}