﻿// <auto-generated />
using System;
using CatLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatLib.Migrations
{
    [DbContext(typeof(CatLibContext))]
    partial class CatLibContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatGeneratorNameCatGeneratorType", b =>
                {
                    b.Property<int>("CatGeneratorNamesId")
                        .HasColumnType("int");

                    b.Property<int>("CatGeneratorTypesId")
                        .HasColumnType("int");

                    b.HasKey("CatGeneratorNamesId", "CatGeneratorTypesId");

                    b.HasIndex("CatGeneratorTypesId");

                    b.ToTable("CatGeneratorNameCatGeneratorType");
                });

            modelBuilder.Entity("CatLib.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("CatLib.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hypoallergenic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intelligence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Playfulness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shedding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("CatLib.Models.CompatibilityDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Friendliness_To_Cat_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Childern_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Dog_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Old_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grooming_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vocality_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("CompatibilityDescription");
                });

            modelBuilder.Entity("CatLib.Models.MainSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heigh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Life_Expectancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Litter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("MainSpecifications");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.CatGeneratorName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("HairId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("GenderId");

                    b.HasIndex("HairId");

                    b.HasIndex("PersonalityId");

                    b.ToTable("CatGeneratorNames");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.CatGeneratorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CatGeneratorTypes");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Hair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hair");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Personality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personality");
                });

            modelBuilder.Entity("CatLib.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("CatLib.Models.OtherSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Care_Maintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Choosing_Kitten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Cat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Childern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Dog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friendliness_To_Old")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grooming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Health")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitty_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nicknames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other_Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Short_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vocality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("OtherSpecifications");
                });

            modelBuilder.Entity("CatLib.Models.PhysicalSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Coat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ears")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eyes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Legs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("PhysicalSpecifications");
                });

            modelBuilder.Entity("CatLib.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CatLib.Models.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CatLib.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("CatLib.Models.TemperamentDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affection_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Intelligence_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Playfulness_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("TemperamentDescriptions");
                });

            modelBuilder.Entity("CatLib.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CatGeneratorNameCatGeneratorType", b =>
                {
                    b.HasOne("CatLib.Models.NameGenerator.CatGeneratorName", null)
                        .WithMany()
                        .HasForeignKey("CatGeneratorNamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatLib.Models.NameGenerator.CatGeneratorType", null)
                        .WithMany()
                        .HasForeignKey("CatGeneratorTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CatLib.Models.Answer", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithMany("Answers")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatLib.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("CatLib.Models.CompatibilityDescription", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("CompatibilityDescription")
                        .HasForeignKey("CatLib.Models.CompatibilityDescription", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatLib.Models.MainSpecification", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("MainSpecification")
                        .HasForeignKey("CatLib.Models.MainSpecification", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.CatGeneratorName", b =>
                {
                    b.HasOne("CatLib.Models.NameGenerator.Color", "Color")
                        .WithMany("CatGeneratorNames")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatLib.Models.NameGenerator.Gender", "Gender")
                        .WithMany("CatGeneratorNames")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatLib.Models.NameGenerator.Hair", "Hair")
                        .WithMany("CatGeneratorNames")
                        .HasForeignKey("HairId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatLib.Models.NameGenerator.Personality", "Personality")
                        .WithMany("CatGeneratorNames")
                        .HasForeignKey("PersonalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Gender");

                    b.Navigation("Hair");

                    b.Navigation("Personality");
                });

            modelBuilder.Entity("CatLib.Models.OtherSpecification", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("OtherSpecification")
                        .HasForeignKey("CatLib.Models.OtherSpecification", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatLib.Models.PhysicalSpecification", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("PhysicalSpecification")
                        .HasForeignKey("CatLib.Models.PhysicalSpecification", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatLib.Models.Products.Product", b =>
                {
                    b.HasOne("CatLib.Models.Products.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("CatLib.Models.TemperamentDescription", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("TemperamentDescription")
                        .HasForeignKey("CatLib.Models.TemperamentDescription", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CatLib.Models.Cat", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("CompatibilityDescription");

                    b.Navigation("MainSpecification");

                    b.Navigation("OtherSpecification");

                    b.Navigation("PhysicalSpecification");

                    b.Navigation("TemperamentDescription");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Color", b =>
                {
                    b.Navigation("CatGeneratorNames");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Gender", b =>
                {
                    b.Navigation("CatGeneratorNames");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Hair", b =>
                {
                    b.Navigation("CatGeneratorNames");
                });

            modelBuilder.Entity("CatLib.Models.NameGenerator.Personality", b =>
                {
                    b.Navigation("CatGeneratorNames");
                });

            modelBuilder.Entity("CatLib.Models.Products.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CatLib.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
