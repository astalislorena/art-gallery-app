﻿// <auto-generated />
using System;
using ArtGallery_MVC.Model.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtGallery_MVC.Migrations
{
    [DbContext(typeof(ArtGalleryDbContext))]
    partial class ArtGalleryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ArtGallery_MVP.Models.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("instutution");
                });

            modelBuilder.Entity("ArtGallery_MVP.Models.Painting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ArtistName")
                        .HasColumnType("text");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("integer");

                    b.Property<string>("Technique")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("painting");
                });

            modelBuilder.Entity("ArtGallery_MVP.Models.Sculpture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ArtistName")
                        .HasColumnType("text");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("sculpture");
                });

            modelBuilder.Entity("ArtGallery_MVP.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("user");
                });

            modelBuilder.Entity("ArtGallery_MVP.Models.Painting", b =>
                {
                    b.HasOne("ArtGallery_MVP.Models.Institution", null)
                        .WithMany("Paintings")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("ArtGallery_MVP.Models.Sculpture", b =>
                {
                    b.HasOne("ArtGallery_MVP.Models.Institution", null)
                        .WithMany("Sculptures")
                        .HasForeignKey("InstitutionId");
                });
#pragma warning restore 612, 618
        }
    }
}
