using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace u19106832HW5.Models
{
    public class StudentVM
    {
        public List<Student> Students { get; set; }
        public Book Book { get; set; }
        public List<Class> Class { get; set; }

    }
}