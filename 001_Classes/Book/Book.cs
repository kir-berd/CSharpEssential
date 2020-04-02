using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Classes
{
    class Book
    {
        Title title = null;
        Author author = null;
        Body body = null;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.body = new Body();
        }

        public Book()
        {
            InitializeBook();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.body.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }
        public string Author
        {
            set
            {
                this.author.Content = value;
            }
        }
        public string Title
        {
            set
            {
                this.title.Content = value;
            }
        }
    }
}
