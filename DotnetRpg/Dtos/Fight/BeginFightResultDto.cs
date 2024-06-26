namespace DotnetRpg.Dtos.Fight;

public class BeginFightResultDto
{
    public int Id { get; init; }
    public int PlayerCharacterId { get; init; }
    public required List<int> EnemyCharacterIds { get; init; }
}
