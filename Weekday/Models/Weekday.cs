namespace Weekday.Models
{
  public class DayOfTheWeek
  {
    public string Date { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }

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
  }
}