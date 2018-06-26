using System;
using System.ComponentModel.DataAnnotations;

namespace CharityBounce.Models
{
    public class Registration
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        //public DateTime Registered { get; set; }

    }
}