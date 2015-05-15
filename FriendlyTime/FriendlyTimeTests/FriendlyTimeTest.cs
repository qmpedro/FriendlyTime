using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FriendlyTime;

namespace FriendlyTimeTests
{
    [TestClass]
    public class FriendlyTimeTest
    {
        [TestMethod]
        public void GetFriendlyTimeCorrectly_OneSecondAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddSeconds(-1));
            Assert.AreEqual("one second ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewSecondAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddSeconds(-10));
            Assert.AreEqual("10 seconds ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_OneMinuteAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddMinutes(-1));
            Assert.AreEqual("one minute ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewMinutesAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddMinutes(-10));
            Assert.AreEqual("10 minutes ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_OneHourAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddHours(-1));
            Assert.AreEqual("one hour ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewHoursAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddHours(-10));
            Assert.AreEqual("10 hours ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_Yesterday()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddDays(-1));
            Assert.AreEqual("yesterday", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewDaysAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddDays(-10));
            Assert.AreEqual("10 days ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_OneMonthAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddMonths(-1));
            Assert.AreEqual("one month ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewMonthsAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddMonths(-10));
            Assert.AreEqual("10 months ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_OneYearAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddYears(-1));
            Assert.AreEqual("one year ago", time);
        }

        [TestMethod]
        public void GetFriendlyTimeCorrectly_FewYearsAgo()
        {
            var time = new FriendlyTime.Program().GetFriendlyTime(DateTime.Now.AddYears(-10));
            Assert.AreEqual("10 years ago", time);
        }
    }
}
