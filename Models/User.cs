using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models
{
    public class User : BaseEntity
    {
        public Role Role { get; set; }
        public int RoleId { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string HashSalt { get; set; }

        public Admin Admin { get; set; }

        public Customer Customer { get; set; }
    }
}
