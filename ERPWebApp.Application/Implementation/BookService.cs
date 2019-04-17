﻿using AutoMapper;
using BeYeuBookstore.Application.Interfaces;
using BeYeuBookstore.Application.ViewModels;
using BeYeuBookstore.Data.Entities;
using BeYeuBookstore.Infrastructure.Interfaces;
using BeYeuBookstore.Utilities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeYeuBookstore.Application.Implementation
{
    public class BookService : IBookService
    {
        private IRepository<Book, int> _bookRepository;
        private IUnitOfWork _unitOfWork;
        public BookService(IRepository<Book, int> bookRepository, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
        }
        public BookViewModel Add(BookViewModel BookViewModel)
        {
            var book = Mapper.Map<BookViewModel, Book>(BookViewModel);
            _bookRepository.Add(book);
            _unitOfWork.Commit();
            return BookViewModel;
        }

        public void Delete(int id)
        {
            _bookRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<BookViewModel> GetAll()
        {
            var query = _bookRepository.FindAll();
            var data = new List<BookViewModel>();
            foreach (var item in query)
            {
                var _data = Mapper.Map<Book, BookViewModel>(item);
                data.Add(_data);
            }
            return data;
        }

        public List<BookViewModel> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public PagedResult<BookViewModel> GetAllPaging(string fromdate, string todate, string keyword, int bookcategoryid, int page, int pageSize)
        {
            var query = _bookRepository.FindAll(p => p.BookCategoryFKNavigation, p=>p.MerchantFKNavigation);
            query = query.OrderBy(x => x.KeyId);
            if (!string.IsNullOrEmpty(keyword))
            {
                var keysearch = keyword.Trim().ToUpper();

                query = query.OrderBy(x => x.KeyId).Where(x => (x.BookTitle.ToUpper().Contains(keysearch)) || (x.MerchantFKNavigation.MerchantCompanyName.ToUpper().Contains(keysearch)));

            }
            if (!string.IsNullOrEmpty(fromdate))
            {
                var date = DateTime.Parse(fromdate);
                TimeSpan ts = new TimeSpan(0, 0, 0);
                DateTime _fromdate = date.Date + ts;
                query = query.Where(x => x.DateCreated >= _fromdate);

            }
            if (!string.IsNullOrEmpty(todate))
            {
                var date = DateTime.Parse(todate);
                TimeSpan ts = new TimeSpan(23, 59, 59);
                DateTime _todate = date.Date + ts;
                query = query.Where(x => x.DateCreated <= _todate);

            }
            if (bookcategoryid != 0)
            {
                query = query.Where(x => x.BookCategoryFK == bookcategoryid);
            }
          
            int totalRow = query.Count();

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var data = new List<BookViewModel>();
            foreach (var item in query)
            {
                var _data = Mapper.Map<Book, BookViewModel>(item);
                data.Add(_data);
            }

            var paginationSet = new PagedResult<BookViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public BookViewModel GetById(int id)
        {
            return Mapper.Map<Book, BookViewModel>(_bookRepository.FindById(id, p => p.BookCategoryFKNavigation, p => p.MerchantFKNavigation));
        }

        public bool Save()
        {
            return _unitOfWork.Commit();
        }

        public void Update(BookViewModel BookViewModel)
        {
            var temp = _bookRepository.FindById(BookViewModel.KeyId);
            if (temp != null)
            {
                temp.Author = BookViewModel.Author;
                temp.BookCategoryFK = BookViewModel.BookCategoryFK;
                temp.BookTitle = BookViewModel.BookTitle;
                temp.Description = BookViewModel.Description;
                temp.Height = BookViewModel.Height;
                temp.Length = BookViewModel.Length;
                temp.Width = BookViewModel.Width;
                temp.PageNumber = BookViewModel.PageNumber;
                temp.isPaperback = BookViewModel.isPaperback;
                temp.UnitPrice = BookViewModel.UnitPrice;
                temp.Quantity = BookViewModel.Quantity;
            }
        }
    }
}
