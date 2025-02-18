﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PripremniProjekat.Models;

namespace PripremniProjekat.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
        List<Book> GetBooksByAuthor(string author);
        void AddBook(Book book);
        void RemoveBook(int id);
    }
}
