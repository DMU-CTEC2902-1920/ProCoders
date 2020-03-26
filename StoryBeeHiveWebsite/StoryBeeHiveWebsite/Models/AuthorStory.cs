using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class AuthorStory
    {
        public virtual Author Author { get; set; }
        public virtual Story Story { get; set; }
    }
}