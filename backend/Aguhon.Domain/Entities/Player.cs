namespace Aguhon.Domain.Entities;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Level and XP
    public int Level { get; set; } = 1;
    public int CurrentXP { get; set; }
    public int XPToNextLevel { get; set; } = 100;

    // Allocatable stat points
    public int AvailableStatPoints { get; set; }
    public int Lakas { get; set; }      // Strength — physical damage
    public int Bilis { get; set; }      // Speed/Dex — turn order, accuracy
    public int Diwa { get; set; }       // Intelligence — special damage, mana
    public int Tibay { get; set; }      // Vitality — HP
    public int Loob { get; set; }       // Willpower — mana regen, status resist

    // Progress
    public int BadgesEarned { get; set; }
    public string CurrentMapId { get; set; } = "village";
    public int PlayerGridX { get; set; }
    public int PlayerGridY { get; set; }

    // Navigation
    public ICollection<PlayerCreature> Roster { get; set; } = new List<PlayerCreature>();
    public ICollection<CompendiumEntry> Compendium { get; set; } = new List<CompendiumEntry>();
    public ICollection<DefeatedTrainer> DefeatedTrainers { get; set; } = new List<DefeatedTrainer>();

    public ICollection<PlayerItem> Inventory { get; set; } = new List<PlayerItem>();
}