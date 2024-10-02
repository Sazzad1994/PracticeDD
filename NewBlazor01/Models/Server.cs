using System.ComponentModel.DataAnnotations;

namespace NewBlazor01.Models;

public class Server
{
    public Server()
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
