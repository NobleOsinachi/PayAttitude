using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayAttitude.Models
{
    public class Verify
    {
        public int Id { get; set; }
        public virtual ProductCatalog Product { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int CustomerVehicleNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhoneNumber { get; set; }
    }
}