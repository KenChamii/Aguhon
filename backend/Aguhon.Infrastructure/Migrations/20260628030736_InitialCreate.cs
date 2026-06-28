using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Aguhon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreatureSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    LoreText = table.Column<string>(type: "text", nullable: false),
                    PrimaryType = table.Column<string>(type: "text", nullable: false),
                    SecondaryType = table.Column<string>(type: "text", nullable: true),
                    BaseHP = table.Column<int>(type: "integer", nullable: false),
                    BaseAttack = table.Column<int>(type: "integer", nullable: false),
                    BaseSpecialAttack = table.Column<int>(type: "integer", nullable: false),
                    BaseDefense = table.Column<int>(type: "integer", nullable: false),
                    BaseSpecialDefense = table.Column<int>(type: "integer", nullable: false),
                    BaseSpeed = table.Column<int>(type: "integer", nullable: false),
                    BaseMana = table.Column<int>(type: "integer", nullable: false),
                    MinEncounterLevel = table.Column<int>(type: "integer", nullable: false),
                    MaxEncounterLevel = table.Column<int>(type: "integer", nullable: false),
                    BaseCaptureRate = table.Column<float>(type: "real", nullable: false),
                    IsStarter = table.Column<bool>(type: "boolean", nullable: false),
                    IsMythic = table.Column<bool>(type: "boolean", nullable: false),
                    IsFinalBoss = table.Column<bool>(type: "boolean", nullable: false),
                    SpriteUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    HealAmount = table.Column<int>(type: "integer", nullable: false),
                    CaptureTierMultiplier = table.Column<float>(type: "real", nullable: false),
                    CuresCondition = table.Column<string>(type: "text", nullable: true),
                    LumiwalosBonusMultiplier = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    BaseAccuracy = table.Column<float>(type: "real", nullable: false),
                    ManaCost = table.Column<int>(type: "integer", nullable: false),
                    InflictsCondition = table.Column<string>(type: "text", nullable: true),
                    ConditionChance = table.Column<float>(type: "real", nullable: false),
                    StatStageTarget = table.Column<string>(type: "text", nullable: true),
                    StatStageDelta = table.Column<int>(type: "integer", nullable: false),
                    StatStageAppliesToSelf = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NpcTrainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    MapId = table.Column<string>(type: "text", nullable: false),
                    GridX = table.Column<int>(type: "integer", nullable: false),
                    GridY = table.Column<int>(type: "integer", nullable: false),
                    BadgeIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcTrainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    CurrentXP = table.Column<int>(type: "integer", nullable: false),
                    XPToNextLevel = table.Column<int>(type: "integer", nullable: false),
                    AvailableStatPoints = table.Column<int>(type: "integer", nullable: false),
                    Lakas = table.Column<int>(type: "integer", nullable: false),
                    Bilis = table.Column<int>(type: "integer", nullable: false),
                    Diwa = table.Column<int>(type: "integer", nullable: false),
                    Tibay = table.Column<int>(type: "integer", nullable: false),
                    Loob = table.Column<int>(type: "integer", nullable: false),
                    BadgesEarned = table.Column<int>(type: "integer", nullable: false),
                    CurrentMapId = table.Column<string>(type: "text", nullable: false),
                    PlayerGridX = table.Column<int>(type: "integer", nullable: false),
                    PlayerGridY = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeEffectivenessEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttackingType = table.Column<string>(type: "text", nullable: false),
                    DefendingType = table.Column<string>(type: "text", nullable: false),
                    Multiplier = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEffectivenessEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatureMoves",
                columns: table => new
                {
                    CreatureSpeciesId = table.Column<int>(type: "integer", nullable: false),
                    MoveId = table.Column<int>(type: "integer", nullable: false),
                    LearnAtLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureMoves", x => new { x.CreatureSpeciesId, x.MoveId });
                    table.ForeignKey(
                        name: "FK_CreatureMoves_CreatureSpecies_CreatureSpeciesId",
                        column: x => x.CreatureSpeciesId,
                        principalTable: "CreatureSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureMoves_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcTrainerCreatures",
                columns: table => new
                {
                    NpcTrainerId = table.Column<int>(type: "integer", nullable: false),
                    CreatureSpeciesId = table.Column<int>(type: "integer", nullable: false),
                    TeamSlot = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcTrainerCreatures", x => new { x.NpcTrainerId, x.CreatureSpeciesId, x.TeamSlot });
                    table.ForeignKey(
                        name: "FK_NpcTrainerCreatures_CreatureSpecies_CreatureSpeciesId",
                        column: x => x.CreatureSpeciesId,
                        principalTable: "CreatureSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NpcTrainerCreatures_NpcTrainers_NpcTrainerId",
                        column: x => x.NpcTrainerId,
                        principalTable: "NpcTrainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompendiumEntries",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    CreatureSpeciesId = table.Column<int>(type: "integer", nullable: false),
                    Seen = table.Column<bool>(type: "boolean", nullable: false),
                    Caught = table.Column<bool>(type: "boolean", nullable: false),
                    FirstSeenAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FirstCaughtAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TimesCaught = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompendiumEntries", x => new { x.PlayerId, x.CreatureSpeciesId });
                    table.ForeignKey(
                        name: "FK_CompendiumEntries_CreatureSpecies_CreatureSpeciesId",
                        column: x => x.CreatureSpeciesId,
                        principalTable: "CreatureSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompendiumEntries_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefeatedTrainers",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    NpcTrainerId = table.Column<int>(type: "integer", nullable: false),
                    DefeatedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefeatedTrainers", x => new { x.PlayerId, x.NpcTrainerId });
                    table.ForeignKey(
                        name: "FK_DefeatedTrainers_NpcTrainers_NpcTrainerId",
                        column: x => x.NpcTrainerId,
                        principalTable: "NpcTrainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefeatedTrainers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCreatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    CreatureSpeciesId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    CurrentHP = table.Column<int>(type: "integer", nullable: false),
                    CurrentMana = table.Column<int>(type: "integer", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    RosterSlot = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCreatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerCreatures_CreatureSpecies_CreatureSpeciesId",
                        column: x => x.CreatureSpeciesId,
                        principalTable: "CreatureSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCreatures_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItems",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItems", x => new { x.PlayerId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_PlayerItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItems_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompendiumEntries_CreatureSpeciesId",
                table: "CompendiumEntries",
                column: "CreatureSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompendiumEntries_PlayerId",
                table: "CompendiumEntries",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureMoves_MoveId",
                table: "CreatureMoves",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_DefeatedTrainers_NpcTrainerId",
                table: "DefeatedTrainers",
                column: "NpcTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcTrainerCreatures_CreatureSpeciesId",
                table: "NpcTrainerCreatures",
                column: "CreatureSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_NpcTrainers_MapId",
                table: "NpcTrainers",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCreatures_CreatureSpeciesId",
                table: "PlayerCreatures",
                column: "CreatureSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCreatures_PlayerId",
                table: "PlayerCreatures",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItems_ItemId",
                table: "PlayerItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompendiumEntries");

            migrationBuilder.DropTable(
                name: "CreatureMoves");

            migrationBuilder.DropTable(
                name: "DefeatedTrainers");

            migrationBuilder.DropTable(
                name: "NpcTrainerCreatures");

            migrationBuilder.DropTable(
                name: "PlayerCreatures");

            migrationBuilder.DropTable(
                name: "PlayerItems");

            migrationBuilder.DropTable(
                name: "TypeEffectivenessEntries");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "NpcTrainers");

            migrationBuilder.DropTable(
                name: "CreatureSpecies");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
