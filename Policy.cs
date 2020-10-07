using System;
using System.ComponentModel.DataAnnotations;

namespace PayAttitude.Models
{
    public class Policy
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Registered { get; set; }
        public DateTime Expired
        {
            get { return this.Expired; }
            set { this.Expired = new DateTime(); Registered.AddYears(1); }
        }
        public StatusEnum Status { get; set; }
        public enum StatusEnum
        {
            Expired = 0,
            Active = 1
        }
        [DataType(DataType.Url)]
        public string Certificate { get; set; }

    }
}