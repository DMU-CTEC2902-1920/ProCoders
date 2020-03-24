using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}