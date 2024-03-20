using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskWebApi.DTO;

public class RelativePerson
{
    public Person Person { get; set; } = null!;
    public Person RelativeTo { get; set; } = null!;

    [Key, Column(Order = 1)]
    public int PersonId { get; set; }

    [Key, Column(Order = 2)]
    public int RelativeToId { get; set; }
    public RelativePersonType RelativePersonType { get; set; }
}

public enum RelativePersonType : byte
{
    Colleague = 0,
    Relative = 1,
    FamilyMember = 2,
    Friend = 3,
}

