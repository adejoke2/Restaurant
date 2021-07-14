using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models.ViewModel
{
    public class DetailVM
    {
        public DetailVM()
        {
            Product = new Product();
        }
        public Product Product { get; set; }

        public bool ExistsInCart { get; set; }
    }
}
