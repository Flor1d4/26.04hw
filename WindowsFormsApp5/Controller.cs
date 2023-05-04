using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Model;

namespace WindowsFormsApp5
{
    class Controller
    {
        Database db;
        List list;
        public Controller()
        {
            db = new Database();
        }
        public string GetBook(string bookname)
        {
            Book rez = db.Find(bookname);

            if (rez != null)
            {
                return rez.ToString();
            }
            return "Нет такой книги";
        }

        public void NewBook()
        {
            Add add = new Add();
            Book book = null;
            DialogResult rez = add.ShowDialog();
            if (rez == DialogResult.OK)
            {
                book = add.GetNewBook();
                if (book == null)
                {
                    MessageBox.Show("Null");
                    return;
                }
            }
            else if (rez == DialogResult.Cancel)
            {
                return;
            }
            db.AddBook(book);
            GetAllBooks();
        }

        public void GetAllBooks()
        {
            list = new List();
            db.controller = this;
            db.ShowAllBooks();
        }
        public void ShowAllBooks(List<Book> books)
        {
            list.Show();
            foreach (Book x in books)
                list.AddBook(x);
        }
    }
}
