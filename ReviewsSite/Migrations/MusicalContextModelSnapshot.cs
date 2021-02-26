﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(MusicalContext))]
    partial class MusicalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Musical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musicals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A tale of two friends who happen to be witches. Hijinks ensue.",
                            Genre = "Drama",
                            Title = "Wicked"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A tale of two friends who happen to be prisoners. Hijinks ensue.",
                            Genre = "Drama",
                            Title = "Chicago"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A tale of two friends who happen to be political rivals and founders of a nation. Hijinks ensue.",
                            Genre = "Historical",
                            Title = "Hamilton"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A tale of the last days of Jesus. Hijinks ensue.",
                            Genre = "Drama",
                            Title = "Jesus Christ Superstar"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A tale of two brothers who happen to be lions. Hijinks ensue.",
                            Genre = "Family",
                            Title = "The Lion King"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A tale of roommates in the city. Hijinks ensue.",
                            Genre = "Drama",
                            Title = "Rent"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A tale of two Mormons who happen to be missionaries. Hijinks really ensue.",
                            Genre = "Comedy",
                            Title = "The Book of Mormon"
                        },
                        new
                        {
                            Id = 8,
                            Description = "A tale of many cats who happen to be magical. Hijinks ensue.",
                            Genre = "Drama",
                            Title = "Cats"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MusicalId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusicalId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I had the time of my life my life!",
                            MusicalId = 1,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            Content = "Wowza!",
                            MusicalId = 2,
                            Rating = 4
                        },
                        new
                        {
                            Id = 3,
                            Content = "It was a non-stop thrill ride!",
                            MusicalId = 1,
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            Content = "Razzle Dazzle!",
                            MusicalId = 2,
                            Rating = 4
                        },
                        new
                        {
                            Id = 5,
                            Content = "Inspirational!",
                            MusicalId = 4,
                            Rating = 4
                        },
                        new
                        {
                            Id = 6,
                            Content = "A roaring good time!",
                            MusicalId = 5,
                            Rating = 4
                        },
                        new
                        {
                            Id = 7,
                            Content = "Great!",
                            MusicalId = 6,
                            Rating = 4
                        },
                        new
                        {
                            Id = 8,
                            Content = "Don't go with your parents! There will be awkwardness.",
                            MusicalId = 7,
                            Rating = 4
                        },
                        new
                        {
                            Id = 9,
                            Content = "Memories will be made! Purrfect!",
                            MusicalId = 8,
                            Rating = 4
                        },
                        new
                        {
                            Id = 10,
                            Content = "Amazing!",
                            MusicalId = 3,
                            Rating = 4
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Musical", "Musical")
                        .WithMany("Reviews")
                        .HasForeignKey("MusicalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musical");
                });

            modelBuilder.Entity("ReviewsSite.Models.Musical", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
