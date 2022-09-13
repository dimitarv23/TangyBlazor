﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
    public class CategoryDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
    }
}
