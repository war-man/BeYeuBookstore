﻿using BeYeuBookstore.Application.Interfaces;
using BeYeuBookstore.Application.ViewModels;
using BeYeuBookstore.Data.Entities;
using BeYeuBookstore.Infrastructure.Interfaces;
using BeYeuBookstore.Utilities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeYeuBookstore.Application.Implementation
{
    public class AdvertiserService : IAdvertiserService
    {
        private IRepository<Advertiser, int> _advertiserRepository;
        private IUnitOfWork _unitOfWork;
        public AdvertiserService(IRepository<Advertiser, int> advertiserRepository, IUnitOfWork unitOfWork)
        {
            _advertiserRepository = advertiserRepository;
            _unitOfWork = unitOfWork;

        }

        public AdvertiserViewModel Add(AdvertiserViewModel AdvertiserViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<AdvertiserViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AdvertiserViewModel> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public PagedResult<AdvertiserViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public AdvertiserViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Update(AdvertiserViewModel AdvertiserViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
