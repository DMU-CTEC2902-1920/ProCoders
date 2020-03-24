using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Author
    {
        public virtual int AuthorId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string SurName { get; set; }
        public virtual int StoryId { get; set; }
    }
}