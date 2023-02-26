namespace Kitchen.Dal.Data;

public class KitchenContext : DbContext
{
    public KitchenContext(DbContextOptions<KitchenContext> options) : base(options)
    {
    }

    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<IngredientRecipe> IngredientRecipes { get; set; }
    public DbSet<PreparationStep> PreparationSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite PK
        modelBuilder.Entity<IngredientRecipe>().HasKey(ir => new {ir.IngredientId,ir.RecipeId});

        // Many-to-Many
        modelBuilder.Entity<IngredientRecipe>()
            .HasOne(ir => ir.Ingredient)
            .WithMany(ir => ir.IngredientRecipes)
            .HasForeignKey(ir => ir.IngredientId);

        modelBuilder.Entity<IngredientRecipe>()
            .HasOne(ir => ir.Recipe)
            .WithMany(ir => ir.IngredientRecipes)
            .HasForeignKey(ir => ir.RecipeId);

        modelBuilder.Seed();
    }
}
