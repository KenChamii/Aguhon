namespace Aguhon.Domain.Entities;

public class PlayerItem
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int ItemId { get; set; }
    public Item Item { get; set; } = null!;

    public int Quantity { get; set; }
}