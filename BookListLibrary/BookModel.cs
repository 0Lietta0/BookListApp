using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListLibrary
{
    public class BookModel
    {
        public string Author { get; set; } = "";
        public string Title { get; set; } = "";

        public int NumberOfPages { get; set; } 

        private string _bookFullInfo = "";
        public string BookFullInfo
        {
            get { return $"{Author}, \"{Title}\", {NumberOfPages} pp."; }
        }
    }
}

