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

    [TestMethod]
    public void ParseDate_ExtractsMonthFromDate_Month()
    {
      string date = "5/13/2020";
      int dateMonth = 5;
      DayOfTheWeek day = new DayOfTheWeek(date);

      day.ParseDate();
      int result = day.Month;

      Assert.AreEqual(result, dateMonth);
    }

    [TestMethod]
    public void ParseDate_ExtractsDayFromDate_Day()
    {
      string date = "5/13/2020";
      int dateDay = 13;
      DayOfTheWeek day = new DayOfTheWeek(date);

      day.ParseDate();
      int result = day.Day;

      Assert.AreEqual(result, dateDay);
    }

    [TestMethod]
    public void ParseDate_ExtractsYearFromDate_Year()
    {
      string date = "5/13/2020";
      int dateYear = 2020;
      DayOfTheWeek day = new DayOfTheWeek(date);

      day.ParseDate();
      int result = day.Year;

      Assert.AreEqual(result, dateYear);
    }
  }
}