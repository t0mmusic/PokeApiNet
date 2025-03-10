using Microsoft.EntityFrameworkCore;

namespace PokeApiNet.Data;

public class PokeApiDbContext : DbContext
{
    public PokeApiDbContext(DbContextOptions<PokeApiDbContext> options) : base(options)
    {

    }

    public PokeApiDbContext()
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore(typeof(ApiResource<>)); // Ignore generic ApiResource<T> usage

        modelBuilder.Entity<MoveStatAffect>()
            .HasOne(a => a.IncreaseSet)
            .WithMany(s => s.Increase)
            .HasForeignKey(a => a.IncreaseSetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MoveStatAffect>()
            .HasOne(a => a.DecreaseSet)
            .WithMany(s => s.Decrease)
            .HasForeignKey(a => a.DecreaseSetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NaturePokeathlonStatAffect>()
            .HasOne(a => a.IncreaseSet)
            .WithMany(s => s.Increase)
            .HasForeignKey(a => a.IncreaseSetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NaturePokeathlonStatAffect>()
            .HasOne(a => a.DecreaseSet)
            .WithMany(s => s.Decrease)
            .HasForeignKey(a => a.DecreaseSetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PokemonForm>()
            .HasMany(p => p.Names)
            .WithOne()
            .HasForeignKey("PokemonFormId") // Shadow foreign key
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PokemonForm>()
            .HasMany(p => p.FormNames)
            .WithOne()
            .HasForeignKey("PokemonFormFormNamesId") // Shadow foreign key
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }


    #region Berries.cs
    public DbSet<Berry> Berries { get; set; }
    public DbSet<BerryFlavorMap> BerryFlavorMaps { get; set; }
    public DbSet<BerryFirmness> BerryFirmnesses { get; set; }
    public DbSet<BerryFlavor> BerryFlavors { get; set; }
    public DbSet<FlavorBerryMap> FlavorBerryMaps { get; set; }
    #endregion

    #region Common.cs
    public DbSet<Language> Languages { get; set; }
    public DbSet<Descriptions> Descriptions { get; set; }
    public DbSet<Effects> Effects { get; set; }
    public DbSet<Encounter> Encounters { get; set; }
    public DbSet<FlavorTexts> FlavorTexts { get; set; }
    public DbSet<GenerationGameIndex> GenerationGameIndexes { get; set; }
    public DbSet<MachineVersionDetail> MachineVersionDetails { get; set; }
    public DbSet<Names> Names { get; set; }
    public DbSet<VerboseEffect> VerboseEffects { get; set; }
    public DbSet<VersionEncounterDetail> VersionEncounterDetails { get; set; }
    public DbSet<VersionGameIndex> VersionGameIndexes { get; set; }
    public DbSet<VersionGroupFlavorText> VersionGroupFlavorTexts { get; set; }
    #endregion

    #region Contests.cs
    public DbSet<ContestType> ContestTypes { get; set; }
    public DbSet<ContestName> ContestNames { get; set; }
    public DbSet<ContestEffect> ContestEffects { get; set; }
    public DbSet<SuperContestEffect> SuperContestEffects { get; set; }
    #endregion

    #region Encounters.cs
    public DbSet<EncounterMethod> EncounterMethods { get; set; }
    public DbSet<EncounterCondition> EncounterConditions { get; set; }
    public DbSet<EncounterConditionValue> EncounterConditionValues { get; set; }
    #endregion

    #region Evolution.cs
    public DbSet<EvolutionChain> EvolutionChains { get; set; }
    public DbSet<ChainLink> ChainLinks { get; set; }
    public DbSet<EvolutionDetail> EvolutionDetails { get; set; }
    public DbSet<EvolutionTrigger> EvolutionTriggers { get; set; }
    #endregion

    #region Games.cs
    public DbSet<Generation> Generations { get; set; }
    public DbSet<Pokedex> Pokedexes { get; set; }
    public DbSet<PokemonEntry> PokemonEntries { get; set; }
    public DbSet<Version> Versions { get; set; }
    public DbSet<VersionGroup> VersionGroups { get; set; }
    #endregion

    #region Items.cs
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemSprites> ItemSprites { get; set; }
    public DbSet<ItemHolderPokemon> ItemHolderPokemon { get; set; }
    public DbSet<ItemHolderPokemonVersionDetail> ItemHolderPokemonVersionDetail { get; set; }
    public DbSet<ItemAttribute> ItemAttributes { get; set; }
    public DbSet<ItemCategory> ItemCategories { get; set; }
    public DbSet<ItemFlingEffect> ItemFlingEffects { get; set; }
    public DbSet<ItemPocket> ItemPockets { get; set; }
    #endregion

    #region Locations.cs
    public DbSet<Location> Locations { get; set; }
    public DbSet<LocationArea> LocationAreas { get; set; }
    public DbSet<EncounterMethodRate> EncounterMethodRates { get; set; }
    public DbSet<EncounterVersionDetails> EncounterVersionDetails { get; set; }
    public DbSet<PokemonEncounter> PokemonEncounters { get; set; }
    public DbSet<PalParkArea> PalParkAreas { get; set; }
    public DbSet<PalParkEncounterSpecies> PalParkEncounterSpecies { get; set; }
    public DbSet<Region> Regions { get; set; }
    #endregion

    #region Machines.cs
    public DbSet<Machine> Machines { get; set; }
    #endregion

    #region Moves.cs
    public DbSet<Move> Moves { get; set; }
    public DbSet<ContestComboSets> ContestComboSets { get; set; }
    public DbSet<ContestComboDetail> ContestComboDetails { get; set; }
    public DbSet<MoveFlavorText> MoveFlavorTexts { get; set; }
    public DbSet<MoveMetaData> MoveMetaData { get; set; }
    public DbSet<MoveStatChange> MoveStatChanges { get; set; }
    public DbSet<PastMoveStatValues> PastMoveStatValues { get; set; }
    public DbSet<MoveAilment> MoveAilments { get; set; }
    public DbSet<MoveBattleStyle> MoveBattleStyles { get; set; }
    public DbSet<MoveCategory> MoveCategories { get; set; }
    public DbSet<MoveDamageClass> MoveDamageClasses { get; set; }
    public DbSet<MoveLearnMethod> MoveLearnMethods { get; set; }
    public DbSet<MoveTarget> MoveTargets { get; set; }
    #endregion

    #region Pokemon.cs
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<AbilityEffectChange> AbilityEffectChanges { get; set; }
    public DbSet<AbilityFlavorText> AbilityFlavorTexts { get; set; }
    public DbSet<AbilityPokemon> AbilityPokemons { get; set; }
    public DbSet<Characteristic> Characteristics { get; set; }
    public DbSet<EggGroup> EggGroups { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<PokemonSpeciesGender> PokemonSpeciesGenders { get; set; }
    public DbSet<GrowthRate> GrowthRates { get; set; }
    public DbSet<GrowthRateExperienceLevel> GrowthRateExperienceLevels { get; set; }
    public DbSet<Nature> Natures { get; set; }
    public DbSet<NatureStatChange> NatureStatChanges { get; set; }
    public DbSet<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }
    public DbSet<PokeathlonStat> PokeathlonStats { get; set; }
    public DbSet<NaturePokeathlonStatAffectSets> NaturePokeathlonStatAffectSets { get; set; }
    public DbSet<NaturePokeathlonStatAffect> NaturePokeathlonStatAffects { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<PokemonAbility> PokemonAbilities { get; set; }
    public DbSet<PokemonType> PokemonTypes { get; set; }
    public DbSet<PokemonPastTypes> PokemonPastTypes { get; set; }
    public DbSet<PokemonHeldItem> PokemonHeldItems { get; set; }
    public DbSet<PokemonHeldItemVersion> PokemonHeldItemVersions { get; set; }
    public DbSet<PokemonStat> PokemonStats { get; set; }
    public DbSet<PokemonSprites> PokemonSprites { get; set; }
    public DbSet<LocationAreaEncounter> LocationAreaEncounters { get; set; }
    public DbSet<PokemonColor> PokemonColors { get; set; }
    public DbSet<PokemonForm> PokemonForms { get; set; }
    public DbSet<PokemonFormSprites> PokemonFormSprites { get; set; }
    public DbSet<AwesomeNames> AwesomeNames { get; set; }
    public DbSet<PokemonSpecies> PokemonSpecies { get; set; }
    public DbSet<PokemonSpeciesFlavorTexts> PokemonSpeciesFlavorTexts { get; set; }
    public DbSet<Genuses> Genuses { get; set; }
    public DbSet<PokemonSpeciesDexEntry> PokemonSpeciesDexEntries { get; set; }
    public DbSet<PalParkEncounterArea> PalParkEncounterAreas { get; set; }
    public DbSet<PokemonSpeciesVariety> PokemonSpeciesVarieties { get; set; }
    public DbSet<Stat> Stats { get; set; }
    public DbSet<MoveStatAffectSets> MoveStatAffectSets { get; set; }
    public DbSet<MoveStatAffect> MoveStatAffects { get; set; }
    public DbSet<NatureStatAffectSets> NatureStatAffectSets { get; set; }
    public DbSet<Type> Types { get; set; }
    public DbSet<TypePokemon> TypesPokemon { get; set; }
    #endregion
}
