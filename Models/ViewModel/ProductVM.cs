using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models.ViewModel
{
    public class ProductVM : Product
    {
        public int ProductId { get; set; }
        public Product product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
