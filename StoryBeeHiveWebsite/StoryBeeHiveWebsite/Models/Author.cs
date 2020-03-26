using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class Author
    {
        public virtual int AuthorId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string About { get; set; }
        public virtual string Hobbies { get; set; }
    }
}