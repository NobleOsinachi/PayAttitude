using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayAttitude.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public Guid Password { get; set; }

        public bool IsEligible { get; set; } = false;

        //public virtual IEnumerable<Product> Products { get; set; }

        public string? Reference { get; set; }

        public string VehicleNumber{ get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber{ get; set; }

        public virtual Policy PolicyId { get; set; }
    }
}