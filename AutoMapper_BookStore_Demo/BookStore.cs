using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace AutoMapper_BookStore_Demo
{
    public class BookStore
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public List<Author> Authors { get; set; }
        public DateTime? PublishDate { get; set; }
        public Publisher Publisher { get; set; }    
        public int? Paperback { get; set; }    


    }

    public class Publisher
    {
        public string Name { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ContactInfo ContactInfo { get; set; }    
    }

    public class ContactInfo
    {
        public string Email { get; set; }

        public string Blog { get; set; }
        public string Twitter { get; set; }    
    }
}
