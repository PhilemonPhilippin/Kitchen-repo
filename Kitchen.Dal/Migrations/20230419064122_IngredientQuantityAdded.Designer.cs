﻿// <auto-generated />
using System;
using Kitchen.Dal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kitchen.Dal.Migrations
{
    [DbContext(typeof(KitchenContext))]
    [Migration("20230419064122_IngredientQuantityAdded")]
    partial class IngredientQuantityAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kitchen.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0001-0000-000000000000"),
                            Name = "Eggs"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0002-0000-000000000000"),
                            Name = "Bacon"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0003-0000-000000000000"),
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0004-0000-000000000000"),
                            Name = "Spaghettis"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0005-0000-000000000000"),
                            Name = "Guanciale"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0006-0000-000000000000"),
                            Name = "Pecorino romano"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0007-0000-000000000000"),
                            Name = "Tomatoes"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0008-0000-000000000000"),
                            Name = "Beef"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0009-0000-000000000000"),
                            Name = "Pasta"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.PreparationStep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Step")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("PreparationStep");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4631a1e-b36f-4fe6-ad0b-1c68ca83491d"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Cook the eggs",
                            StepNumber = 1,
                            Title = "Cook eggs"
                        },
                        new
                        {
                            Id = new Guid("da4a68d1-7c18-4c86-826a-ce6651b49e11"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Cook the bacon",
                            StepNumber = 2,
                            Title = "Cook bacon"
                        },
                        new
                        {
                            Id = new Guid("0f923e74-5c88-4c77-84d6-f30aa8c3467c"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Fry the bread",
                            StepNumber = 3,
                            Title = "Fry bread"
                        },
                        new
                        {
                            Id = new Guid("da3c28dc-0986-43d7-8776-9406b8a84316"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            Step = "Cook the guanciale",
                            StepNumber = 1,
                            Title = "Cook guanciale"
                        },
                        new
                        {
                            Id = new Guid("cd98a3ba-c379-4298-b086-4191842807f8"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            Step = "Cook the spaghetti",
                            StepNumber = 2,
                            Title = "Cook spaghetti"
                        },
                        new
                        {
                            Id = new Guid("47073443-4c87-439b-bcfc-180150aa2c32"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            Step = "Fry the bacon",
                            StepNumber = 1,
                            Title = "Fry bacon"
                        },
                        new
                        {
                            Id = new Guid("93ebf5c1-9b19-4147-8511-28299c37d4ad"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            Step = "Cook the eggs",
                            StepNumber = 2,
                            Title = "Cook eggs"
                        },
                        new
                        {
                            Id = new Guid("2e47d757-562f-4b3d-ac62-ca97929d1bfd"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            Step = "Cook the beef and the bacon",
                            StepNumber = 1,
                            Title = "Cook beef and bacon"
                        },
                        new
                        {
                            Id = new Guid("fa214c86-eaf1-41a3-b163-bbf94b9415ed"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            Step = "Cook the spaghetti",
                            StepNumber = 2,
                            Title = "Cook spaghetti"
                        },
                        new
                        {
                            Id = new Guid("f6b26804-3802-45ca-9c31-0e81d9850a5e"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            Step = "Prepare the bolognese",
                            StepNumber = 1,
                            Title = "Prepare bolognese"
                        },
                        new
                        {
                            Id = new Guid("b530b834-c4a1-40c6-8406-c600b02be770"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            Step = "Prepare the bechamel",
                            StepNumber = 2,
                            Title = "Prepare bechamel"
                        },
                        new
                        {
                            Id = new Guid("beae6240-0f85-486e-aeb7-26317a6a16f5"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            Step = "Prepare the lasagna and place it in the oven.",
                            StepNumber = 3,
                            Title = "Prepare lasagna"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("RecipeCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeCategoryId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0001-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2080),
                            Description = "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.",
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "English breakfast"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2085),
                            Description = "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.",
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Spaghetti carbonara"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0003-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2157),
                            Description = "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.",
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Club sandwich"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2161),
                            Description = "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.",
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Spaghetti bolognese"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0005-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2166),
                            Description = "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.",
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Lasagna bolognese"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.RecipeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RecipeCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.",
                            Title = "Breakfast"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.",
                            Title = "Lunch"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner.",
                            Title = "Dinner"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.RecipeIngredient", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IngredientQuantity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredient");

                    b.HasData(
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            IngredientQuantity = "2 whole"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            IngredientQuantity = "100 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            IngredientQuantity = "2 slices"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            IngredientQuantity = "1 whole"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            IngredientQuantity = "1 whole"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            IngredientQuantity = "500 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0005-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            IngredientQuantity = "200 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0006-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            IngredientQuantity = "50 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            IngredientQuantity = "75 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            IngredientQuantity = "4 slices"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            IngredientQuantity = "1 whole"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            IngredientQuantity = "500 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            IngredientQuantity = "100 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            IngredientQuantity = "3 tins of crushed tomatoes"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            IngredientQuantity = "250 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            IngredientQuantity = "2 tins of crushed tomatoes"
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            IngredientQuantity = "300 g."
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0009-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            IngredientQuantity = "250 g."
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.PreparationStep", b =>
                {
                    b.HasOne("Kitchen.Entities.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Kitchen.Entities.Recipe", b =>
                {
                    b.HasOne("Kitchen.Entities.RecipeCategory", "RecipeCategory")
                        .WithMany()
                        .HasForeignKey("RecipeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecipeCategory");
                });

            modelBuilder.Entity("Kitchen.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("Kitchen.Entities.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kitchen.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Kitchen.Entities.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Kitchen.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
