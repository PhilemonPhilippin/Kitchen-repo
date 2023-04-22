﻿// <auto-generated />
using System;
using Kitchen.Dal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kitchen.Dal.Migrations
{
    [DbContext(typeof(KitchenContext))]
    partial class KitchenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

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
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9466),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9466),
                            Name = "Eggs"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0002-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9474),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9474),
                            Name = "Bacon"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0003-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9475),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9476),
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0004-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9477),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9477),
                            Name = "Spaghettis"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0005-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9479),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9479),
                            Name = "Guanciale"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0006-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9481),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9481),
                            Name = "Pecorino romano"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0007-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9482),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9483),
                            Name = "Tomatoes"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0008-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9484),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9485),
                            Name = "Beef"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0009-0000-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9486),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9486),
                            Name = "Pasta"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.PreparationStep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

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
                            Id = new Guid("d10b9555-89d4-41d1-9f9f-b79685f8720d"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9752),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9752),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Cook the eggs",
                            StepNumber = 1,
                            Title = "Cook eggs"
                        },
                        new
                        {
                            Id = new Guid("c18c2dd8-b519-4e6a-b565-7dff0205816d"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9755),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9755),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Cook the bacon",
                            StepNumber = 2,
                            Title = "Cook bacon"
                        },
                        new
                        {
                            Id = new Guid("f6902172-eab3-4c6a-82b7-5e6a8aa24bda"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9757),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9758),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            Step = "Fry the bread",
                            StepNumber = 3,
                            Title = "Fry bread"
                        },
                        new
                        {
                            Id = new Guid("f171fb68-ec05-41d6-bd82-8a6f86dde823"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9760),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9760),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            Step = "Cook the guanciale",
                            StepNumber = 1,
                            Title = "Cook guanciale"
                        },
                        new
                        {
                            Id = new Guid("e77f5d3d-2f7e-41de-864d-462fcbba2be7"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9774),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9774),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            Step = "Cook the spaghetti",
                            StepNumber = 2,
                            Title = "Cook spaghetti"
                        },
                        new
                        {
                            Id = new Guid("77453b9a-d280-46f7-9c2c-97e373beb347"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9776),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9776),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            Step = "Fry the bacon",
                            StepNumber = 1,
                            Title = "Fry bacon"
                        },
                        new
                        {
                            Id = new Guid("83a983fe-cd31-49e1-931c-f1159d709224"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9778),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9779),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            Step = "Cook the eggs",
                            StepNumber = 2,
                            Title = "Cook eggs"
                        },
                        new
                        {
                            Id = new Guid("da450b8c-3871-40a7-baf2-cff40a9c1a11"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9781),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9781),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            Step = "Cook the beef and the bacon",
                            StepNumber = 1,
                            Title = "Cook beef and bacon"
                        },
                        new
                        {
                            Id = new Guid("697b1ce9-3742-46a3-b4d3-1aac1c85ccc3"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9783),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9783),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            Step = "Cook the spaghetti",
                            StepNumber = 2,
                            Title = "Cook spaghetti"
                        },
                        new
                        {
                            Id = new Guid("a0705644-1f40-4584-a099-febdc5c6ebfc"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9785),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9786),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            Step = "Prepare the bolognese",
                            StepNumber = 1,
                            Title = "Prepare bolognese"
                        },
                        new
                        {
                            Id = new Guid("936aaca7-e338-4dc4-a0b1-d1cec09e9f7e"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9788),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9788),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            Step = "Prepare the bechamel",
                            StepNumber = 2,
                            Title = "Prepare bechamel"
                        },
                        new
                        {
                            Id = new Guid("a7507924-f063-4ace-82ae-f3b547c83679"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9790),
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9791),
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

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

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
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9432),
                            Description = "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9432),
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "English breakfast"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9436),
                            Description = "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9436),
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Spaghetti carbonara"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0003-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9440),
                            Description = "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9441),
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Club sandwich"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9443),
                            Description = "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9444),
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Spaghetti bolognese"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0005-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9447),
                            Description = "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9447),
                            RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Lasagna bolognese"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.RecipeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

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
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9147),
                            Description = "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9149),
                            Title = "Breakfast"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9150),
                            Description = "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9151),
                            Title = "Lunch"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9153),
                            Description = "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9153),
                            Title = "Dinner"
                        });
                });

            modelBuilder.Entity("Kitchen.Entities.RecipeIngredient", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("IngredientQuantity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredient");

                    b.HasData(
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9665),
                            IngredientQuantity = "2 whole",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9665)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9667),
                            IngredientQuantity = "100 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9668)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9669),
                            IngredientQuantity = "2 slices",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9670)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0001-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9671),
                            IngredientQuantity = "1 whole",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9672)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9673),
                            IngredientQuantity = "1 whole",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9674)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9676),
                            IngredientQuantity = "500 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9676)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0005-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9678),
                            IngredientQuantity = "200 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9678)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0006-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0002-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9680),
                            IngredientQuantity = "50 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9680)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9682),
                            IngredientQuantity = "75 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9682)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9684),
                            IngredientQuantity = "4 slices",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9684)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0003-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9686),
                            IngredientQuantity = "1 whole",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9687)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9689),
                            IngredientQuantity = "500 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9689)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9691),
                            IngredientQuantity = "100 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9691)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9693),
                            IngredientQuantity = "3 tins of crushed tomatoes",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9694)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0004-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9695),
                            IngredientQuantity = "250 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9696)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9697),
                            IngredientQuantity = "2 tins of crushed tomatoes",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9698)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9699),
                            IngredientQuantity = "300 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9700)
                        },
                        new
                        {
                            IngredientId = new Guid("00000000-0000-0009-0000-000000000000"),
                            RecipeId = new Guid("00000000-0000-0000-0005-000000000000"),
                            CreatedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9702),
                            IngredientQuantity = "250 g.",
                            ModifiedOn = new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9702)
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
