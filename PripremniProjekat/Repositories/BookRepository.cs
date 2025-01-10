using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PripremniProjekat.Data;
using PripremniProjekat.Models;

namespace PripremniProjekat.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly MojContext mojContext;
        public BookRepository(MojContext context) {
            this.mojContext = context;
        }
        public List<Book> GetAllBooks()
        {
            return mojContext.Books.ToList();
        }
        
        public Book GetBook(int id)
        {
            return mojContext.Books.Find(id);
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return mojContext.Books.Where(x => x.Author == author).ToList();
        }

        public void AddBook(Book book)
        {
            mojContext.Books.Add(book);
            mojContext.SaveChanges();
        }

        public void RemoveBook(int id)
        {
            var book = mojContext.Books.Find(id);

            if (book != null)
            {
                mojContext.Books.Remove(book);
                mojContext.SaveChanges();
            }

        }

    }
}
