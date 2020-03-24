using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class Story
    {
        public virtual int StoryId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int AuthorId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}