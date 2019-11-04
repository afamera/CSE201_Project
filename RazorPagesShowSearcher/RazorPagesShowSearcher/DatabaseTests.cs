using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorPagesShowSearcher
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
                ShowName = "showName",
                ShowDescription = "abc",
                ShowRate = "1",
                NumOfSeasons = "10",
                yearShowBegan = "2012",
                Genre = "a",
                OriginalNetwork = "a",
                numOfLike = "0",
                numOfDisLike = "0"
            };
            db.AddToFavorites(s);
            db.Dispose();

            var db2 = new Database();
            db2.Load();
            var favs = db2.GetAllFavorites().ToArray();
            db2.Dispose();
            Assert.AreEqual(favs.Length, 1);
            Assert.AreEqual(favs[0].ShowName, s.ShowName);
            Assert.AreEqual(favs[0].ShowDescription, s.ShowDescription);
            Assert.AreEqual(favs[0].ShowRate, s.ShowRate);
            Assert.AreEqual(favs[0].NumberOfSeasons, s.NumberOfSeasons);
            Assert.AreEqual(favs[0].yearShowBegan, s.yearShowBegan);
            Assert.AreEqual(favs[0].Genre, s.Genre);
            Assert.AreEqual(favs[0].numOfLike, s.numOfLike);
            Assert.AreEqual(favs[0].originalNetworkr, s.OriginalNetwork);
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
                ShowName = "showName",
                ShowDescription = "abc",
                ShowRate = "1",
                NumOfSeasons = "10",
                yearShowBegan = "2012",
                Genre = "a",
                OriginalNetwork = "a",
                numOfLike = "0",
                numOfDisLike = "0"


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
                userName = "user1",
                password = "123456",

            };
            db.AddToUsers(u);
            db.Dispose();

            var db2 = new Database();
            db2.Load();
            var users = db2.GetAllUsers().ToArray();
            db2.Dispose();
            Assert.AreEqual(users.Length, 1);
            Assert.AreEqual(users[0].username, u.userName);
            Assert.AreEqual(users[0].password, u.password);
            File.Delete("database.db");
        }

        [TestMethod]
        public void TestAdminDelete()
        {
            File.Delete("database.db");
            var db = new Database();
            db.Load();
            var s = new Show
            {
                ShowName = "showName",
                ShowDescription = "abc",
                ShowRate = "1",
                NumOfSeasons = "10",
                yearShowBegan = "2012",
                Genre = "a",
                numOfLike = "0",
                OriginalNetwork = "a",
                numOfDisLike = "0"
            };
            db.Dispose();
            var admin = new Admin();
            var shows = db.GetAllShows().ToArray();
            admin.deleteShowInfo();
            Assert.AreEqual(shows[0].Length, 0);
            Assert.IsNull(shows[0].ShowName);
            Assert.IsNull(shows[0].ShowDescription);
            Assert.IsNull(shows[0].ShowRate);
            Assert.IsNull(shows[0].NumberOfSeasons);
            Assert.IsNull(shows[0].yearShowBegan);
            Assert.IsNull(shows[0].Genre);
            Assert.IsNull(shows[0].numOfLike);
            Assert.IsNull(shows[0].OriginalNetwork);
            Assert.IsNull(shows[0].numOfDisLike);
            File.Delete("database.db");
        }

        [TestMethod]
        public void TestAdminEdit()
        {
            File.Delete("database.db");
            var db = new Database();
            db.Load();
            var s = new Show
            {
                ShowName = "showName",
                ShowDescription = "abc",
                ShowRate = "1",
                NumOfSeasons = "10",
                yearShowBegan = "2012",
                Genre = "a",
                numOfLike = "0",
                OriginalNetwork = "a",
                numOfDisLike = "0"
            };
            db.Dispose();
            var admin = new Admin();
            var shows = db.GetAllShows().ToArray();
            admin.editShowInfo(shows);
            Assert.AreEqual(shows[0].Length, 1);
            Assert.AreNotEqual(shows[0].ShowName, s.ShowName);
            Assert.AreNotEqual(shows[0].ShowDescription, s.ShowDescription);
            Assert.AreNotEqual(shows[0].ShowRate, s.ShowRate);
            Assert.AreNotEqual(shows[0].NumberOfSeasons, s.NumberOfSeasons);
            Assert.AreNotEqual(shows[0].yearShowBegan, s.yearShowBegan);
            Assert.AreNotEqual(shows[0].Genre, s.Genre);
            Assert.AreNotEqual(shows[0].numOfLike, s.numOfLike);
            Assert.AreNotEqual(shows[0].OriginalNetwork, s.OriginalNetwork);
            Assert.AreNotEqual(shows[0].numOfDisLike, s.numOfDisLike);
            File.Delete("database.db");
        }
    }

}
