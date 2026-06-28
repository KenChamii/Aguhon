namespace Aguhon.Domain.Entities;

public class DefeatedTrainer
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int NpcTrainerId { get; set; }
    public NpcTrainer Trainer { get; set; } = null!;

    public DateTime DefeatedAtUtc { get; set; }
}