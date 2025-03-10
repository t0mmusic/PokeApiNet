using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokeApiNet.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsMainSeries = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimatedSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimatedSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwesomeNames",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AwesomeName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwesomeNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Berries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GrowthTime = table.Column<int>(type: "integer", nullable: false),
                    MaxHarvest = table.Column<int>(type: "integer", nullable: false),
                    NaturalGiftPower = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Smoothness = table.Column<int>(type: "integer", nullable: false),
                    SoilDryness = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BerryFirmnesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerryFirmnesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BerryFlavors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerryFlavors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChainLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsBaby = table.Column<bool>(type: "boolean", nullable: false),
                    ChainLinkId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChainLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChainLinks_ChainLinks_ChainLinkId",
                        column: x => x.ChainLinkId,
                        principalTable: "ChainLinks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GeneModulo = table.Column<int>(type: "integer", nullable: false),
                    PossibleValues = table.Column<List<int>>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContestComboDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestComboDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContestEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Appeal = table.Column<int>(type: "integer", nullable: false),
                    Jam = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestEffects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrystalSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyTransparent = table.Column<string>(type: "text", nullable: false),
                    BackTransparent = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyTransparent = table.Column<string>(type: "text", nullable: false),
                    FrontTransparent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrystalSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiamondPearlSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiamondPearlSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DreamWorldSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DreamWorldSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EggGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EggGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmeraldSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmeraldSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncounterConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncounterConditionValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterConditionValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncounterMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvolutionTriggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionTriggers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FireredLeafgreenSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireredLeafgreenSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenVIIIconsSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenVIIIconsSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontTransparent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrowthRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Formula = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowthRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeartGoldSoulSilverSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartGoldSoulSilverSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IconsSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconsSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemFlingEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFlingEffects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemPockets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPockets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Default = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Official = table.Column<bool>(type: "boolean", nullable: false),
                    Iso639 = table.Column<string>(type: "text", nullable: false),
                    Iso3166 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationAreaEncounters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAreaEncounters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GameIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveAilments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveAilments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveBattleStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveBattleStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveDamageClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveDamageClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveLearnMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveLearnMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveMetaData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MinHits = table.Column<int>(type: "integer", nullable: true),
                    MaxHits = table.Column<int>(type: "integer", nullable: true),
                    MinTurns = table.Column<int>(type: "integer", nullable: true),
                    MaxTurns = table.Column<int>(type: "integer", nullable: true),
                    Drain = table.Column<int>(type: "integer", nullable: false),
                    Healing = table.Column<int>(type: "integer", nullable: false),
                    CritRate = table.Column<int>(type: "integer", nullable: false),
                    AilmentChance = table.Column<int>(type: "integer", nullable: false),
                    FlinchChance = table.Column<int>(type: "integer", nullable: false),
                    StatChance = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveMetaData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveStatAffectSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveStatAffectSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoveTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveTargets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NaturePokeathlonStatAffectSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturePokeathlonStatAffectSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Natures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Natures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NatureStatAffectSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureStatAffectSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialArtworkSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialArtworkSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OmegaRubyAlphaSapphireSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OmegaRubyAlphaSapphireSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalParkAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalParkAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlatinumSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatinumSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokedexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsMainSeries = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonFormSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonFormSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    GenderRate = table.Column<int>(type: "integer", nullable: false),
                    CaptureRate = table.Column<int>(type: "integer", nullable: true),
                    BaseHappiness = table.Column<int>(type: "integer", nullable: true),
                    IsBaby = table.Column<bool>(type: "boolean", nullable: false),
                    IsLegendary = table.Column<bool>(type: "boolean", nullable: false),
                    IsMythical = table.Column<bool>(type: "boolean", nullable: false),
                    HatchCounter = table.Column<int>(type: "integer", nullable: true),
                    HasGenderDifferences = table.Column<bool>(type: "boolean", nullable: false),
                    FormsSwitchable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedBlueSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackGray = table.Column<string>(type: "text", nullable: false),
                    BackTransparent = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontGray = table.Column<string>(type: "text", nullable: false),
                    FrontTransparent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedBlueSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RubySapphireSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubySapphireSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SilverSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontTransparent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SilverSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperContestEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Appeal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperContestEffects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeRelations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRelations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UltraSunUltraMoonSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UltraSunUltraMoonSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VersionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XYSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XYSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YellowSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackGray = table.Column<string>(type: "text", nullable: false),
                    BackTransparent = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontGray = table.Column<string>(type: "text", nullable: false),
                    FrontTransparent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YellowSprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityFlavorTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FlavorText = table.Column<string>(type: "text", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityFlavorTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityFlavorTexts_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbilityPokemons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    Slot = table.Column<int>(type: "integer", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityPokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityPokemons_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlackWhiteSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AnimatedId = table.Column<Guid>(type: "uuid", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackWhiteSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlackWhiteSprites_AnimatedSprites_AnimatedId",
                        column: x => x.AnimatedId,
                        principalTable: "AnimatedSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BerryFlavorMaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Potency = table.Column<int>(type: "integer", nullable: false),
                    BerryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerryFlavorMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BerryFlavorMaps_Berries_BerryId",
                        column: x => x.BerryId,
                        principalTable: "Berries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FlavorBerryMaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Potency = table.Column<int>(type: "integer", nullable: false),
                    BerryFlavorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlavorBerryMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlavorBerryMaps_BerryFlavors_BerryFlavorId",
                        column: x => x.BerryFlavorId,
                        principalTable: "BerryFlavors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EvolutionChains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChainId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionChains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvolutionChains_ChainLinks_ChainId",
                        column: x => x.ChainId,
                        principalTable: "ChainLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvolutionDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: true),
                    MinLevel = table.Column<int>(type: "integer", nullable: true),
                    MinHappiness = table.Column<int>(type: "integer", nullable: true),
                    MinBeauty = table.Column<int>(type: "integer", nullable: true),
                    MinAffection = table.Column<int>(type: "integer", nullable: true),
                    NeedsOverworldRain = table.Column<bool>(type: "boolean", nullable: false),
                    RelativePhysicalStats = table.Column<int>(type: "integer", nullable: true),
                    TimeOfDay = table.Column<string>(type: "text", nullable: false),
                    TurnUpsideDown = table.Column<bool>(type: "boolean", nullable: false),
                    ChainLinkId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvolutionDetails_ChainLinks_ChainLinkId",
                        column: x => x.ChainLinkId,
                        principalTable: "ChainLinks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContestComboSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NormalId = table.Column<Guid>(type: "uuid", nullable: false),
                    SuperId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestComboSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestComboSets_ContestComboDetails_NormalId",
                        column: x => x.NormalId,
                        principalTable: "ContestComboDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContestComboSets_ContestComboDetails_SuperId",
                        column: x => x.SuperId,
                        principalTable: "ContestComboDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContestNames",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    ContestTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestNames_ContestTypes_ContestTypeId",
                        column: x => x.ContestTypeId,
                        principalTable: "ContestTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesGenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesGenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesGenders_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GrowthRateExperienceLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Experience = table.Column<int>(type: "integer", nullable: false),
                    GrowthRateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowthRateExperienceLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrowthRateExperienceLevels_GrowthRates_GrowthRateId",
                        column: x => x.GrowthRateId,
                        principalTable: "GrowthRates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenerationVIIISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IconsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVIIISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVIIISprites_IconsSprites_IconsId",
                        column: x => x.IconsId,
                        principalTable: "IconsSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    FlingPower = table.Column<int>(type: "integer", nullable: true),
                    SpritesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemSprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "ItemSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EncounterMethodRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationAreaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterMethodRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncounterMethodRates_LocationAreas_LocationAreaId",
                        column: x => x.LocationAreaId,
                        principalTable: "LocationAreas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonEncounters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationAreaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEncounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonEncounters_LocationAreas_LocationAreaId",
                        column: x => x.LocationAreaId,
                        principalTable: "LocationAreas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoveStatAffects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Change = table.Column<int>(type: "integer", nullable: false),
                    IncreaseSetId = table.Column<Guid>(type: "uuid", nullable: true),
                    DecreaseSetId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveStatAffects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveStatAffects_MoveStatAffectSets_DecreaseSetId",
                        column: x => x.DecreaseSetId,
                        principalTable: "MoveStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveStatAffects_MoveStatAffectSets_IncreaseSetId",
                        column: x => x.IncreaseSetId,
                        principalTable: "MoveStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaturePokeathlonStatAffects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxChange = table.Column<int>(type: "integer", nullable: false),
                    IncreaseSetId = table.Column<Guid>(type: "uuid", nullable: true),
                    DecreaseSetId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturePokeathlonStatAffects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NaturePokeathlonStatAffects_NaturePokeathlonStatAffectSets_~",
                        column: x => x.DecreaseSetId,
                        principalTable: "NaturePokeathlonStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaturePokeathlonStatAffects_NaturePokeathlonStatAffectSets~1",
                        column: x => x.IncreaseSetId,
                        principalTable: "NaturePokeathlonStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokeathlonStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AffectingNaturesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeathlonStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokeathlonStats_NaturePokeathlonStatAffectSets_AffectingNat~",
                        column: x => x.AffectingNaturesId,
                        principalTable: "NaturePokeathlonStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveBattleStylePreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LowHpPreference = table.Column<int>(type: "integer", nullable: false),
                    HighHpPreference = table.Column<int>(type: "integer", nullable: false),
                    NatureId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveBattleStylePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveBattleStylePreferences_Natures_NatureId",
                        column: x => x.NatureId,
                        principalTable: "Natures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NatureStatChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxChange = table.Column<int>(type: "integer", nullable: false),
                    NatureId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureStatChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatureStatChanges_Natures_NatureId",
                        column: x => x.NatureId,
                        principalTable: "Natures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GameIndex = table.Column<int>(type: "integer", nullable: false),
                    IsBattleOnly = table.Column<bool>(type: "boolean", nullable: false),
                    AffectingMovesId = table.Column<Guid>(type: "uuid", nullable: false),
                    AffectingNaturesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_MoveStatAffectSets_AffectingMovesId",
                        column: x => x.AffectingMovesId,
                        principalTable: "MoveStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stats_NatureStatAffectSets_AffectingNaturesId",
                        column: x => x.AffectingNaturesId,
                        principalTable: "NatureStatAffectSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DreamWorldId = table.Column<Guid>(type: "uuid", nullable: false),
                    HomeId = table.Column<Guid>(type: "uuid", nullable: false),
                    OfficialArtworkId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherSprites_DreamWorldSprites_DreamWorldId",
                        column: x => x.DreamWorldId,
                        principalTable: "DreamWorldSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherSprites_HomeSprites_HomeId",
                        column: x => x.HomeId,
                        principalTable: "HomeSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherSprites_OfficialArtworkSprites_OfficialArtworkId",
                        column: x => x.OfficialArtworkId,
                        principalTable: "OfficialArtworkSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PalParkEncounterSpecies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseScore = table.Column<int>(type: "integer", nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    PalParkAreaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalParkEncounterSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PalParkEncounterSpecies_PalParkAreas_PalParkAreaId",
                        column: x => x.PalParkAreaId,
                        principalTable: "PalParkAreas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenerationIVSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DiamondPearlId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartGoldSoulSilverId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlatinumId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationIVSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationIVSprites_DiamondPearlSprites_DiamondPearlId",
                        column: x => x.DiamondPearlId,
                        principalTable: "DiamondPearlSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIVSprites_HeartGoldSoulSilverSprites_HeartGoldSou~",
                        column: x => x.HeartGoldSoulSilverId,
                        principalTable: "HeartGoldSoulSilverSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIVSprites_PlatinumSprites_PlatinumId",
                        column: x => x.PlatinumId,
                        principalTable: "PlatinumSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntryNumber = table.Column<int>(type: "integer", nullable: false),
                    PokedexId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonEntries_Pokedexes_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedexes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    FormOrder = table.Column<int>(type: "integer", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    IsBattleOnly = table.Column<bool>(type: "boolean", nullable: false),
                    IsMega = table.Column<bool>(type: "boolean", nullable: false),
                    FormName = table.Column<string>(type: "text", nullable: false),
                    SpritesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonForms_PokemonFormSprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "PokemonFormSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CharacteristicId = table.Column<int>(type: "integer", nullable: true),
                    GrowthRateId = table.Column<int>(type: "integer", nullable: true),
                    ItemAttributeId = table.Column<int>(type: "integer", nullable: true),
                    MoveCategoryId = table.Column<int>(type: "integer", nullable: true),
                    MoveDamageClassId = table.Column<int>(type: "integer", nullable: true),
                    MoveLearnMethodId = table.Column<int>(type: "integer", nullable: true),
                    MoveTargetId = table.Column<int>(type: "integer", nullable: true),
                    PokedexId = table.Column<int>(type: "integer", nullable: true),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descriptions_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_GrowthRates_GrowthRateId",
                        column: x => x.GrowthRateId,
                        principalTable: "GrowthRates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_ItemAttributes_ItemAttributeId",
                        column: x => x.ItemAttributeId,
                        principalTable: "ItemAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_MoveCategories_MoveCategoryId",
                        column: x => x.MoveCategoryId,
                        principalTable: "MoveCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_MoveDamageClasses_MoveDamageClassId",
                        column: x => x.MoveDamageClassId,
                        principalTable: "MoveDamageClasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_MoveLearnMethods_MoveLearnMethodId",
                        column: x => x.MoveLearnMethodId,
                        principalTable: "MoveLearnMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_MoveTargets_MoveTargetId",
                        column: x => x.MoveTargetId,
                        principalTable: "MoveTargets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_Pokedexes_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedexes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Descriptions_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Genuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Genus = table.Column<string>(type: "text", nullable: false),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genuses_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PalParkEncounterAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseScore = table.Column<int>(type: "integer", nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalParkEncounterAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PalParkEncounterAreas_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesDexEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntryNumber = table.Column<int>(type: "integer", nullable: false),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesDexEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesDexEntries_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesFlavorTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FlavorText = table.Column<string>(type: "text", nullable: false),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesFlavorTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesFlavorTexts_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesVarieties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesVarieties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVarieties_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenerationIIISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmeraldId = table.Column<Guid>(type: "uuid", nullable: false),
                    FireredLeafgreenId = table.Column<Guid>(type: "uuid", nullable: false),
                    RubySapphireId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationIIISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationIIISprites_EmeraldSprites_EmeraldId",
                        column: x => x.EmeraldId,
                        principalTable: "EmeraldSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIIISprites_FireredLeafgreenSprites_FireredLeafgre~",
                        column: x => x.FireredLeafgreenId,
                        principalTable: "FireredLeafgreenSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIIISprites_RubySapphireSprites_RubySapphireId",
                        column: x => x.RubySapphireId,
                        principalTable: "RubySapphireSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationIISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CrystalId = table.Column<Guid>(type: "uuid", nullable: false),
                    GoldId = table.Column<Guid>(type: "uuid", nullable: false),
                    SilverId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationIISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationIISprites_CrystalSprites_CrystalId",
                        column: x => x.CrystalId,
                        principalTable: "CrystalSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIISprites_GoldSprites_GoldId",
                        column: x => x.GoldId,
                        principalTable: "GoldSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationIISprites_SilverSprites_SilverId",
                        column: x => x.SilverId,
                        principalTable: "SilverSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlavorTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FlavorText = table.Column<string>(type: "text", nullable: false),
                    ContestEffectId = table.Column<int>(type: "integer", nullable: true),
                    SuperContestEffectId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlavorTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlavorTexts_ContestEffects_ContestEffectId",
                        column: x => x.ContestEffectId,
                        principalTable: "ContestEffects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FlavorTexts_SuperContestEffects_SuperContestEffectId",
                        column: x => x.SuperContestEffectId,
                        principalTable: "SuperContestEffects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DamageRelationsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_TypeRelations_DamageRelationsId",
                        column: x => x.DamageRelationsId,
                        principalTable: "TypeRelations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVIISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IconsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UltraSunUltraMoonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVIISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVIISprites_GenVIIIconsSprites_IconsId",
                        column: x => x.IconsId,
                        principalTable: "GenVIIIconsSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationVIISprites_UltraSunUltraMoonSprites_UltraSunUltra~",
                        column: x => x.UltraSunUltraMoonId,
                        principalTable: "UltraSunUltraMoonSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OmegaRubyAlphaSapphireId = table.Column<Guid>(type: "uuid", nullable: false),
                    XYId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVISprites_OmegaRubyAlphaSapphireSprites_OmegaRuby~",
                        column: x => x.OmegaRubyAlphaSapphireId,
                        principalTable: "OmegaRubyAlphaSapphireSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationVISprites_XYSprites_XYId",
                        column: x => x.XYId,
                        principalTable: "XYSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationISprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RedBlueId = table.Column<Guid>(type: "uuid", nullable: false),
                    YellowId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationISprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationISprites_RedBlueSprites_RedBlueId",
                        column: x => x.RedBlueId,
                        principalTable: "RedBlueSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationISprites_YellowSprites_YellowId",
                        column: x => x.YellowId,
                        principalTable: "YellowSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BlackWhiteId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVSprites_BlackWhiteSprites_BlackWhiteId",
                        column: x => x.BlackWhiteId,
                        principalTable: "BlackWhiteSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Accuracy = table.Column<int>(type: "integer", nullable: true),
                    EffectChance = table.Column<int>(type: "integer", nullable: true),
                    Pp = table.Column<int>(type: "integer", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: true),
                    ContestCombosId = table.Column<Guid>(type: "uuid", nullable: false),
                    MetaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_ContestComboSets_ContestCombosId",
                        column: x => x.ContestCombosId,
                        principalTable: "ContestComboSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moves_MoveMetaData_MetaId",
                        column: x => x.MetaId,
                        principalTable: "MoveMetaData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemHolderPokemon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemHolderPokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemHolderPokemon_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VersionGroupFlavorTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroupFlavorTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionGroupFlavorTexts_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EncounterVersionDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    EncounterMethodRateId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterVersionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncounterVersionDetails_EncounterMethodRates_EncounterMetho~",
                        column: x => x.EncounterMethodRateId,
                        principalTable: "EncounterMethodRates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VersionEncounterDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxChance = table.Column<int>(type: "integer", nullable: false),
                    LocationAreaEncounterId = table.Column<Guid>(type: "uuid", nullable: true),
                    PokemonEncounterId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionEncounterDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionEncounterDetails_LocationAreaEncounters_LocationArea~",
                        column: x => x.LocationAreaEncounterId,
                        principalTable: "LocationAreaEncounters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VersionEncounterDetails_PokemonEncounters_PokemonEncounterId",
                        column: x => x.PokemonEncounterId,
                        principalTable: "PokemonEncounters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenerationGameIndexes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GameIndex = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: true),
                    LocationId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationGameIndexes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationGameIndexes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenerationGameIndexes_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenerationGameIndexes_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypesPokemon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Slot = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesPokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypesPokemon_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VersionSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationIId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationIIId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationIIIId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationIVId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationVId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationVIId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationVIIId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationVIIIId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationIIISprites_GenerationIIIId",
                        column: x => x.GenerationIIIId,
                        principalTable: "GenerationIIISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationIISprites_GenerationIIId",
                        column: x => x.GenerationIIId,
                        principalTable: "GenerationIISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationISprites_GenerationIId",
                        column: x => x.GenerationIId,
                        principalTable: "GenerationISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationIVSprites_GenerationIVId",
                        column: x => x.GenerationIVId,
                        principalTable: "GenerationIVSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationVIIISprites_GenerationVIIIId",
                        column: x => x.GenerationVIIIId,
                        principalTable: "GenerationVIIISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationVIISprites_GenerationVIIId",
                        column: x => x.GenerationVIIId,
                        principalTable: "GenerationVIISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationVISprites_GenerationVIId",
                        column: x => x.GenerationVIId,
                        principalTable: "GenerationVISprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionSprites_GenerationVSprites_GenerationVId",
                        column: x => x.GenerationVId,
                        principalTable: "GenerationVSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbilityEffectChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: true),
                    MoveId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityEffectChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityEffectChanges_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbilityEffectChanges_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MachineVersionDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: true),
                    MoveId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineVersionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineVersionDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MachineVersionDetails_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoveFlavorTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FlavorText = table.Column<string>(type: "text", nullable: false),
                    MoveId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveFlavorTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveFlavorTexts_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoveStatChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Change = table.Column<int>(type: "integer", nullable: false),
                    MoveId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveStatChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveStatChanges_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: true),
                    BerryFirmnessId = table.Column<int>(type: "integer", nullable: true),
                    BerryFlavorId = table.Column<int>(type: "integer", nullable: true),
                    EggGroupId = table.Column<int>(type: "integer", nullable: true),
                    EncounterConditionId = table.Column<int>(type: "integer", nullable: true),
                    EncounterConditionValueId = table.Column<int>(type: "integer", nullable: true),
                    EncounterMethodId = table.Column<int>(type: "integer", nullable: true),
                    EvolutionTriggerId = table.Column<int>(type: "integer", nullable: true),
                    GenerationId = table.Column<int>(type: "integer", nullable: true),
                    ItemAttributeId = table.Column<int>(type: "integer", nullable: true),
                    ItemCategoryId = table.Column<int>(type: "integer", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: true),
                    ItemPocketId = table.Column<int>(type: "integer", nullable: true),
                    LanguageId = table.Column<int>(type: "integer", nullable: true),
                    LocationAreaId = table.Column<int>(type: "integer", nullable: true),
                    LocationId = table.Column<int>(type: "integer", nullable: true),
                    MoveAilmentId = table.Column<int>(type: "integer", nullable: true),
                    MoveBattleStyleId = table.Column<int>(type: "integer", nullable: true),
                    MoveDamageClassId = table.Column<int>(type: "integer", nullable: true),
                    MoveId = table.Column<int>(type: "integer", nullable: true),
                    MoveLearnMethodId = table.Column<int>(type: "integer", nullable: true),
                    MoveTargetId = table.Column<int>(type: "integer", nullable: true),
                    NatureId = table.Column<int>(type: "integer", nullable: true),
                    PalParkAreaId = table.Column<int>(type: "integer", nullable: true),
                    PokeathlonStatId = table.Column<int>(type: "integer", nullable: true),
                    PokedexId = table.Column<int>(type: "integer", nullable: true),
                    PokemonColorId = table.Column<int>(type: "integer", nullable: true),
                    PokemonFormFormNamesId = table.Column<int>(type: "integer", nullable: true),
                    PokemonFormId = table.Column<int>(type: "integer", nullable: true),
                    PokemonSpeciesId = table.Column<int>(type: "integer", nullable: true),
                    RegionId = table.Column<int>(type: "integer", nullable: true),
                    StatId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    VersionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Names_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_BerryFirmnesses_BerryFirmnessId",
                        column: x => x.BerryFirmnessId,
                        principalTable: "BerryFirmnesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_BerryFlavors_BerryFlavorId",
                        column: x => x.BerryFlavorId,
                        principalTable: "BerryFlavors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_EggGroups_EggGroupId",
                        column: x => x.EggGroupId,
                        principalTable: "EggGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_EncounterConditionValues_EncounterConditionValueId",
                        column: x => x.EncounterConditionValueId,
                        principalTable: "EncounterConditionValues",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_EncounterConditions_EncounterConditionId",
                        column: x => x.EncounterConditionId,
                        principalTable: "EncounterConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_EncounterMethods_EncounterMethodId",
                        column: x => x.EncounterMethodId,
                        principalTable: "EncounterMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_EvolutionTriggers_EvolutionTriggerId",
                        column: x => x.EvolutionTriggerId,
                        principalTable: "EvolutionTriggers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Generations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "Generations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_ItemAttributes_ItemAttributeId",
                        column: x => x.ItemAttributeId,
                        principalTable: "ItemAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_ItemPockets_ItemPocketId",
                        column: x => x.ItemPocketId,
                        principalTable: "ItemPockets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_LocationAreas_LocationAreaId",
                        column: x => x.LocationAreaId,
                        principalTable: "LocationAreas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_MoveAilments_MoveAilmentId",
                        column: x => x.MoveAilmentId,
                        principalTable: "MoveAilments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_MoveBattleStyles_MoveBattleStyleId",
                        column: x => x.MoveBattleStyleId,
                        principalTable: "MoveBattleStyles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_MoveDamageClasses_MoveDamageClassId",
                        column: x => x.MoveDamageClassId,
                        principalTable: "MoveDamageClasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_MoveLearnMethods_MoveLearnMethodId",
                        column: x => x.MoveLearnMethodId,
                        principalTable: "MoveLearnMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_MoveTargets_MoveTargetId",
                        column: x => x.MoveTargetId,
                        principalTable: "MoveTargets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Natures_NatureId",
                        column: x => x.NatureId,
                        principalTable: "Natures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_PalParkAreas_PalParkAreaId",
                        column: x => x.PalParkAreaId,
                        principalTable: "PalParkAreas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_PokeathlonStats_PokeathlonStatId",
                        column: x => x.PokeathlonStatId,
                        principalTable: "PokeathlonStats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Pokedexes_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedexes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_PokemonColors_PokemonColorId",
                        column: x => x.PokemonColorId,
                        principalTable: "PokemonColors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_PokemonForms_PokemonFormFormNamesId",
                        column: x => x.PokemonFormFormNamesId,
                        principalTable: "PokemonForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Names_PokemonForms_PokemonFormId",
                        column: x => x.PokemonFormId,
                        principalTable: "PokemonForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Names_PokemonSpecies_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Names_Versions_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Versions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PastMoveStatValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Accuracy = table.Column<int>(type: "integer", nullable: true),
                    EffectChance = table.Column<int>(type: "integer", nullable: true),
                    Power = table.Column<int>(type: "integer", nullable: true),
                    Pp = table.Column<int>(type: "integer", nullable: true),
                    MoveId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastMoveStatValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastMoveStatValues_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemHolderPokemonVersionDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rarity = table.Column<string>(type: "text", nullable: false),
                    ItemHolderPokemonId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemHolderPokemonVersionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemHolderPokemonVersionDetail_ItemHolderPokemon_ItemHolder~",
                        column: x => x.ItemHolderPokemonId,
                        principalTable: "ItemHolderPokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Encounters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MinLevel = table.Column<int>(type: "integer", nullable: false),
                    MaxLevel = table.Column<int>(type: "integer", nullable: false),
                    Chance = table.Column<int>(type: "integer", nullable: false),
                    VersionEncounterDetailId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encounters_VersionEncounterDetails_VersionEncounterDetailId",
                        column: x => x.VersionEncounterDetailId,
                        principalTable: "VersionEncounterDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonSprites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FrontDefault = table.Column<string>(type: "text", nullable: false),
                    FrontShiny = table.Column<string>(type: "text", nullable: false),
                    FrontFemale = table.Column<string>(type: "text", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "text", nullable: false),
                    BackDefault = table.Column<string>(type: "text", nullable: false),
                    BackShiny = table.Column<string>(type: "text", nullable: false),
                    BackFemale = table.Column<string>(type: "text", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "text", nullable: false),
                    OtherId = table.Column<Guid>(type: "uuid", nullable: false),
                    VersionsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSprites_OtherSprites_OtherId",
                        column: x => x.OtherId,
                        principalTable: "OtherSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSprites_VersionSprites_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "VersionSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Effect = table.Column<string>(type: "text", nullable: false),
                    AbilityEffectChangeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ContestEffectId = table.Column<int>(type: "integer", nullable: true),
                    ItemFlingEffectId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Effects_AbilityEffectChanges_AbilityEffectChangeId",
                        column: x => x.AbilityEffectChangeId,
                        principalTable: "AbilityEffectChanges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Effects_ContestEffects_ContestEffectId",
                        column: x => x.ContestEffectId,
                        principalTable: "ContestEffects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Effects_ItemFlingEffects_ItemFlingEffectId",
                        column: x => x.ItemFlingEffectId,
                        principalTable: "ItemFlingEffects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VerboseEffects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Effect = table.Column<string>(type: "text", nullable: false),
                    ShortEffect = table.Column<string>(type: "text", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: true),
                    MoveId = table.Column<int>(type: "integer", nullable: true),
                    PastMoveStatValuesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerboseEffects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerboseEffects_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VerboseEffects_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VerboseEffects_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VerboseEffects_PastMoveStatValues_PastMoveStatValuesId",
                        column: x => x.PastMoveStatValuesId,
                        principalTable: "PastMoveStatValues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BaseExperience = table.Column<int>(type: "integer", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    LocationAreaEncounters = table.Column<string>(type: "text", nullable: false),
                    SpritesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonSprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "PokemonSprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    Slot = table.Column<int>(type: "integer", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonHeldItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHeldItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonHeldItems_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonMove",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonPastTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPastTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonPastTypes_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Effort = table.Column<int>(type: "integer", nullable: false),
                    BaseStat = table.Column<int>(type: "integer", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonStats_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VersionGameIndexes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GameIndex = table.Column<int>(type: "integer", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGameIndexes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionGameIndexes_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonHeldItemVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rarity = table.Column<int>(type: "integer", nullable: false),
                    PokemonHeldItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHeldItemVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonHeldItemVersions_PokemonHeldItems_PokemonHeldItemId",
                        column: x => x.PokemonHeldItemId,
                        principalTable: "PokemonHeldItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonMoveVersion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LevelLearnedAt = table.Column<int>(type: "integer", nullable: false),
                    PokemonMoveId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoveVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMoveVersion_PokemonMove_PokemonMoveId",
                        column: x => x.PokemonMoveId,
                        principalTable: "PokemonMove",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Slot = table.Column<int>(type: "integer", nullable: false),
                    PokemonFormId = table.Column<int>(type: "integer", nullable: true),
                    PokemonId = table.Column<int>(type: "integer", nullable: true),
                    PokemonPastTypesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_PokemonForms_PokemonFormId",
                        column: x => x.PokemonFormId,
                        principalTable: "PokemonForms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokemonTypes_PokemonPastTypes_PokemonPastTypesId",
                        column: x => x.PokemonPastTypesId,
                        principalTable: "PokemonPastTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityEffectChanges_AbilityId",
                table: "AbilityEffectChanges",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityEffectChanges_MoveId",
                table: "AbilityEffectChanges",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityFlavorTexts_AbilityId",
                table: "AbilityFlavorTexts",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityPokemons_AbilityId",
                table: "AbilityPokemons",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BerryFlavorMaps_BerryId",
                table: "BerryFlavorMaps",
                column: "BerryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlackWhiteSprites_AnimatedId",
                table: "BlackWhiteSprites",
                column: "AnimatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ChainLinks_ChainLinkId",
                table: "ChainLinks",
                column: "ChainLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestComboSets_NormalId",
                table: "ContestComboSets",
                column: "NormalId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestComboSets_SuperId",
                table: "ContestComboSets",
                column: "SuperId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestNames_ContestTypeId",
                table: "ContestNames",
                column: "ContestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_CharacteristicId",
                table: "Descriptions",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_GrowthRateId",
                table: "Descriptions",
                column: "GrowthRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ItemAttributeId",
                table: "Descriptions",
                column: "ItemAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_MoveCategoryId",
                table: "Descriptions",
                column: "MoveCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_MoveDamageClassId",
                table: "Descriptions",
                column: "MoveDamageClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_MoveLearnMethodId",
                table: "Descriptions",
                column: "MoveLearnMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_MoveTargetId",
                table: "Descriptions",
                column: "MoveTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_PokedexId",
                table: "Descriptions",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_PokemonSpeciesId",
                table: "Descriptions",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_AbilityEffectChangeId",
                table: "Effects",
                column: "AbilityEffectChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_ContestEffectId",
                table: "Effects",
                column: "ContestEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_ItemFlingEffectId",
                table: "Effects",
                column: "ItemFlingEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_EncounterMethodRates_LocationAreaId",
                table: "EncounterMethodRates",
                column: "LocationAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encounters_VersionEncounterDetailId",
                table: "Encounters",
                column: "VersionEncounterDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EncounterVersionDetails_EncounterMethodRateId",
                table: "EncounterVersionDetails",
                column: "EncounterMethodRateId");

            migrationBuilder.CreateIndex(
                name: "IX_EvolutionChains_ChainId",
                table: "EvolutionChains",
                column: "ChainId");

            migrationBuilder.CreateIndex(
                name: "IX_EvolutionDetails_ChainLinkId",
                table: "EvolutionDetails",
                column: "ChainLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorBerryMaps_BerryFlavorId",
                table: "FlavorBerryMaps",
                column: "BerryFlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTexts_ContestEffectId",
                table: "FlavorTexts",
                column: "ContestEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTexts_SuperContestEffectId",
                table: "FlavorTexts",
                column: "SuperContestEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationGameIndexes_ItemId",
                table: "GenerationGameIndexes",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationGameIndexes_LocationId",
                table: "GenerationGameIndexes",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationGameIndexes_TypeId",
                table: "GenerationGameIndexes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIIISprites_EmeraldId",
                table: "GenerationIIISprites",
                column: "EmeraldId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIIISprites_FireredLeafgreenId",
                table: "GenerationIIISprites",
                column: "FireredLeafgreenId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIIISprites_RubySapphireId",
                table: "GenerationIIISprites",
                column: "RubySapphireId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIISprites_CrystalId",
                table: "GenerationIISprites",
                column: "CrystalId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIISprites_GoldId",
                table: "GenerationIISprites",
                column: "GoldId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIISprites_SilverId",
                table: "GenerationIISprites",
                column: "SilverId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationISprites_RedBlueId",
                table: "GenerationISprites",
                column: "RedBlueId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationISprites_YellowId",
                table: "GenerationISprites",
                column: "YellowId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIVSprites_DiamondPearlId",
                table: "GenerationIVSprites",
                column: "DiamondPearlId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIVSprites_HeartGoldSoulSilverId",
                table: "GenerationIVSprites",
                column: "HeartGoldSoulSilverId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIVSprites_PlatinumId",
                table: "GenerationIVSprites",
                column: "PlatinumId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIIISprites_IconsId",
                table: "GenerationVIIISprites",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIISprites_IconsId",
                table: "GenerationVIISprites",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIISprites_UltraSunUltraMoonId",
                table: "GenerationVIISprites",
                column: "UltraSunUltraMoonId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVISprites_OmegaRubyAlphaSapphireId",
                table: "GenerationVISprites",
                column: "OmegaRubyAlphaSapphireId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVISprites_XYId",
                table: "GenerationVISprites",
                column: "XYId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVSprites_BlackWhiteId",
                table: "GenerationVSprites",
                column: "BlackWhiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Genuses_PokemonSpeciesId",
                table: "Genuses",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowthRateExperienceLevels_GrowthRateId",
                table: "GrowthRateExperienceLevels",
                column: "GrowthRateId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemHolderPokemon_ItemId",
                table: "ItemHolderPokemon",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemHolderPokemonVersionDetail_ItemHolderPokemonId",
                table: "ItemHolderPokemonVersionDetail",
                column: "ItemHolderPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SpritesId",
                table: "Items",
                column: "SpritesId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineVersionDetails_ItemId",
                table: "MachineVersionDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineVersionDetails_MoveId",
                table: "MachineVersionDetails",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveBattleStylePreferences_NatureId",
                table: "MoveBattleStylePreferences",
                column: "NatureId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveFlavorTexts_MoveId",
                table: "MoveFlavorTexts",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_ContestCombosId",
                table: "Moves",
                column: "ContestCombosId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_MetaId",
                table: "Moves",
                column: "MetaId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveStatAffects_DecreaseSetId",
                table: "MoveStatAffects",
                column: "DecreaseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveStatAffects_IncreaseSetId",
                table: "MoveStatAffects",
                column: "IncreaseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveStatChanges_MoveId",
                table: "MoveStatChanges",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_AbilityId",
                table: "Names",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_BerryFirmnessId",
                table: "Names",
                column: "BerryFirmnessId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_BerryFlavorId",
                table: "Names",
                column: "BerryFlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_EggGroupId",
                table: "Names",
                column: "EggGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_EncounterConditionId",
                table: "Names",
                column: "EncounterConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_EncounterConditionValueId",
                table: "Names",
                column: "EncounterConditionValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_EncounterMethodId",
                table: "Names",
                column: "EncounterMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_EvolutionTriggerId",
                table: "Names",
                column: "EvolutionTriggerId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_GenerationId",
                table: "Names",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_ItemAttributeId",
                table: "Names",
                column: "ItemAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_ItemCategoryId",
                table: "Names",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_ItemId",
                table: "Names",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_ItemPocketId",
                table: "Names",
                column: "ItemPocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_LanguageId",
                table: "Names",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_LocationAreaId",
                table: "Names",
                column: "LocationAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_LocationId",
                table: "Names",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveAilmentId",
                table: "Names",
                column: "MoveAilmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveBattleStyleId",
                table: "Names",
                column: "MoveBattleStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveDamageClassId",
                table: "Names",
                column: "MoveDamageClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveId",
                table: "Names",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveLearnMethodId",
                table: "Names",
                column: "MoveLearnMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_MoveTargetId",
                table: "Names",
                column: "MoveTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_NatureId",
                table: "Names",
                column: "NatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PalParkAreaId",
                table: "Names",
                column: "PalParkAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokeathlonStatId",
                table: "Names",
                column: "PokeathlonStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokedexId",
                table: "Names",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokemonColorId",
                table: "Names",
                column: "PokemonColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokemonFormFormNamesId",
                table: "Names",
                column: "PokemonFormFormNamesId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokemonFormId",
                table: "Names",
                column: "PokemonFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_PokemonSpeciesId",
                table: "Names",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_RegionId",
                table: "Names",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_StatId",
                table: "Names",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_TypeId",
                table: "Names",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Names_VersionId",
                table: "Names",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturePokeathlonStatAffects_DecreaseSetId",
                table: "NaturePokeathlonStatAffects",
                column: "DecreaseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturePokeathlonStatAffects_IncreaseSetId",
                table: "NaturePokeathlonStatAffects",
                column: "IncreaseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_NatureStatChanges_NatureId",
                table: "NatureStatChanges",
                column: "NatureId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherSprites_DreamWorldId",
                table: "OtherSprites",
                column: "DreamWorldId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherSprites_HomeId",
                table: "OtherSprites",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherSprites_OfficialArtworkId",
                table: "OtherSprites",
                column: "OfficialArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_PalParkEncounterAreas_PokemonSpeciesId",
                table: "PalParkEncounterAreas",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PalParkEncounterSpecies_PalParkAreaId",
                table: "PalParkEncounterSpecies",
                column: "PalParkAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_PastMoveStatValues_MoveId",
                table: "PastMoveStatValues",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_PokeathlonStats_AffectingNaturesId",
                table: "PokeathlonStats",
                column: "AffectingNaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_SpritesId",
                table: "Pokemon",
                column: "SpritesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_PokemonId",
                table: "PokemonAbilities",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEncounters_LocationAreaId",
                table: "PokemonEncounters",
                column: "LocationAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEntries_PokedexId",
                table: "PokemonEntries",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonForms_SpritesId",
                table: "PokemonForms",
                column: "SpritesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHeldItems_PokemonId",
                table: "PokemonHeldItems",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHeldItemVersions_PokemonHeldItemId",
                table: "PokemonHeldItemVersions",
                column: "PokemonHeldItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_PokemonId",
                table: "PokemonMove",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoveVersion_PokemonMoveId",
                table: "PokemonMoveVersion",
                column: "PokemonMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPastTypes_PokemonId",
                table: "PokemonPastTypes",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesDexEntries_PokemonSpeciesId",
                table: "PokemonSpeciesDexEntries",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesFlavorTexts_PokemonSpeciesId",
                table: "PokemonSpeciesFlavorTexts",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesGenders_GenderId",
                table: "PokemonSpeciesGenders",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVarieties_PokemonSpeciesId",
                table: "PokemonSpeciesVarieties",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSprites_OtherId",
                table: "PokemonSprites",
                column: "OtherId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSprites_VersionsId",
                table: "PokemonSprites",
                column: "VersionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonStats_PokemonId",
                table: "PokemonStats",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonFormId",
                table: "PokemonTypes",
                column: "PokemonFormId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonId",
                table: "PokemonTypes",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonPastTypesId",
                table: "PokemonTypes",
                column: "PokemonPastTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_AffectingMovesId",
                table: "Stats",
                column: "AffectingMovesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_AffectingNaturesId",
                table: "Stats",
                column: "AffectingNaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_DamageRelationsId",
                table: "Types",
                column: "DamageRelationsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesPokemon_TypeId",
                table: "TypesPokemon",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VerboseEffects_AbilityId",
                table: "VerboseEffects",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_VerboseEffects_ItemId",
                table: "VerboseEffects",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VerboseEffects_MoveId",
                table: "VerboseEffects",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_VerboseEffects_PastMoveStatValuesId",
                table: "VerboseEffects",
                column: "PastMoveStatValuesId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionEncounterDetails_LocationAreaEncounterId",
                table: "VersionEncounterDetails",
                column: "LocationAreaEncounterId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionEncounterDetails_PokemonEncounterId",
                table: "VersionEncounterDetails",
                column: "PokemonEncounterId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGameIndexes_PokemonId",
                table: "VersionGameIndexes",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupFlavorTexts_ItemId",
                table: "VersionGroupFlavorTexts",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationIId",
                table: "VersionSprites",
                column: "GenerationIId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationIIId",
                table: "VersionSprites",
                column: "GenerationIIId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationIIIId",
                table: "VersionSprites",
                column: "GenerationIIIId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationIVId",
                table: "VersionSprites",
                column: "GenerationIVId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationVId",
                table: "VersionSprites",
                column: "GenerationVId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationVIId",
                table: "VersionSprites",
                column: "GenerationVIId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationVIIId",
                table: "VersionSprites",
                column: "GenerationVIIId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionSprites_GenerationVIIIId",
                table: "VersionSprites",
                column: "GenerationVIIIId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityFlavorTexts");

            migrationBuilder.DropTable(
                name: "AbilityPokemons");

            migrationBuilder.DropTable(
                name: "AwesomeNames");

            migrationBuilder.DropTable(
                name: "BerryFlavorMaps");

            migrationBuilder.DropTable(
                name: "ContestNames");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Encounters");

            migrationBuilder.DropTable(
                name: "EncounterVersionDetails");

            migrationBuilder.DropTable(
                name: "EvolutionChains");

            migrationBuilder.DropTable(
                name: "EvolutionDetails");

            migrationBuilder.DropTable(
                name: "FlavorBerryMaps");

            migrationBuilder.DropTable(
                name: "FlavorTexts");

            migrationBuilder.DropTable(
                name: "GenerationGameIndexes");

            migrationBuilder.DropTable(
                name: "Genuses");

            migrationBuilder.DropTable(
                name: "GrowthRateExperienceLevels");

            migrationBuilder.DropTable(
                name: "ItemHolderPokemonVersionDetail");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "MachineVersionDetails");

            migrationBuilder.DropTable(
                name: "MoveBattleStylePreferences");

            migrationBuilder.DropTable(
                name: "MoveFlavorTexts");

            migrationBuilder.DropTable(
                name: "MoveStatAffects");

            migrationBuilder.DropTable(
                name: "MoveStatChanges");

            migrationBuilder.DropTable(
                name: "Names");

            migrationBuilder.DropTable(
                name: "NaturePokeathlonStatAffects");

            migrationBuilder.DropTable(
                name: "NatureStatChanges");

            migrationBuilder.DropTable(
                name: "PalParkEncounterAreas");

            migrationBuilder.DropTable(
                name: "PalParkEncounterSpecies");

            migrationBuilder.DropTable(
                name: "PokemonAbilities");

            migrationBuilder.DropTable(
                name: "PokemonEntries");

            migrationBuilder.DropTable(
                name: "PokemonHeldItemVersions");

            migrationBuilder.DropTable(
                name: "PokemonMoveVersion");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesDexEntries");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesFlavorTexts");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesGenders");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesVarieties");

            migrationBuilder.DropTable(
                name: "PokemonStats");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "TypesPokemon");

            migrationBuilder.DropTable(
                name: "VerboseEffects");

            migrationBuilder.DropTable(
                name: "VersionGameIndexes");

            migrationBuilder.DropTable(
                name: "VersionGroupFlavorTexts");

            migrationBuilder.DropTable(
                name: "VersionGroups");

            migrationBuilder.DropTable(
                name: "Berries");

            migrationBuilder.DropTable(
                name: "ContestTypes");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "MoveCategories");

            migrationBuilder.DropTable(
                name: "AbilityEffectChanges");

            migrationBuilder.DropTable(
                name: "ItemFlingEffects");

            migrationBuilder.DropTable(
                name: "VersionEncounterDetails");

            migrationBuilder.DropTable(
                name: "EncounterMethodRates");

            migrationBuilder.DropTable(
                name: "ChainLinks");

            migrationBuilder.DropTable(
                name: "ContestEffects");

            migrationBuilder.DropTable(
                name: "SuperContestEffects");

            migrationBuilder.DropTable(
                name: "GrowthRates");

            migrationBuilder.DropTable(
                name: "ItemHolderPokemon");

            migrationBuilder.DropTable(
                name: "BerryFirmnesses");

            migrationBuilder.DropTable(
                name: "BerryFlavors");

            migrationBuilder.DropTable(
                name: "EggGroups");

            migrationBuilder.DropTable(
                name: "EncounterConditionValues");

            migrationBuilder.DropTable(
                name: "EncounterConditions");

            migrationBuilder.DropTable(
                name: "EncounterMethods");

            migrationBuilder.DropTable(
                name: "EvolutionTriggers");

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.DropTable(
                name: "ItemAttributes");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemPockets");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MoveAilments");

            migrationBuilder.DropTable(
                name: "MoveBattleStyles");

            migrationBuilder.DropTable(
                name: "MoveDamageClasses");

            migrationBuilder.DropTable(
                name: "MoveLearnMethods");

            migrationBuilder.DropTable(
                name: "MoveTargets");

            migrationBuilder.DropTable(
                name: "PokeathlonStats");

            migrationBuilder.DropTable(
                name: "PokemonColors");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Natures");

            migrationBuilder.DropTable(
                name: "PalParkAreas");

            migrationBuilder.DropTable(
                name: "Pokedexes");

            migrationBuilder.DropTable(
                name: "PokemonHeldItems");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "PokemonSpecies");

            migrationBuilder.DropTable(
                name: "PokemonForms");

            migrationBuilder.DropTable(
                name: "PokemonPastTypes");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "PastMoveStatValues");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "LocationAreaEncounters");

            migrationBuilder.DropTable(
                name: "PokemonEncounters");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "NaturePokeathlonStatAffectSets");

            migrationBuilder.DropTable(
                name: "MoveStatAffectSets");

            migrationBuilder.DropTable(
                name: "NatureStatAffectSets");

            migrationBuilder.DropTable(
                name: "PokemonFormSprites");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "TypeRelations");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "LocationAreas");

            migrationBuilder.DropTable(
                name: "ItemSprites");

            migrationBuilder.DropTable(
                name: "PokemonSprites");

            migrationBuilder.DropTable(
                name: "ContestComboSets");

            migrationBuilder.DropTable(
                name: "MoveMetaData");

            migrationBuilder.DropTable(
                name: "OtherSprites");

            migrationBuilder.DropTable(
                name: "VersionSprites");

            migrationBuilder.DropTable(
                name: "ContestComboDetails");

            migrationBuilder.DropTable(
                name: "DreamWorldSprites");

            migrationBuilder.DropTable(
                name: "HomeSprites");

            migrationBuilder.DropTable(
                name: "OfficialArtworkSprites");

            migrationBuilder.DropTable(
                name: "GenerationIIISprites");

            migrationBuilder.DropTable(
                name: "GenerationIISprites");

            migrationBuilder.DropTable(
                name: "GenerationISprites");

            migrationBuilder.DropTable(
                name: "GenerationIVSprites");

            migrationBuilder.DropTable(
                name: "GenerationVIIISprites");

            migrationBuilder.DropTable(
                name: "GenerationVIISprites");

            migrationBuilder.DropTable(
                name: "GenerationVISprites");

            migrationBuilder.DropTable(
                name: "GenerationVSprites");

            migrationBuilder.DropTable(
                name: "EmeraldSprites");

            migrationBuilder.DropTable(
                name: "FireredLeafgreenSprites");

            migrationBuilder.DropTable(
                name: "RubySapphireSprites");

            migrationBuilder.DropTable(
                name: "CrystalSprites");

            migrationBuilder.DropTable(
                name: "GoldSprites");

            migrationBuilder.DropTable(
                name: "SilverSprites");

            migrationBuilder.DropTable(
                name: "RedBlueSprites");

            migrationBuilder.DropTable(
                name: "YellowSprites");

            migrationBuilder.DropTable(
                name: "DiamondPearlSprites");

            migrationBuilder.DropTable(
                name: "HeartGoldSoulSilverSprites");

            migrationBuilder.DropTable(
                name: "PlatinumSprites");

            migrationBuilder.DropTable(
                name: "IconsSprites");

            migrationBuilder.DropTable(
                name: "GenVIIIconsSprites");

            migrationBuilder.DropTable(
                name: "UltraSunUltraMoonSprites");

            migrationBuilder.DropTable(
                name: "OmegaRubyAlphaSapphireSprites");

            migrationBuilder.DropTable(
                name: "XYSprites");

            migrationBuilder.DropTable(
                name: "BlackWhiteSprites");

            migrationBuilder.DropTable(
                name: "AnimatedSprites");
        }
    }
}
