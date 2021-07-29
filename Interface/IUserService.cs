using BeebarhRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Interface
{
    public interface IUserService
    {
        //public void RegisterUser(int id, int userid, string useremail, string firstname, string lastname, string email, string password, string address, int phonenumber, string gender, string userType);

        public User LoginUser(string email, string password);
        public void RegisterUser(int id, string email, string name, string gender, string password, int userId, string userEmail, string firstName, string lastName, string address, int phoneNumber);
    }
}
