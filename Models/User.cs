using System;
using System.Collections.Generic;

#nullable disable

namespace myAspMiniProject.Models
{
    public partial class User
    {
        public User()
        {
            Publishersauthors = new HashSet<Publishersauthor>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Publishersauthor> Publishersauthors { get; set; }
    }
}
