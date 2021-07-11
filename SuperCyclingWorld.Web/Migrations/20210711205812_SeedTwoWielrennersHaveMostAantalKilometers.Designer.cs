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
    [Migration("20210711205812_SeedTwoWielrennersHaveMostAantalKilometers")]
    partial class SeedTwoWielrennersHaveMostAantalKilometers
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

                    b.Property<int>("AantalRecords");

                    b.Property<Guid?>("Clubleider");

                    b.Property<string>("Clubnaam");

                    b.Property<int>("Oprichtingsjaar");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), AantalRecords = 0, Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), AantalRecords = 0, Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), AantalRecords = 0, Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), AantalRecords = 0, Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), AantalRecords = 0, Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), SupporterId = new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                        new { ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                        new { ClubId = new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                        new { ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                        new { ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                        new { ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                        new { ClubId = new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), SupporterId = new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") },
                        new { ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), SupporterId = new Guid("2a256162-f9ba-48f4-aa40-6049dd844294") },
                        new { ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), SupporterId = new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                        new { ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), SupporterId = new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") }
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
                        new { SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), WielrennerId = new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                        new { SupporterId = new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), WielrennerId = new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") },
                        new { SupporterId = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), WielrennerId = new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3") },
                        new { SupporterId = new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), WielrennerId = new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                        new { SupporterId = new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), WielrennerId = new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a") },
                        new { SupporterId = new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), WielrennerId = new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") }
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
                        new { Id = new Guid("7328fc02-3a93-4fc8-a781-8b7db9d539a5"), Merk = "B-Twin", WielrennerId = new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("c810e934-261a-4089-af76-83650a0fd0fa"), Merk = "Moldava", WielrennerId = new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), Zadel = "Geel zadel" },
                        new { Id = new Guid("6c8b4320-cc47-4ed1-8f7a-f3faaafdb2b7"), Merk = "Merckx", WielrennerId = new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecordCijfer");

                    b.Property<string>("RecordEenheid");

                    b.Property<int>("RecordType");

                    b.Property<string>("Recordnaam");

                    b.Property<string>("Thropy");

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Rit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aankomst");

                    b.Property<string>("Name");

                    b.Property<Guid>("PersoonId");

                    b.Property<string>("Start");

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Ritten");
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
                        new { Id = new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("2c3f1a86-5d39-4c31-8efc-c74c3f61c42d"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("fa2521b0-1f7f-4204-b425-b6a387ba3e89"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("f7bf8e60-53c2-4f4e-af3c-f5880096f70a"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("8219f84b-1c79-46ec-8c4e-3dfc7b4757e9"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("d2a31910-5dda-4288-95c2-b0f9ba408605"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("75a36637-99a0-4d3c-9715-7db08798a2dc"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("5abc3233-0e2e-472e-8de3-dff7cc79647c"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("4714c8da-c92d-47a5-9af5-7a2c1f7b4e32"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AantalRecords");

                    b.Property<string>("Achternaam");

                    b.Property<Guid>("ClubId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<double>("GemiddeldKm_h");

                    b.Property<int>("GemiddeldeKM_Rit");

                    b.Property<string>("Paswoord");

                    b.Property<int>("TotaalAantalGeredenKilometers");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), AantalRecords = 0, Achternaam = "Franckaert", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 15.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Robin" },
                        new { Id = new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), AantalRecords = 0, Achternaam = "Jansma", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 33.8, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 260, Voornaam = "Johanna" },
                        new { Id = new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), AantalRecords = 0, Achternaam = "Vissers", ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.6, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 301, Voornaam = "Bert" },
                        new { Id = new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132"), AantalRecords = 0, Achternaam = "Depardieu", ClubId = new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 85, Voornaam = "Gerard" },
                        new { Id = new Guid("58e5ae1e-17a6-4681-a4a9-bf7c7a553d7c"), AantalRecords = 0, Achternaam = "Van Overmeire", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 41.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 256, Voornaam = "Marc" },
                        new { Id = new Guid("abef85e4-075f-4c95-ab79-34462e40a430"), AantalRecords = 0, Achternaam = "Camara", ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.51, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 504, Voornaam = "Herdy" },
                        new { Id = new Guid("a0988b94-0be3-4c94-8716-b4b386d38368"), AantalRecords = 0, Achternaam = "Donckerwolcke", ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1100, Voornaam = "Thomas" },
                        new { Id = new Guid("6ff39d7e-9dc7-4f1c-9d84-ddef3748f5e2"), AantalRecords = 0, Achternaam = "Garnaal", ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 42.1, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 250, Voornaam = "Sofie" },
                        new { Id = new Guid("b97a66dd-5e23-4a5f-a305-df433c8f7865"), AantalRecords = 0, Achternaam = "Brokkenpap", ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 125, Voornaam = "Berend" },
                        new { Id = new Guid("fe1adc9c-36b9-42bd-9088-259260a1ec78"), AantalRecords = 0, Achternaam = "Mega", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 42.15, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 568, Voornaam = "Mindy" },
                        new { Id = new Guid("9a82887f-5832-4ac5-af9f-9f90686213d3"), AantalRecords = 0, Achternaam = "Scarlet", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.5, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 308, Voornaam = "Johanson" },
                        new { Id = new Guid("72205c80-f5d8-4a91-86de-84a10d0ec7e3"), AantalRecords = 0, Achternaam = "Beukelaer", ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 23.6, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Koekjes" },
                        new { Id = new Guid("1dbf2afc-6418-4a3a-9979-320f6a394f2d"), AantalRecords = 0, Achternaam = "Mertens", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.65, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Evelyne" },
                        new { Id = new Guid("fb4c24fb-3a10-4e51-95f4-4173033395db"), AantalRecords = 0, Achternaam = "VanHoof", ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 29.55, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 306, Voornaam = "Emily" },
                        new { Id = new Guid("ec268c16-3bcd-46e9-8573-dac50d0b16ed"), AantalRecords = 0, Achternaam = "Vanderplas", ClubId = new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 33.6, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 59, Voornaam = "Sonja" },
                        new { Id = new Guid("4233cb5b-f66a-4dd4-a712-d3053b0471a2"), AantalRecords = 0, Achternaam = "Bambino", ClubId = new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 44.2, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 257, Voornaam = "Salvatore" },
                        new { Id = new Guid("a789d598-b574-449a-8b16-27fa3d4e8ffb"), AantalRecords = 0, Achternaam = "Zalinski", ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 31.6, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 233, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("341cdc06-a248-4304-b919-a5801e936539"), AantalRecords = 0, Achternaam = "Debruyne", ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 15.9, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 450, Voornaam = "Kevin" },
                        new { Id = new Guid("5534f506-e85c-4012-a113-9c49b05983fc"), AantalRecords = 0, Achternaam = "Hazard", ClubId = new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 44.2, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 23, Voornaam = "Eden" },
                        new { Id = new Guid("5575eaf1-d828-46b2-bde1-861a5f6292db"), AantalRecords = 0, Achternaam = "Evenepoel", ClubId = new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 12.53, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Remco" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.WielrennerRecords", b =>
                {
                    b.Property<Guid>("RecordId");

                    b.Property<Guid>("WielrennerId");

                    b.HasKey("RecordId", "WielrennerId");

                    b.HasIndex("WielrennerId");

                    b.ToTable("WielrennerRecords");
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

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany()
                        .HasForeignKey("WielrennerId");
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Rit", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany("Ritten")
                        .HasForeignKey("WielrennerId");
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club", "Club")
                        .WithMany("Leden")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.WielrennerRecords", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Record", "Record")
                        .WithMany("WielrennerRecords")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany("Records")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
