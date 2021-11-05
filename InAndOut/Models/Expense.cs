﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace InAndOut.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [DisplayName("Expense name")]
        [Required]
        public string ExpenseName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0")]
        public int Cost { get; set;}
    }
}
