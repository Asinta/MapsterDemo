namespace MapsterDemo.Entities;

public class Author
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Gender { get; set; }
    public Category? Category { get; set; }
    public int? Age { get; set; }
    public Job? Job { get; set; }
    public Address? Address { get; set; }
    public List<string>? Posts { get; set; }
}