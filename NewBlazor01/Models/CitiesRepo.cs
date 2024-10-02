namespace NewBlazor01.Models;

public class CitiesRepo
{
    public static List<string> Cities = new List<string>()
    {
        "dhaka","CTG","RAJ","BARI","MYN","CUM"
    };
    public static List<string> GetCities() => Cities;
}
