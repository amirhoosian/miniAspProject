using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAspMiniProject.ViewModel
{
    public class AddArticleViewModel
    {

        public int Publisherid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Imagename { get; set; }
    }


    public class UpdateArticleViewModel
    {
        public int Id { get; set; }
        public int Publisherid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Imagename { get; set; }
    }





}