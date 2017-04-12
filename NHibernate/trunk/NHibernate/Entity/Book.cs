using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Entity
{

    public class Book
    {
        private long id;
        private string isbn;
        private string title;

        public virtual long ID
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Book()
        {
        }

        public Book(string bookIsbn, string bookTitle)
        {
            isbn = bookIsbn;
            title = bookTitle;
        }
    }

}
