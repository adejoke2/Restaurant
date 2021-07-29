using BeebarhRestaurant.Context;
using BeebarhRestaurant.Interface;
using BeebarhRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User AddUser(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public Role FindRole(string name)
        {
            return _dbContext.Role.FirstOrDefault(r => r.Name.Equals(name));
        }

        public User FindUserByEmail(string email)
        {
            return _dbContext.User.FirstOrDefault(u => u.Email.Equals(email));
        }
    }
}
