using System;
using System.Collections.Generic;

#nullable disable

namespace myAspMiniProject.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public int Publisherid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Imagename { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
