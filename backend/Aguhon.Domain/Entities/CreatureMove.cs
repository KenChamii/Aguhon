namespace Aguhon.Domain.Entities;

public class CreatureMove
{
    public int CreatureSpeciesId { get; set; }
    public CreatureSpecies CreatureSpecies { get; set; } = null!;

    public int MoveId { get; set; }
    public Move Move { get; set; } = null!;

    public int LearnAtLevel { get; set; }
}