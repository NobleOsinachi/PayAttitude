using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PayAttitude.Models
{
    [Guid("12345678-1234-5678-1234-567812345678")]
    public class ProductCatalog
    {
        //private static readonly string _defaultImageUrl = "~/Content/Images/default-image.png";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual Group Category { get; set; }
        public int CategoryId { get; set; }

        public string? ImageUrl
        {
            get
            {
                return this.ImageUrl;
            }
            set
            {
                ImageUrl ??= "~/Content/Images/default-image.png";
            }
        }

        [DataType(DataType.Url)]
        public string Certificate { get; set; }

        public bool IsSelected { get; set; }
        public string? ReferenceMessage { get; set; }

        public bool CanChangePrice { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string StandardPrices { get; set; }
        public bool Notify { get; set; }
        public bool VerifyParameters { get; set; }
        public virtual ICollection<Parameters> Parameter { get; set; }
        public int ParameterId { get; set; }
        public string ParameterLabel { get; set; }
        public Regex ParameterRegExp { get; set; }
        public bool AmountFromVendor { get; set; }
        public virtual Group Group{ get; set; }
        public byte Order { get; set; }


    }
}