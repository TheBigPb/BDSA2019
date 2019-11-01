﻿// <auto-generated />
using System;
using BDSA2019.Lecture08.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BDSA2019.Lecture08.Entities.Migrations
{
    [DbContext(typeof(SuperheroContext))]
    [Migration("20191030213457_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Metropolis"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gotham City"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Atlantis"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Themyscira"
                        },
                        new
                        {
                            Id = 5,
                            Name = "New York City"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Central City"
                        });
                });

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Powers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ability to breathe underwater"
                        },
                        new
                        {
                            Id = 2,
                            Name = "advanced technology"
                        },
                        new
                        {
                            Id = 3,
                            Name = "alien technology"
                        },
                        new
                        {
                            Id = 4,
                            Name = "brilliant deductive skills"
                        },
                        new
                        {
                            Id = 5,
                            Name = "combat skill"
                        },
                        new
                        {
                            Id = 6,
                            Name = "combat strategy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "control over sea life"
                        },
                        new
                        {
                            Id = 8,
                            Name = "durability"
                        },
                        new
                        {
                            Id = 9,
                            Name = "exceptional martial artist"
                        },
                        new
                        {
                            Id = 10,
                            Name = "exceptional swimming ability"
                        },
                        new
                        {
                            Id = 11,
                            Name = "flight"
                        },
                        new
                        {
                            Id = 12,
                            Name = "force fields"
                        },
                        new
                        {
                            Id = 13,
                            Name = "freeze breath"
                        },
                        new
                        {
                            Id = 14,
                            Name = "gymnastic ability"
                        },
                        new
                        {
                            Id = 15,
                            Name = "hard light constructs"
                        },
                        new
                        {
                            Id = 16,
                            Name = "healing factor"
                        },
                        new
                        {
                            Id = 17,
                            Name = "heat vision"
                        },
                        new
                        {
                            Id = 18,
                            Name = "inexhaustible wealth"
                        },
                        new
                        {
                            Id = 19,
                            Name = "instant weaponry"
                        },
                        new
                        {
                            Id = 20,
                            Name = "intangibility"
                        },
                        new
                        {
                            Id = 21,
                            Name = "intelligence"
                        },
                        new
                        {
                            Id = 22,
                            Name = "invulnerability"
                        },
                        new
                        {
                            Id = 23,
                            Name = "magic weaponry"
                        },
                        new
                        {
                            Id = 24,
                            Name = "super speed"
                        },
                        new
                        {
                            Id = 25,
                            Name = "super strength"
                        },
                        new
                        {
                            Id = 26,
                            Name = "superhuman agility"
                        },
                        new
                        {
                            Id = 27,
                            Name = "superhuman hearing"
                        },
                        new
                        {
                            Id = 28,
                            Name = "x-ray vision"
                        });
                });

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.Superhero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlterEgo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("FirstAppearance")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlterEgo = "Aquaman",
                            CityId = 1,
                            FirstAppearance = 1941,
                            Gender = "Male",
                            Name = "Arthur Curry",
                            Occupation = "King of Atlantis"
                        },
                        new
                        {
                            Id = 2,
                            AlterEgo = "Superman",
                            CityId = 1,
                            FirstAppearance = 1938,
                            Gender = "Male",
                            Name = "Clark Kent",
                            Occupation = "Reporter"
                        },
                        new
                        {
                            Id = 3,
                            AlterEgo = "Batman",
                            CityId = 2,
                            FirstAppearance = 1939,
                            Gender = "Male",
                            Name = "Bruce Wayne",
                            Occupation = "CEO of Wayne Enterprises"
                        },
                        new
                        {
                            Id = 4,
                            AlterEgo = "Wonder Woman",
                            CityId = 4,
                            FirstAppearance = 1941,
                            Gender = "Female",
                            Name = "Diana",
                            Occupation = "Amazon Princess"
                        },
                        new
                        {
                            Id = 5,
                            AlterEgo = "Green Lantern",
                            CityId = 5,
                            FirstAppearance = 1940,
                            Gender = "Male",
                            Name = "Hal Jordan",
                            Occupation = "Test pilot"
                        },
                        new
                        {
                            Id = 6,
                            AlterEgo = "The Flash",
                            CityId = 6,
                            FirstAppearance = 1940,
                            Gender = "Male",
                            Name = "Barry Allen",
                            Occupation = "Forensic scientist"
                        },
                        new
                        {
                            Id = 7,
                            AlterEgo = "Catwoman",
                            CityId = 2,
                            FirstAppearance = 1940,
                            Gender = "Female",
                            Name = "Selina Kyle",
                            Occupation = "Thief"
                        },
                        new
                        {
                            Id = 8,
                            AlterEgo = "Batwoman",
                            CityId = 2,
                            FirstAppearance = 1956,
                            Gender = "Female",
                            Name = "Kate Kane",
                            Occupation = "Thief"
                        },
                        new
                        {
                            Id = 9,
                            AlterEgo = "Supergirl",
                            CityId = 5,
                            FirstAppearance = 1959,
                            Gender = "Female",
                            Name = "Kara Zor-El",
                            Occupation = "Actress"
                        });
                });

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.SuperheroPower", b =>
                {
                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.Property<int>("PowerId")
                        .HasColumnType("int");

                    b.HasKey("SuperheroId", "PowerId");

                    b.HasIndex("PowerId");

                    b.ToTable("SuperheroPowers");

                    b.HasData(
                        new
                        {
                            SuperheroId = 1,
                            PowerId = 25
                        },
                        new
                        {
                            SuperheroId = 1,
                            PowerId = 8
                        },
                        new
                        {
                            SuperheroId = 1,
                            PowerId = 7
                        },
                        new
                        {
                            SuperheroId = 1,
                            PowerId = 10
                        },
                        new
                        {
                            SuperheroId = 1,
                            PowerId = 1
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 25
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 11
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 22
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 24
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 17
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 13
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 28
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 27
                        },
                        new
                        {
                            SuperheroId = 2,
                            PowerId = 16
                        },
                        new
                        {
                            SuperheroId = 3,
                            PowerId = 9
                        },
                        new
                        {
                            SuperheroId = 3,
                            PowerId = 6
                        },
                        new
                        {
                            SuperheroId = 3,
                            PowerId = 18
                        },
                        new
                        {
                            SuperheroId = 3,
                            PowerId = 4
                        },
                        new
                        {
                            SuperheroId = 3,
                            PowerId = 2
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 25
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 22
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 11
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 5
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 6
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 26
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 16
                        },
                        new
                        {
                            SuperheroId = 4,
                            PowerId = 23
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 15
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 19
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 12
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 11
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 8
                        },
                        new
                        {
                            SuperheroId = 5,
                            PowerId = 3
                        },
                        new
                        {
                            SuperheroId = 6,
                            PowerId = 24
                        },
                        new
                        {
                            SuperheroId = 6,
                            PowerId = 20
                        },
                        new
                        {
                            SuperheroId = 6,
                            PowerId = 26
                        },
                        new
                        {
                            SuperheroId = 7,
                            PowerId = 9
                        },
                        new
                        {
                            SuperheroId = 7,
                            PowerId = 14
                        },
                        new
                        {
                            SuperheroId = 7,
                            PowerId = 5
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 9
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 6
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 5
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 4
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 21
                        },
                        new
                        {
                            SuperheroId = 8,
                            PowerId = 2
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 25
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 11
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 22
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 24
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 17
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 13
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 28
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 27
                        },
                        new
                        {
                            SuperheroId = 9,
                            PowerId = 16
                        });
                });

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.Superhero", b =>
                {
                    b.HasOne("BDSA2019.Lecture08.Entities.City", "City")
                        .WithMany("Superheroes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BDSA2019.Lecture08.Entities.SuperheroPower", b =>
                {
                    b.HasOne("BDSA2019.Lecture08.Entities.Power", "Power")
                        .WithMany("Superheroes")
                        .HasForeignKey("PowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDSA2019.Lecture08.Entities.Superhero", "Superhero")
                        .WithMany("Powers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
