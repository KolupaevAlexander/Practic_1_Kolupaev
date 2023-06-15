using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Song
    {
        private string author;
        public string Author { get { return author; } }
        private string title;
        public string Title { get { return title; } } 
        private string filename;
        public string Filename { get { return filename; } }
        public Song(string Author, string Title, string Filename)
        {
            this.author=Author;
            this.title=Title;
            this.filename=Filename;
        }
    }
}
