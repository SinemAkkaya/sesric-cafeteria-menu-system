namespace api.Models;
public class MenuItem
{
    public int Id {get; set;}
    public DateOnly MenuDate {get; set;}
    public string? Soup {get; set;}
   public string MainCourse {get; set;} = string.Empty; //sting.Empty gave an empty text in the beginning so it wont cause error
   public string? SideDish {get; set;}
   public string? ExtraItem{get; set;}

}