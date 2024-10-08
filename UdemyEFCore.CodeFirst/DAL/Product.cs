﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DAL
{

    [Index(nameof(Name),nameof(Price),nameof(Url))]

    public class Product
    {
        public int Id { get; set; }

        public string Url { get; set; }
        public string Name { get; set; }
        //public string LastName { get; set; }

        [Precision(18,2)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }     
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }


    }
}
