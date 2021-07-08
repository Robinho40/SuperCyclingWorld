﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialCyclingWorld.Web.Data;

namespace SuperCyclingWorld.Web.Migrations
{
    [DbContext(typeof(SCWDbContext))]
    [Migration("20210707142018_OnlyClubsInSeed")]
    partial class OnlyClubsInSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clubnaam");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), Clubnaam = "WTC" },
                        new { Id = new Guid("003522e7-75ae-4933-8866-bc51ac40c7c8"), Clubnaam = "DCTV" },
                        new { Id = new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), Clubnaam = "De lustige rijders" },
                        new { Id = new Guid("6bfead80-db2a-47ea-973b-43405cc34365"), Clubnaam = "WTC Melsele" },
                        new { Id = new Guid("5a12238b-0059-4302-a128-d7992a90f848"), Clubnaam = "The master cyclists" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.ClubSupporter", b =>
                {
                    b.Property<Guid>("ClubId");

                    b.Property<Guid>("SupporterId");

                    b.HasKey("ClubId", "SupporterId");

                    b.HasIndex("SupporterId");

                    b.ToTable("ClubSupporter");

                    b.HasData(
                        new { ClubId = new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), SupporterId = new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c") },
                        new { ClubId = new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), SupporterId = new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23") }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.FanRegistratie", b =>
                {
                    b.Property<Guid>("SupporterId");

                    b.Property<Guid>("WielrennerId");

                    b.HasKey("SupporterId", "WielrennerId");

                    b.HasIndex("WielrennerId");

                    b.ToTable("FanRegistratie");

                    b.HasData(
                        new { SupporterId = new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"), WielrennerId = new Guid("2c81cf54-856a-4132-97c9-4ce658a22823") },
                        new { SupporterId = new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"), WielrennerId = new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef") }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Fiets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Merk");

                    b.Property<Guid>("WielrennerId");

                    b.Property<string>("Zadel");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Fietsen");

                    b.HasData(
                        new { Id = new Guid("03d04a9c-3993-4310-92ff-2e0b6a67c831"), Merk = "B-Twin", WielrennerId = new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("5b411043-94c1-4b7c-954d-0a1ea059fd5f"), Merk = "Moldava", WielrennerId = new Guid("2c55f044-a026-42fc-8828-97abf1a8f1f9"), Zadel = "Geel zadel" },
                        new { Id = new Guid("038cc5ab-ce6e-4cb0-b410-fcb7eee948cd"), Merk = "Merckx", WielrennerId = new Guid("2c81cf54-856a-4132-97c9-4ce658a22823"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Supporter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<string>("Paswoord");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.ToTable("Supporters");

                    b.HasData(
                        new { Id = new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"), Achternaam = "The Pooh", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Winnie" },
                        new { Id = new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c"), Achternaam = "Van Achtmaal", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Thomas" },
                        new { Id = new Guid("6e0cf97a-22bb-455c-9aea-d420b9203c45"), Achternaam = "VanKerkhove", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Nico" },
                        new { Id = new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"), Achternaam = "Kronenburg", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Koen" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<Guid>("ClubId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<string>("Paswoord");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("2c55f044-a026-42fc-8828-97abf1a8f1f9"), Achternaam = "Franckaert", ClubId = new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Robin" },
                        new { Id = new Guid("2c81cf54-856a-4132-97c9-4ce658a22823"), Achternaam = "Jansma", ClubId = new Guid("003522e7-75ae-4933-8866-bc51ac40c7c8"), GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Johanna" },
                        new { Id = new Guid("825bed50-454c-4457-bf6a-8d69366926e7"), Achternaam = "Vissers", ClubId = new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Bert" },
                        new { Id = new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef"), Achternaam = "Depardieu", ClubId = new Guid("6bfead80-db2a-47ea-973b-43405cc34365"), GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Gerard" },
                        new { Id = new Guid("f4bbf781-6e81-4b06-ab11-a121ed5fca94"), Achternaam = "Van Overmeire", ClubId = new Guid("5a12238b-0059-4302-a128-d7992a90f848"), GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Marc" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.ClubSupporter", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club")
                        .WithMany("ClubSupporters")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Supporter")
                        .WithMany("Clubs")
                        .HasForeignKey("SupporterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.FanRegistratie", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Supporter")
                        .WithMany("Wielrenners")
                        .HasForeignKey("SupporterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner")
                        .WithMany("Wielrenners")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Fiets", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner")
                        .WithMany("Fietsen")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}