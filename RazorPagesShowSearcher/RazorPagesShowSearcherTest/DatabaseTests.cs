using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorPagesShowSearcherTest
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void TestDatabaseFileCreate()
        {
            File.Delete("database.db");
            var db = new DatabaseTests();
            db.Load();
            Assert.IsTrue(File.Exists("database.db"));
            File.Delete("database.db");
        }
        [TestMethod]
        public void TestAddRecord()
        {
            File.Delete("database.db");
            var db = new Database();
            db.Load();
            var s = new Show
            {
                Country = "country1",
                Id = "1",
                Poster = "poster1",
                Success = true,
                Title = "title1",
                Year = "2012"
            };
            db.AddToFavorites(s);
            db.Dispose();

            var db2 = new Database();
            db2.Load();
            var favs = db2.GetAllFavorites().ToArray();
            db2.Dispose();
            Assert.AreEqual(favs.Length, 1);
            Assert.AreEqual(favs[0].Title, s.Title);
            Assert.AreEqual(favs[0].Country, s.Country);
            Assert.AreEqual(favs[0].Id, s.Id);
            Assert.AreEqual(favs[0].Poster, s.Poster);
            Assert.AreEqual(favs[0].Success, s.Success);
            Assert.AreEqual(favs[0].Year, s.Year);
            File.Delete("database.db");
        }

        [TestMethod]
        public void TestDeleteRecord()
        {
            File.Delete("database.db");
            var db = new Database();
            db.Load();
            var s = new Show
            {
                Country = "country1",
                Id = "1",
                Poster = "poster1",
                Success = true,
                Title = "title1",
                Year = "2012"
            };
            db.AddToFavorites(s);
            db.Dispose();

            var db2 = new Database();
            db2.Load();
            db2.RemoveFromFavorites(s.Id);
            db2.Dispose();

            var db3 = new Database();
            db3.Load();
            var favs = db3.GetAllFavorites().ToArray();
            db3.Dispose();
            Assert.AreEqual(favs.Length, 0);
            File.Delete("database.db");
        }

        [TestMethod]
        public void TestSignUp()
        {
            File.Delete("database.db");
            var db = new Database();
            db.Load();
            var u = new User
            {
                username = "user1",
                password = "123456",
                
            };
            db.AddToUsers(u);
            db.Dispose();

            var db2 = new Database();
            db2.Load();
            var users = db2.GetAllUsers().ToArray();
            db2.Dispose();
            Assert.AreEqual(users.Length, 1);
            Assert.AreEqual(users[0].username, u.username);
            Assert.AreEqual(users[0].password, u.password);
            File.Delete("database.db");
        }
    }
}
