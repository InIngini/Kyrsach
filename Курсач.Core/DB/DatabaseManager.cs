﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Курсач.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using Курсач.Core.DB.Interfaces;
using Newtonsoft.Json.Linq;
using System.IO;
using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Shapes;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace Курсач.Core.DB
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly SQLiteAsyncConnection Database;
        public DatabaseManager()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB.sqlite");
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<User>().Wait();
            Database.CreateTableAsync<Book>().Wait();
        }
        public async Task<User> GetUserAsync()
        {
            return await Database.Table<User>().FirstOrDefaultAsync();
        }

        public async Task AddUserAsync(User user)
        {
            if (Database.Table<User>() == null || Database.Table<User>().FirstOrDefaultAsync(b => b.Id == user.Id) == null) // Если в базе нет пользователя или нет именно этого пользователя
            {
                await DeleteUserAsync();
                await DeleteAllBooksAsync();
                await Database.InsertAsync(user);
            }
        }

        public async Task DeleteUserAsync()
        {
            await Database.DeleteAllAsync<User>();
        }

        public async Task<Book> GetBookAsync(int id)
        {
            return await Database.Table<Book>().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddBookAsync(Book book)
        {
            await Database.InsertAsync(book);
        }
        public async Task UpdateBookAsync(Book book)
        {
            await Database.UpdateAsync(book);
        }
        public async Task DeleteBookAsync(int id)
        {
            var bookToDelete = await Database.Table<Book>().FirstOrDefaultAsync(b => b.Id == id);

            if (bookToDelete != null)
            {
                await Database.DeleteAsync(bookToDelete);
            }
        }

        public async Task DeleteAllBooksAsync()
        {
            await Database.DeleteAllAsync<Book>();
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await Database.Table<Book>().ToListAsync();
        }
    }

}
