﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_Project.Core.Models
{
    public class Auther
    {
        public int AutherId { get; set; }
        public string AutherName { get; set; }
        public int  BookNum { get; set;}
       
    }
}
