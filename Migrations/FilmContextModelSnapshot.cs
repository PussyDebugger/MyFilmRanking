﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFilmRanking.Models.ModelContext;

#nullable disable

namespace MyFilmRanking.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFilmRanking.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 25000000,
                            Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
                            Director = "Frank Darabont",
                            Genre = "prison drama film",
                            ImageUrl = "/Data/Images/download.jpg",
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 2,
                            Budget = 7200000,
                            Description = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.",
                            Director = "Francis Ford Coppola",
                            Genre = "epic crime film",
                            ImageUrl = "/Data/Images/download (1).jpg",
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            Budget = 185000000,
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Director = "Christopher Nolan",
                            Genre = "superhero film",
                            ImageUrl = "/Data/Images/download (2).jpg",
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 4,
                            Budget = 22000000,
                            Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            Director = "Steven Spielberg",
                            Genre = "epic historical drama",
                            ImageUrl = "/Data/Images/download (3).jpg",
                            Title = "Schindler's List"
                        },
                        new
                        {
                            Id = 5,
                            Budget = 94000000,
                            Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            Director = "Peter Jackson",
                            Genre = "epic fantasy adventure film ",
                            ImageUrl = "/Data/Images/download (4).jpg",
                            Title = "The Lord of the Rings: The Return of the King"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
