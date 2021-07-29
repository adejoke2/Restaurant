using BeebarhRestaurant.Interface;
using BeebarhRestaurant.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace BeebarhRestaurant.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User LoginUser(string email, string password)
        {
            User user = userRepository.FindUserByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            string hashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(hashedPassword))
            {
                Console.WriteLine("User is found");
                return user;
            }

            return null;
        }
        public void RegisterUser(int id, string email, string name, string gender, string password, int userId, string userEmail, string firstName, string lastName, string address, int phoneNumber)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(password, saltString);

            User user = new User
            {
                Id = id,
                Email = email,
                HashSalt = saltString,
                PasswordHash = hashedPassword,
                Role = userRepository.FindRole("admin"),
            };

            userRepository.AddUser(user);

            Admin admin = new Admin
            {
                userId = user.Id,
                userEmail = userEmail,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Email = email,
                Address = address,
                PhoneNumber = phoneNumber,
               
            };

            //Manager manager = new Manager
            //{
            //    userId = user.Id,
            //    userEmail = userEmail,
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Email = email,
            //    Address = address,
            //    PhoneNumber = phoneNumber,
            //};


            //Customer customer = new Customer
            //{
            //    userId = user.Id,
            //    userEmail = userEmail,
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Email = email,
            //    Address = address,
            //    PhoneNumber = phoneNumber,
            //};
        }
        private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

            return hashed;
        }
    }
}
