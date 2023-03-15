using System.Text.Json;

namespace MapsterDemo.Dtos;

public class AuthorInfoDto
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Category { get; set; }
    public Gender Gender { get; set; }
    public int? Age { get; set; }
    public List<string>? Posts { get; set; }
    public string? JobTitle { get; set; }
    public string? AddressStreetName { get; set; }

    public override string ToString() => JsonSerializer.Serialize(this);
}