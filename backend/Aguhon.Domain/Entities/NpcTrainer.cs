namespace Aguhon.Domain.Entities;

public class NpcTrainer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;   // "datu" | "trainer"
    public string MapId { get; set; } = string.Empty;
    public int GridX { get; set; }
    public int GridY { get; set; }
    public int BadgeIndex { get; set; }    // 0 = no badge; 1–4 = which badge they award

    public ICollection<NpcTrainerCreature> Creatures { get; set; } = new List<NpcTrainerCreature>();
}

