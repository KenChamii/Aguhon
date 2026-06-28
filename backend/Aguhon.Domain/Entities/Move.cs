using Aguhon.Domain.Enums;

namespace Aguhon.Domain.Entities;

public class Move
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ElementalType Type { get; set; }
    public MoveCategory Category { get; set; }

    public int Power { get; set; }           // 0 for status moves
    public float BaseAccuracy { get; set; }  // 0.0–1.0
    public int ManaCost { get; set; }

    // Condition effect (nullable — only set on moves that inflict a named condition)
    public ConditionType? InflictsCondition { get; set; }
    public float ConditionChance { get; set; }  // 0.0–1.0

    // Stat-stage effect (nullable — only set on moves that buff/debuff a stat).
    // A move can carry BOTH a condition and a stat-stage effect (e.g. a move that
    // lowers Accuracy AND has a chance to inflict Bulag), or just one, or neither.
    public StatType? StatStageTarget { get; set; }
    public int StatStageDelta { get; set; }            // e.g. +1, -2; clamped to [-6, +6] at apply time
    public bool StatStageAppliesToSelf { get; set; }    // true = buff caster (e.g. Pagpala-style self-buff); false = debuff target

    // Navigation
    public ICollection<CreatureMove> CreatureMoves { get; set; } = new List<CreatureMove>();
}