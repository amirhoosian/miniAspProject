using System;
using System.Collections.Generic;

#nullable disable

namespace myAspMiniProject.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Articles = new HashSet<Article>();
            Publishersauthors = new HashSet<Publishersauthor>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Publishersauthor> Publishersauthors { get; set; }
    }
}
