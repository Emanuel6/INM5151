using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupportEtudiant.Models
{
    public interface IDal : IDisposable
    {
        void CreateUser(string firstName, string lastName);
        List<User> GetAllUsers();
    }
}