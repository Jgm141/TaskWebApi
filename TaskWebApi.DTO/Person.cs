using System.ComponentModel.DataAnnotations;

namespace TaskWebApi.DTO;

public class Person
{

    public int PersonId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Address { get; set; }= null!;
    public Gender Gender { get; set; }
    public string PersonalNumber { get; set; } = null!;
    public DateTime Birthday { get; set; }
    public string picture { get; set; } = null!;
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public City City { get; set; } = null!;
    public ICollection<PhoneNumber> PhoneNumber { get; set; } = null!;
    public ICollection<RelativePerson> Persons { get; set; } = null!;
    public ICollection<RelativePerson> Relatives { get; set; } = null!;
}
public enum Gender : byte
{
    Male = 0,
    Female = 1,
}
