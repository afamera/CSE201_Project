using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesShowSearcher.Models;
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
        public void testShowName()
        {
            show.ShowName = "parks and rec";
            Assert.AreEqual(expected: "parks and rec", actual: show.ShowName);
        }

        [TestMethod]
        public void testId()
        {
            show.ID = 1234;
            Assert.AreEqual(expected: 1234, actual: show.ID);
        }

        [TestMethod]
        public void testShowDescription()
        {
            show.ShowDescription = "I love Ben and Leslie";
            Assert.AreEqual(expected: "I love Ben and Leslie", actual: show.ShowDescription);
        }

        [TestMethod]
        public void testShowRate()
        {
            show.ShowRate = 3;
            Assert.AreEqual(expected: 3, actual: show.ShowRate);
        }

        [TestMethod]
        public void testNumeOfSeasons()
        {
            show.NumOfSeasons = 7;
            Assert.AreEqual(expected: 7, actual: show.NumOfSeasons);
        }

        [TestMethod]
        public void testYearShowBegan()
        {
            show.YearShowBegan = 2009;
            Assert.AreEqual(expected: 2009, actual: show.YearShowBegan);
        }

        [TestMethod]
        public void testGenre()
        {
            show.Genre = "Comedy";
            Assert.AreEqual(expected: "Comedy", actual: show.Genre);
        }

        [TestMethod]
        public void testNetwork()
        {
            show.OriginalNetwork = "NBC";
            Assert.AreEqual(expected: "NBC", actual: show.OriginalNetwork);
        }

        [TestMethod]
        public void TestnumOfLike()
        {
            show.numOfLike = "0";
            Assert.AreEqual(expected: "0", actual: show.OriginalNetwork);
        }

        [TestMethod]
        public void TestnumOfDisLike()
        {
            show.numOfDislike = "0";
            Assert.AreEqual(expected: "0", actual: show.OriginalNetwork);
        }
    }
}

