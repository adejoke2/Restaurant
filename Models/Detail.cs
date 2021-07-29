using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models
{
    public  class Detail
    {
        public User user { get; set; }

        public int userId { get; set; }
        public string userEmail { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
     
        public string Email { get; set; }

        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public string Gender { get; set; }
    }
}
