﻿// <auto-generated />
using CatLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatLib.Migrations
{
    [DbContext(typeof(CatLibContext))]
    [Migration("20220727063309_CatLibV1")]
    partial class CatLibV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatLib.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grooming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Health")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("CatLib.Models.MainSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Life_Expectancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Litter_Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("MainSpecifications");
                });

            modelBuilder.Entity("CatLib.Models.OtherSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Activity")
                        .HasColumnType("int");

                    b.Property<int>("Affection")
                        .HasColumnType("int");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<int>("Docility")
                        .HasColumnType("int");

                    b.Property<int>("Friendliness_To_Childern")
                        .HasColumnType("int");

                    b.Property<int>("Friendliness_To_Pets")
                        .HasColumnType("int");

                    b.Property<int>("Grooming")
                        .HasColumnType("int");

                    b.Property<int>("Hardiness")
                        .HasColumnType("int");

                    b.Property<int>("Independence")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Playfulness")
                        .HasColumnType("int");

                    b.Property<int>("Vocality")
                        .HasColumnType("int");

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

            modelBuilder.Entity("CatLib.Models.MainSpecification", b =>
                {
                    b.HasOne("CatLib.Models.Cat", "Cat")
                        .WithOne("MainSpecification")
                        .HasForeignKey("CatLib.Models.MainSpecification", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
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

            modelBuilder.Entity("CatLib.Models.Cat", b =>
                {
                    b.Navigation("MainSpecification");

                    b.Navigation("OtherSpecification");

                    b.Navigation("PhysicalSpecification");
                });
#pragma warning restore 612, 618
        }
    }
}