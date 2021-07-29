using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models
{
    public class Role:BaseEntity
    {
        //public const string AdminRole = "Admin";
        //public const string CustomerRole = "Customer";
        public string Name { get; set; }

        public List<User> User { get; set; }

    }
}
