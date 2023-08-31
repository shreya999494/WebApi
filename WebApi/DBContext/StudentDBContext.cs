using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.DBContext
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("DemoDBContext")
        { 

        }   
        public DbSet<Student> Students { get; set; }    
        public DbSet<Address> Addresss { get; set; }
    }
}