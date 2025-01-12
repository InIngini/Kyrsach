﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Курсач.Core.Data.Entities;

namespace Курсач.Core.DB.Interfaces
{
    public interface IDatabaseManager
    {
        Task<User> GetUserAsync();
        Task AddUserAsync(User user);
        Task DeleteUserAsync();

        Task<Book> GetBookAsync(int id);
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);
        Task DeleteAllBooksAsync();
        Task<List<Book>> GetAllBooksAsync();
    }
}
