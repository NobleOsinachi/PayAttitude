using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayAttitude.Models
{
    public class Bank
    {
        public int Id{ get; set; }
        [MaxLength(15)]
        public string ShortCode{ get; set; }
        public string Name{ get; set; }
    }

    
}
