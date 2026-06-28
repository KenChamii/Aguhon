namespace Aguhon.Domain.Entities;


public class NpcTrainerCreature
{
    public int NpcTrainerId { get; set; }
    public NpcTrainer Trainer { get; set; } = null!;

    public int CreatureSpeciesId { get; set; }
    public CreatureSpecies Species { get; set; } = null!;

    public int Level { get; set; }
    public int TeamSlot { get; set; }   // ordering within the trainer's team
}