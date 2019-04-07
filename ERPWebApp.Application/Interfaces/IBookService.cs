﻿using BeYeuBookstore.Application.ViewModels;
using BeYeuBookstore.Utilities.DTOs;
using System;
using System.Collections.Generic;

namespace BeYeuBookstore.Application.Interfaces
{
    public interface IBookService : IDisposable
    {
        BookViewModel Add(BookViewModel BookViewModel);

        void Update(BookViewModel BookViewModel);

        void Delete(int id);

        List<BookViewModel> GetAll();

        PagedResult<BookViewModel> GetAllPaging(string keyword, int page, int pageSize);

        List<BookViewModel> GetAll(int id);

        BookViewModel GetById(int id);

        bool Save();
    }
}
