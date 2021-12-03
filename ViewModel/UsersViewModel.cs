using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAspMiniProject.ViewModel
{
    public class AddUsersViewModel
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
    }


    public class UpdateUsersViewModel
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

    }


}