namespace Aguhon.Domain.Entities;

public class CompendiumEntry
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int CreatureSpeciesId { get; set; }
    public CreatureSpecies Species { get; set; } = null!;

    public bool Seen { get; set; }
    public bool Caught { get; set; }

    public DateTime? FirstSeenAtUtc { get; set; }
    public DateTime? FirstCaughtAtUtc { get; set; }
    public int TimesCaught { get; set; }   // duplicates still count, e.g. catching a second Tikbalang
}