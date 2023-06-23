namespace Kitchen.Dal.Data;

public class KitchenContext : DbContext
{
    public KitchenContext(DbContextOptions<KitchenContext> options) : base(options)
    {
    }

    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<PreparationStep> PreparationSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite PK
        modelBuilder.Entity<RecipeIngredient>().HasKey(ir => new {ir.IngredientId,ir.RecipeId});

        // Many-to-Many
        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ir => ir.Ingredient)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.IngredientId);

        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ir => ir.Recipe)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.RecipeId);

        // Unique
        modelBuilder.Entity<Ingredient>().HasIndex(i => i.Name).IsUnique();

        modelBuilder.Seed();
    }
}
