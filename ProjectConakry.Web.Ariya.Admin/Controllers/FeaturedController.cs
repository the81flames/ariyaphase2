﻿using ProjectConakry.BusinessServices;
using ProjectConakry.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectConakry.Web.Ariya.Admin.Controllers
{
    public class FeaturedController : Controller
    {
        private readonly BookManagementService _bookService;
        private readonly SongManagementService _songService;
        private readonly MovieManagementService _movieService;
        public FeaturedController(BookManagementService bookService, SongManagementService songService,
                                                                     MovieManagementService movieService)
        {
            _bookService = bookService;
            _songService = songService;
            _movieService = movieService;
        }

        [ConakryAdminAuthorize]
        public ActionResult Index()
        {
           return View();
        }

       
    }
}
