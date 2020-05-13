using System.Collections.Generic;

namespace Weekday.Models
{
  public class DayOfTheWeek
  {
    public string Date { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }
    private static string[] _days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    private static Dictionary<int, int> _monthData = new Dictionary<int, int>
      {
        {1, 1},
        {3, 5},
        {5, 7},
        {7, 9},
        {9, 3},
        {11, 12},
        {2, 12},
        {4, 2},
        {6, 4},
        {8, 6},
        {10, 8},
        {12, 10}
      };

    public DayOfTheWeek(string date)
    {
      Date = date;
    }

    public void ParseDate()
    {
      string[] dateData = Date.Split("/");

      Month = int.Parse(dateData[0]);
      Day = int.Parse(dateData[1]);
      Year = int.Parse(dateData[2]);
    }

    public string GetDayOfTheWeek()
    {
      int yearLastDigit = Year % 10;
      int yearSecondLastDigit = (Year / 10) % 10;
      int yearFirstTwoDigits = Year / 100;
      bool isLeapYear = false;
      int index = (Day - _monthData[Month] + yearLastDigit - yearSecondLastDigit + ((yearLastDigit / 4) - (yearSecondLastDigit / 2)) - 2 * (yearFirstTwoDigits % 4)) % 7;


      if (Year % 400 == 0)
      {
        isLeapYear = true;
      }
      else if (Year % 100 == 0)
      {
        isLeapYear = false;
      }
      else
      {
        isLeapYear = (Year % 4 == 0) ? true : false;
      }

      if (isLeapYear)
      {
        index--;
      }

      return _days[index];
    }
  }
}