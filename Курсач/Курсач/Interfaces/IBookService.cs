﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Курсач.Data.DTO;
using Курсач.Data.Entities;

namespace Курсач.Core.Interfaces
{
    public interface IBookService
    {
        Task<Book> CreateBook(UserBookData bookData);
        Task<Book> GetBook(int id);
        Task UpdateBook(int id, Book book);
        Task DeleteBook(int id);
        Task<List<Book>> GetAllBooksForUser(int userId);
    }
}
