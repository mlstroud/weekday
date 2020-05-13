namespace Weekday.Models
{
  public class DayOfTheWeek
  {
    public string Date { get; set; }
    public int Month { get; set; }

    public DayOfTheWeek(string date)
    {
      Date = date;
    }

    public void ParseDate()
    {
      string[] dateData = Date.Split("/");

      Month = int.Parse(dateData[0]);
    }
  }
}