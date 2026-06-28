using Aguhon.Domain.Enums;

namespace Aguhon.Domain.Entities;

public class CreatureSpecies
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Compendium / "Pokedex" flavor text — separate from Description, which is
    // the short blurb shown on the move/encounter screen. LoreText is the longer
    // mythological background shown on the Compendium detail page (Feature 7).
    public string LoreText { get; set; } = string.Empty;

    // Typing
    public ElementalType PrimaryType { get; set; }
    public ElementalType? SecondaryType { get; set; }

    // Base stats (fixed per species, not player-allocatable)
    public int BaseHP { get; set; }
    public int BaseAttack { get; set; }
    public int BaseSpecialAttack { get; set; }
    public int BaseDefense { get; set; }
    public int BaseSpecialDefense { get; set; }
    public int BaseSpeed { get; set; }
    public int BaseMana { get; set; }

    // Wild-encounter level band — replaces v1's hardcoded "level = 5".
    // Encounter zones (Feature 12) pick a level within this band, optionally
    // shifted by the player's own level so early routes don't out-level the player.
    public int MinEncounterLevel { get; set; } = 2;
    public int MaxEncounterLevel { get; set; } = 6;

    // Capture
    public float BaseCaptureRate { get; set; }   // 0.0 = uncatchable (Bakunawa)
    public bool IsStarter { get; set; }
    public bool IsMythic { get; set; }
    public bool IsFinalBoss { get; set; }

    // Sprite path (relative URL, resolved by frontend)
    public string SpriteUrl { get; set; } = string.Empty;

    // Navigation
    public ICollection<CreatureMove> CreatureMoves { get; set; } = new List<CreatureMove>();
}