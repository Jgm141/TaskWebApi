namespace TaskWebApi.DTO;

public class City
{
    public int CityId { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public ICollection<Person>? Person { get; set; }
}
