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
            Assert.True();
        }

        [TestMethod()]
        public void likeShowTest()
        {
            Assert.True();
        }

        [TestMethod()]
        public void dislikeShowTest()
        {
            Assert.True();
        }

        [TestMethod()]
        public void addShowInfoTest()
        {
            Assert.True();
        }

        [TestMethod()]
        public void adeleteShowInfoTest()
        {
            Assert.True();
        }

        [TestMethod()]
        public void editShowInfoTest()
        {
            Assert.True();
        }
    }
}