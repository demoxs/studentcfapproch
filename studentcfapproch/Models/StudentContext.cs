using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace studentcfapproch.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext():base("studentdb")
        {

        }
        public DbSet<student> Students { get; set; }

    }
}