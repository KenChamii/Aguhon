namespace Aguhon.Domain.Enums;

/// <summary>
/// Which runtime battle stat a status move's stage-change applies to.
/// Stage changes are separate from ConditionType — a condition is a named,
/// discrete status (Lason, Lumpo, ...); a stat stage is a numeric +/- shift
/// to one of these five, clamped to [-6, +6] per the classic stage model.
/// </summary>
public enum StatType
{
    Attack,
    SpecialAttack,
    Defense,
    SpecialDefense,
    Speed,
    Accuracy
}