﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.udemy.csharp.projeto.mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace com.udemy.csharp.projeto.mvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

    }
}