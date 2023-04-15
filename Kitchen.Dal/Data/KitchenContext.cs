namespace Kitchen.Dal.Data;

public class KitchenContext : DbContext
{
    public KitchenContext(DbContextOptions<KitchenContext> options) : base(options)
    {
    }

    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
    public DbSet<PreparationStep> PreparationSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite PK
        modelBuilder.Entity<RecipeIngredients>().HasKey(ir => new {ir.IngredientId,ir.RecipeId});

        // Many-to-Many
        modelBuilder.Entity<RecipeIngredients>()
            .HasOne(ir => ir.Ingredient)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.IngredientId);

        modelBuilder.Entity<RecipeIngredients>()
            .HasOne(ir => ir.Recipe)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.RecipeId);

        modelBuilder.Seed();
    }
}
