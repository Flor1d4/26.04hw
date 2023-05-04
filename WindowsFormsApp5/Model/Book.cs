using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Model
{
    public class Book : IEquatable<Book>
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Book() { }
        public Book(string n, string a)
        {
            Name = n;
            Author = a;
        }
        public override string ToString()
        {
            return $"Название: {Name}\tАвтор: {Author}\n";
        }

        public bool Equals(Book obj)
        {
            return Name == obj.Name;
        }
    }
}
