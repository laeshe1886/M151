using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ch.gibz.m151.demo.data.Model
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
