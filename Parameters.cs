using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PayAttitude.Models
{
    public class Parameters
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        [DataType(DataType.Text)]
        [RegularExpression("[0-9]{7-11}")]
        public Regex RegEx { get; set; }
        public bool IsRequired { get; set; }
        public bool SendToSwitch { get; set; }
        public int Order { get; set; }
        public bool ReplaceAmount { get; set; }
    }
}