using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static PayAttitude.Models.Policy;

namespace PayAttitude.Models
{
    public class Notify 
    {
        public int Id { get; set; }
        public virtual ProductCatalog Product{ get; set; }
        public int ProductId{ get; set; }
        public string ProductCode{ get; set; }
        public virtual Customer Customer{ get; set; }
        public string CustomerVehicleNumber { get; set; }
                      
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhoneNumber { get; set; }
        [DataType(DataType.Currency)]
        public decimal Amount{ get; set; }
        public virtual Policy Policy{ get; set; }
        public int PolicyId { get; set; }
        public int PolicyName { get; set; }
        public DateTime Registered { get; set; }
        public DateTime Expired { get; set; }
        public StatusEnum Status{ get; set; }
        public string Certificate{ get; set; }


    }
}