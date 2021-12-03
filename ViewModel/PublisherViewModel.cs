using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAspMiniProject.ViewModel
{
    public class AddPublisherViewModel
    {
        public string Title { get; set; }
        public string Logo { get; set; }
    }

    public class UpdatePublisherViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }
    }



}