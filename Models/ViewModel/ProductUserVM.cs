﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models.ViewModel
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            ProductList = new List<Product>();
        }
        //public ApplicationUser ApplicationUser { get; set; }

        public IEnumerable<Product> ProductList { get; set; }
    }
}
