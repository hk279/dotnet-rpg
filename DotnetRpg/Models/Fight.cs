namespace DotnetRpg.Models;

public class Fight
{
    public int Id { get; set; }
    public List<Character> Characters { get; set; } = null!;
}

