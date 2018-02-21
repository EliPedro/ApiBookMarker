﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiBookMarker.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet, Authorize]
        public IEnumerable<Book> Get()
        {
             var currentUser = HttpContext.User;
             var resultBookList = new Book[] {
             new Book { Author = "Ray Bradbury",Title = "Fahrenheit 451" },
             new Book { Author = "Gabriel García Márquez", Title = "One Hundred years of Solitude" },
             new Book { Author = "George Orwell", Title = "1984" },
             new Book { Author = "Anais Nin", Title = "Delta of Venus" }
           };

            return resultBookList;
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public bool AgeRestriction { get; set; }
    }
}