namespace Weekday.Models
{
  public class DayOfTheWeek
  {
    public string Date { get; set; }

    public DayOfTheWeek(string date)
    {
      Date = date;
    }
  }
}