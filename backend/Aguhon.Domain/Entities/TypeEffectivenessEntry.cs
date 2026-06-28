using Aguhon.Domain.Enums;

namespace Aguhon.Domain.Entities;

public class TypeEffectivenessEntry
{
    public int Id { get; set; }
    public ElementalType AttackingType { get; set; }
    public ElementalType DefendingType { get; set; }
    public float Multiplier { get; set; }  // 2.0, 1.0, or 0.5
}