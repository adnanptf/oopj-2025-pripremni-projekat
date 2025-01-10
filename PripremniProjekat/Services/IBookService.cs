using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PripremniProjekat.Models;

namespace PripremniProjekat.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
        void AddBook(String name, String description, String author);
    }
}
