﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    public class SlideDto
    {       
        public string ImageUrl { get; set; }
        public string ImageBase64 { get; set; }
        public int Order { get; set; }
    }
}
