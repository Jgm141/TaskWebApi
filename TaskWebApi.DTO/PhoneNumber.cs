namespace TaskWebApi.DTO;

public class PhoneNumber
{
    public int PhoneNumberId { get; set; }
    public string Number { get; set; } = null!;
    public PhoneNumberType PhoneNumberType { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public Person? Person { get; set; }
}
public enum PhoneNumberType
{
    Mobile = 0,
    Office = 1,
    Home = 2,
}
