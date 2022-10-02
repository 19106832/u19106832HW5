using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace u19106832HW5.Models
{
    public class BooksVM
    {
        public List<Book> Books { get; set; }   
        public List<Author> Authors { get; set; }
        public List<Types> Types { get; set; }
    }
}