﻿using System.ComponentModel.DataAnnotations;

namespace ApiGroupProject.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Password { get; set; }
    }
}
