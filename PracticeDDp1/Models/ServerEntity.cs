using System.ComponentModel.DataAnnotations;

namespace PracticeDDp1.Models;

public class ServerEntity
{
    public ServerEntity()
    {
        var random=new Random();
       int israndom= random.Next(0,2);
        IsOnline = israndom == 0 ? false : true;
    }
    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    [Required]
    public string? ServerName { get; set; }
    [Required]
    public  string? LocatedCity { get; set; }

}
