using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("FullName", TypeName = "varchar")]
        public string Name { get; set;}

        
        [Column("Address",TypeName ="varchar")]
        public string Address { get; set;}
        //public Address Address { get; set;}
        public string Mobile { get; set;}
    }
}