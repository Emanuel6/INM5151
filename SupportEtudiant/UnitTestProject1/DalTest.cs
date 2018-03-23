using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupportEtudiant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class DalTest
    {
        [TestInitialize]
        public void Init()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
        }

        [TestMethod]
        public void CreateUser_NewUser_GetAllUserWithNewUser()
        {
            using (IDal dal = new Dal())
            {
                dal.CreateUser("Emanuel", "Gonthier");
                List<User> users = dal.GetAllUsers();

                Assert.IsNotNull(users);
                Assert.AreEqual(1, users.Count);
                Assert.AreEqual("Emanuel", users.First().FisrtName);
                Assert.AreEqual("Gonthier", users.First().LastName);
            }
        }
    }
}
