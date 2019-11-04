using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesShowSearcher.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesShowSearcher.Models.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void addToFavoritesTest()
        {
            var favourite = new List<string>();
            Account account = new Account();
            account.addToFavorites("abc");
            Assert.IsNotNull(favourite);
        }
       

        [TestMethod()]
        public void removeFromFavoritesTest()
        {
            var favourite = new List<string>();
            Account account = new Account();
            account.addToFavorites("abc");
            Assert.IsNotNull(favourite);
            account.removeFromFavorites("abc");
            Assert.IsNull(favourite);
        }

        [TestMethod()]
        public void likeShowTest()
        {
            int like = 0;
            Account account = new Account();
            account.likeShow("abc");
            Assert.AreEqual(1, like);
            
        }

        [TestMethod()]
        public void dislikeShowTest()
        {
            int dislike = 0;
            Account account = new Account();
            account.dislikeShow("abc");
            Assert.AreEqual(1, dislike);
        }

        [TestMethod()]
        public void addShowInfoTest()
        {
            string showInfo;
            Account account = new Account();
            account.addShowInfo("abc");
            Assert.AreEqual("abc", showInfo);
        }

        [TestMethod()]
        public void adeleteShowInfoTest()
        {
            string showInfo;
            Account account = new Account();
            account.addShowInfo("abc");
            Assert.IsNotNull(showInfo);
            account.adeleteShowInfo("abc");
            Assert.IsNull(showInfo);
        }

        [TestMethod()]
        public void editShowInfoTest()
        {
            string showInfo;
            Account account = new Account();
            account.editShowInfo("abc");
            Assert.AreNotEqual("abc", showInfo);
            
        }
    }
}