using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }

    }
}