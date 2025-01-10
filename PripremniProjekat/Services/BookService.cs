using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PripremniProjekat.Models;
using PripremniProjekat.Repositories;

namespace PripremniProjekat.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository repository;

        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }

        public List<Book> GetAllBooks()
        {

            return repository.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            if (book.Author != null)
            {
                repository.AddBook(book);
            }
        }

        public void AddBook(String name, String description, String author)
        {
            var book = new Book { Name = name, Description = description, Author = author };

            repository.AddBook(book);
        }
    }
}
