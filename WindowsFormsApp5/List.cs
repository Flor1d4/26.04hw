using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Model;

namespace WindowsFormsApp5
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        public void AddBook(Book book)
        {
            listBox1.Items.Add(book.ToString());
        }
    }
}
