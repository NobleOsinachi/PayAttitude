using System;
using System.ComponentModel.DataAnnotations;

namespace PayAttitude.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public Guid PaymentHashId { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerId{ get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount{ get; set; }

        public virtual Bank Bank { get; set; }
        public int BankId { get; set; }

        public virtual ProductCatalog Catalog{ get; set; }
        public virtual Group Category{ get; set; }
    }
}