﻿using System.ComponentModel.DataAnnotations;

namespace medical_supplies.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplyOrder { get; set; }
    }
}
