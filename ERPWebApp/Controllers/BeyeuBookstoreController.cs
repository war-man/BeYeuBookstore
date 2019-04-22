﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeYeuBookstore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BeYeuBookstore.Controllers
{
    public class BeyeuBookstoreController : Controller
    {
        IBookService _bookService;
        public BeyeuBookstoreController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        #region AJAX API
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _bookService.GetAll();
            return new OkObjectResult(model);
        }

        public IActionResult GetAll(int quantity)
        {
            var model = _bookService.GetAll(quantity);
            return model;
        }
        #endregion
    }
}