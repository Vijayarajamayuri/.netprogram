using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace delegatevent
{
    class BookOrderDriver
    {
       
        static void Main(string[] args)
        {   
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book(1, "More Effective C#"));
            bookList.Add(new Book(2, "Head First Design Pattern"));
            bookList.Add(new Book(3, "Fluent Python"));
            bookList.Add(new Book(4, "First Generation Mainframes"));
          
            List<Order> orderList = new List<Order>();
            orderList.Add(new Order(1, 100, "Debit"));
            orderList.Add(new Order(1, 104, "Credit"));
            orderList.Add(new Order(3, 105, "Debit"));
            orderList.Add(new Order(4, 108, "Cash"));
            orderList.Add(new Order(5, 110, "Debit"));

            var numQuery = (from Book in bookList
                            from Order in orderList
                            where Book.id == Order.BkId
                            select new { Book.id,Book.BKname,Order.Pymmode});
            foreach (var item in numQuery)
            {
                Console.WriteLine(item);
            }

            var BookListToXML = new XElement("Root",
                from Book in bookList
                select new XElement("BookList",
                    new XAttribute("BookID", Book.id),
                    new XElement("BookName", Book.BKname)//END OF BOOKLIST
                    )
                );
            Console.WriteLine(BookListToXML);
            char[] dataset1 = { 'H', 'A', 'P', 'P', 'Y' };
            int[] dataset2 = { 1, 2, 3 };
            var cartesianProduct = from letters in dataset1
                                   from num in dataset2
                                   select new { letters, num };
            foreach(var items in cartesianProduct)
            {
                Console.WriteLine(items);
            }

        }
        class Book
        {
            private int bookID;
            private string bookName;

            public Book(int bookID, string bookName)
            {
                this.bookID = bookID;
                this.bookName = bookName;
            }
            public int id
            {
                get { return this.bookID; }

                set
                {
                    bookID = value;
                }
            }
            public string BKname
            {
                get { return this.bookName; }
                set { bookName = value; }
            }
        }
           class Order{
                private int bookID;
                private int orderID;
                private string paymentMode;

                public Order(int bookID, int orderID, string paymentMode)
                {
                    this.bookID = bookID;
                    this.orderID = orderID;
                    this.paymentMode = paymentMode;
                }
                public int BkId
                {
                    get { return this.bookID; }
                    set { bookID = value; }
                }
                 public int OrdId
                {
                    get { return this.orderID; }
                    set { orderID = value; }
                }
                public String Pymmode
                {
                    get { return this.paymentMode; }
                    set { paymentMode = value; }
                }




            }
        }
    }

