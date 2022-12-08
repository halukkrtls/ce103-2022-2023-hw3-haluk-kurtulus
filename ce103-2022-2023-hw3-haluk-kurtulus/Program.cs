using LibraryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace LibraryManagement
{
    //Defining a class Book
    class Book
    {
        public int bookId;
        public string bookName;
        public string bookcategories;
        public int bookPrice;
        public int bookCount;
        public int x;
        public int year;
        public string bookabstract;
        public int bookyear;
        public string booktags;
        public string authorkeywords;
        public string bookedition;
        public string editors;
        public string bookpublisher;
        public int URL;
        public int DOI;
        public int ISBN;
        public int rockno;
        public int rowno;
        public string ActionAdventure;
        public string Classics;
        public string CBGV;
        public string city;
    }
    //Defining a class Borrow
    class BorrowDetails
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
        public DateTime givendate;

    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();

        //Password verfication and Menu 
        static void Main(string[] args)
        {
            Console.Write("Welcome to Haluk Library!!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "oflee615")
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("************************************************\n");
                    Console.WriteLine("Menu\n" +
                    "1)Add book\n" +
                    "2)Delete book\n" +
                    "3)Search book\n" +
                    "4)Borrow book\n" +
                    "5)Return book\n" +
                    "6)Close \n\n" 
                    
                    );
                    
                    Console.WriteLine("**************************************************\n");
                    Console.Write("Choose your option from menu :");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        GetBook();
                    }
                    else if (option == 2)
                    {
                        RemoveBook();
                    }
                    else if (option == 3)
                    {
                        SearchBook();
                    }
                    else if (option == 4)
                    {
                        Borrow();
                    }
                    else if (option == 5)
                    {
                        ReturnBook();
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Thanks");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
            Console.ReadLine();
        }

        //To add book details to the Library database
        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Page of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            Console.Write("Book year:");
            book.bookyear = int.Parse(Console.ReadLine());
            Console.Write("Book Abstract:");
            book.bookabstract = Console.ReadLine();
            Console.Write("Book Tags:");
            book.bookabstract = Console.ReadLine();
            Console.Write("Book Author Keywords:");
            book.authorkeywords = Console.ReadLine();
            Console.Write("Book Edition:");
            book.bookedition = Console.ReadLine();
            Console.Write("Book Editors:");
            book.editors = Console.ReadLine();
            Console.Write("Book Publisher:");
            book.bookpublisher = Console.ReadLine();
            Console.Write("Book URL:");
            book.URL = int.Parse(Console.ReadLine());
            Console.Write("Book Catalog Ids (DOI):");
            book.DOI = int.Parse(Console.ReadLine());
            Console.Write("Book Catalog Ids(ISBN):");
            book.ISBN = int.Parse(Console.ReadLine());
            Console.Write("Book location(rockno):");
            book.rockno = int.Parse(Console.ReadLine());
            Console.Write("Book location(rawkno):");
            book.rowno = int.Parse(Console.ReadLine());
            Console.Write("the city where it is written:");
            book.city =Console.ReadLine();
            Console.Write("Book Categorie:");
            book.bookcategories = Console.ReadLine();
            
                //Console.WriteLine("\nMenu\n" +
                //    "1)Action and Adventure.\n" +
                //       "2)Classics.\n" +
                //       "3)Comic Book or Graphic Novel.\n" +
                //       "4)Detective and Mystery.\n" +
                //       "5)Fantasy.\n" +
                //       "6)Historical Fiction.\n\n");
                //Console.Write("Choose your category from menu :");

                //int option = int.Parse(Console.ReadLine());

                //if (option == 1)
                //{
                //    book.ActionAdventure = Console.ReadLine();
                //}
                //else if (option == 2)
                //{
                //    book.Classics = Console.ReadLine();
                //}
                //else if (option == 3)
                //{
                //    book.CBGV = Console.ReadLine();
                //}
                //else if (option == 4)
                //{
                //    book.bookName = Console.ReadLine();
                //}
                //else if (option == 5)
                //{
                //    book.bookName = Console.ReadLine();
                //}
                //else if (option == 6)
                //{
                //    book.bookName = Console.ReadLine();
                
                //}
               
                
                bookList.Add(book);
            
            
            

        }
        //To delete book details from the Library database 
        public static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");
            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }

        //To search book details from the Library database using Book id 
        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}\n" +
                        "Book Category :{4}\n" +
                        "Book Year :{5}\n" +
                        "Book Editors :{6}\n" +
                        "Book Publisher :{7}\n" +
                         "Book rock no: {8}\n" +
                         "Book raw no:{9}\n"  +
                         "Book abstract :{10}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount, searchId.bookcategories, searchId.year,searchId.editors,searchId.bookpublisher,searchId.rockno,searchId.rowno,searchId.bookabstract);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        public static void Borrow()
        {
            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }
    }
}



