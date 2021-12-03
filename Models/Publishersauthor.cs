using System;
using System.Collections.Generic;

#nullable disable

namespace myAspMiniProject.Models
{
    public partial class Publishersauthor
    {
        public int Id { get; set; }
        public int Publisherid { get; set; }
        public int Authorid { get; set; }

        public virtual User Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
