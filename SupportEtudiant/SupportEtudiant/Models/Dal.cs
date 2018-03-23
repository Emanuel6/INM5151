using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupportEtudiant.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public List<User> GetAllUsers()
        {
            return bdd.User.ToList();
        }

        public void CreateUser(string firstName, string lastName)
        {
            User u = new User
            {
                FisrtName = firstName,
                LastName = lastName
            };
            bdd.User.Add(u);
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}