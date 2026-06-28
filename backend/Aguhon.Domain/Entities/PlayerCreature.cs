using System.Numerics;

namespace Aguhon.Domain.Entities;

public class PlayerCreature
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int CreatureSpeciesId { get; set; }
    public CreatureSpecies Species { get; set; } = null!;

    public int Level { get; set; } = 1;
    public int CurrentHP { get; set; }
    public int CurrentMana { get; set; }
    public string Nickname { get; set; } = string.Empty;

    // Roster ordering / active-team slot. Needed once trainer battles (Feature 15)
    // can knock out the player's active creature and the player must switch —
    // v1 had no way to express "which of my creatures is active right now."
    public int RosterSlot { get; set; }
    public bool IsActive { get; set; }
}