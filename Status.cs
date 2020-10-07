using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PayAttitude.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /*Active, Expired*/
    }
}