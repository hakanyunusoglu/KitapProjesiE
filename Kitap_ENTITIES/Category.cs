﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap_ENTITIES
{
    public class Category
    {[Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
        
    }
}
