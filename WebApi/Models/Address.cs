using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }


    }
}