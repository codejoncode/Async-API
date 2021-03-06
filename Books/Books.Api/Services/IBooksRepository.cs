﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Api.Entities;

namespace Books.Api.Services
{
    public interface IBooksRepository
    {
        //IEnumerable<Book> GetBooks();
        //Book GetBook(Guid id);
        //Async version 
        Task<IEnumerable<Book>>GetBooksAsync();
        Task<Book> GetBookAsync(Guid id);

    }
}
