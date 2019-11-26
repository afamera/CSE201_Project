using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesShowSearcher.Models.Tests
{
    [TestClass]
    public class showTest
    {
        Show show = new Show();

        [TestMethod]
        public void TestId()
        {
            show.ID = 1234;
            Assert.AreEqual(expected: 1234, actual: show.ID);
        }

        [TestMethod]
        public void TestShowName()
        {
            show.ShowName = "parks and rec";
            Assert.AreEqual(expected: "parks and rec", actual: show.ShowName);
        }

        [TestMethod]
        public void TestShowDescription()
        {
            show.ShowDescription = "I love Ben and Leslie";
            Assert.AreEqual(expected: "I love Ben and Leslie", actual: show.ShowDescription);
        }

        [TestMethod]
        public void TestShowRate()
        {
            show.ShowRate = 3;
            Assert.AreEqual(expected: 3, actual: show.ShowRate);
        }

        [TestMethod]
        public void TestNumOfSeasons()
        {
            show.NumOfSeasons = 7;
            Assert.AreEqual(expected: 7, actual: show.NumOfSeasons);
        }

        [TestMethod]
        public void TestYearShowBegan()
        {
            show.YearShowBegan = 2009;
            Assert.AreEqual(expected: 2009, actual: show.YearShowBegan);
        }

        [TestMethod]
        public void TestGenre()
        {
            show.Genre = "Comedy";
            Assert.AreEqual(expected: "Comedy", actual: show.Genre);
        }

        [TestMethod]
        public void TestNetwork()
        {
            show.OriginalNetwork = "NBC";
            Assert.AreEqual(expected: "NBC", actual: show.OriginalNetwork);
        }

        [TestMethod]
        public void TestnumOfLike()
        {
            show.NumOfLike = 0;
            Assert.AreEqual(expected: "0", actual: show.OriginalNetwork);
        }

        [TestMethod]
        public void TestnumOfDisLike()
        {
            show.NumOfDislike = 0;
            Assert.AreEqual(expected: "0", actual: show.OriginalNetwork);
        }

        [TestMethod]
        public void TestWiki()
        {
            show.WikiLink = "NULL";
            Assert.AreEqual(expected: "NULL", actual: show.OriginalNetwork);
        }
    }
}