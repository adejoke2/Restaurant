﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models
{
    public class ShoppingCart
    {   
        [Required]
        public int ProductId { get; set; }
    }
}
