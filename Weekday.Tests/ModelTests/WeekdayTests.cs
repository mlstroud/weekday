using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weekday.Models;

namespace Weekday.Tests
{
  [TestClass]
  public class DayOfTheWeekTests
  {
    [TestMethod]
    public void Constructor_StoresDate_Date()
    {
      string date = "5/13/2020";
      DayOfTheWeek day = new DayOfTheWeek(date);

      string result = day.Date;

      Assert.AreEqual(result, date);
    }
  }
}