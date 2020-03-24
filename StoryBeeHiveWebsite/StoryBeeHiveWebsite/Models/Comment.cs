using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class Comment
    {
        public virtual int CommentId { get; set; }
        public virtual string Description { get; set; }
        public virtual int StoryId { get; set; }
        
    }
}