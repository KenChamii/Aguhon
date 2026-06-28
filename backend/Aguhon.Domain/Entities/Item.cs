namespace Aguhon.Domain.Entities;

/// <summary>
/// Describes a type of item (what it does). One row per item kind.
/// Quantity owned is tracked by PlayerItem, not here.
/// </summary>
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ItemCategory Category { get; set; }

    // For healing items: how much HP to restore (0 if not a healer).
    public int HealAmount { get; set; }

    // For capture items: the SiloBuhayTierMultiplier applied to CatchChance.
    // 1.0 = base Silo-Buhay; higher values = upgraded capture tiers.
    public float CaptureTierMultiplier { get; set; } = 1.0f;

    // For status-cure items: which condition this item removes (null = not a cure).
    public ConditionType? CuresCondition { get; set; }

    // For held items (Agimat/Anting-Anting): stat bonus against Lumiwalos-type.
    // Represented as a damage multiplier applied when the held creature attacks
    // a Lumiwalos-type opponent (1.0 = no bonus; 1.25 = +25% vs Lumiwalos).
    public float LumiwalosBonusMultiplier { get; set; } = 1.0f;
}