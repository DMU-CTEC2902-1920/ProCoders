using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Story
    {
        public virtual int StoryId { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
    }
}