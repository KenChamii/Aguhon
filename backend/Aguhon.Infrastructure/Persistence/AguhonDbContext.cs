using Aguhon.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aguhon.Infrastructure.Persistence;

public class AguhonDbContext : DbContext
{
    public AguhonDbContext(DbContextOptions<AguhonDbContext> options) : base(options) { }

    public DbSet<CreatureSpecies> CreatureSpecies => Set<CreatureSpecies>();
    public DbSet<Move> Moves => Set<Move>();
    public DbSet<CreatureMove> CreatureMoves => Set<CreatureMove>();
    public DbSet<Player> Players => Set<Player>();
    public DbSet<PlayerCreature> PlayerCreatures => Set<PlayerCreature>();
    public DbSet<CompendiumEntry> CompendiumEntries => Set<CompendiumEntry>();
    public DbSet<TypeEffectivenessEntry> TypeEffectivenessEntries => Set<TypeEffectivenessEntry>();
    public DbSet<NpcTrainer> NpcTrainers => Set<NpcTrainer>();
    public DbSet<NpcTrainerCreature> NpcTrainerCreatures => Set<NpcTrainerCreature>();
    public DbSet<DefeatedTrainer> DefeatedTrainers => Set<DefeatedTrainer>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<PlayerItem> PlayerItems => Set<PlayerItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite primary key for CreatureMove (join table)
        modelBuilder.Entity<CreatureMove>()
            .HasKey(cm => new { cm.CreatureSpeciesId, cm.MoveId });

        // Composite primary key for CompendiumEntry
        modelBuilder.Entity<CompendiumEntry>()
            .HasKey(ce => new { ce.PlayerId, ce.CreatureSpeciesId });

        // Composite primary key for NpcTrainerCreature
        modelBuilder.Entity<NpcTrainerCreature>()
            .HasKey(ntc => new { ntc.NpcTrainerId, ntc.CreatureSpeciesId, ntc.TeamSlot });

        // Composite primary key for DefeatedTrainer
        modelBuilder.Entity<DefeatedTrainer>()
            .HasKey(dt => new { dt.PlayerId, dt.NpcTrainerId });

        // Composite primary key for PlayerItem (inventory)
        modelBuilder.Entity<PlayerItem>()
            .HasKey(pi => new { pi.PlayerId, pi.ItemId });

        // Item enum storage as string
        modelBuilder.Entity<Item>()
            .Property(i => i.Category).HasConversion<string>();
        modelBuilder.Entity<Item>()
            .Property(i => i.CuresCondition).HasConversion<string>();

        // Enum storage as string (readable in DB, stable across enum reordering)
        modelBuilder.Entity<CreatureSpecies>()
            .Property(c => c.PrimaryType).HasConversion<string>();
        modelBuilder.Entity<CreatureSpecies>()
            .Property(c => c.SecondaryType).HasConversion<string>();
        modelBuilder.Entity<Move>()
            .Property(m => m.Type).HasConversion<string>();
        modelBuilder.Entity<Move>()
            .Property(m => m.Category).HasConversion<string>();
        modelBuilder.Entity<Move>()
            .Property(m => m.InflictsCondition).HasConversion<string>();
        modelBuilder.Entity<Move>()
            .Property(m => m.StatStageTarget).HasConversion<string>();
        modelBuilder.Entity<TypeEffectivenessEntry>()
            .Property(t => t.AttackingType).HasConversion<string>();
        modelBuilder.Entity<TypeEffectivenessEntry>()
            .Property(t => t.DefendingType).HasConversion<string>();

        // Indexes that matter once there's real query volume:
        // compendium lookups are always "give me this player's full book," and
        // wild-encounter rolls filter species by map/zone — both deserve an index
        // rather than a full scan once seed data grows past a handful of rows.
        modelBuilder.Entity<CompendiumEntry>()
            .HasIndex(ce => ce.PlayerId);
        modelBuilder.Entity<NpcTrainer>()
            .HasIndex(t => t.MapId);
    }
}