﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspMvc.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int FacultyId { get; set; }
    }
}