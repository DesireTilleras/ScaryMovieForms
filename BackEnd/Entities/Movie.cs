﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
     public class Movie
    {
        public int Id { get; set; }       
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FilePath { get; set; }

    }
}
