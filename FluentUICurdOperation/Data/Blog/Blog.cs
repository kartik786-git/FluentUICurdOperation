﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentUICurdOperation.Data.Blog
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
