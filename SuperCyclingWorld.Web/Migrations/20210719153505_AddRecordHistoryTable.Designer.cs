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
    [Migration("20210719153505_AddRecordHistoryTable")]
    partial class AddRecordHistoryTable
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
                        new { Id = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), AantalRecords = 0, Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), AantalRecords = 0, Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), AantalRecords = 0, Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), AantalRecords = 0, Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), AantalRecords = 0, Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), SupporterId = new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") },
                        new { ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                        new { ClubId = new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                        new { ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                        new { ClubId = new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                        new { ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                        new { ClubId = new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), SupporterId = new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") },
                        new { ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), SupporterId = new Guid("bd3ba84e-3274-4589-885d-f0d00211593f") },
                        new { ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), SupporterId = new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") },
                        new { ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), SupporterId = new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") }
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
                        new { SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), WielrennerId = new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") },
                        new { SupporterId = new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), WielrennerId = new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") },
                        new { SupporterId = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), WielrennerId = new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee") },
                        new { SupporterId = new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"), WielrennerId = new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") },
                        new { SupporterId = new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), WielrennerId = new Guid("0d35d870-5781-4423-ad33-57fb4489dbae") },
                        new { SupporterId = new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"), WielrennerId = new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") }
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
                        new { Id = new Guid("565f2632-c5f2-4c6b-bdca-5d26dd31f296"), Merk = "B-Twin", WielrennerId = new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("c84761cc-c465-4f02-8c82-2772cd06e035"), Merk = "Moldava", WielrennerId = new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee"), Zadel = "Geel zadel" },
                        new { Id = new Guid("6dad5e18-83a1-4fc8-b2fc-436eae9ccd62"), Merk = "Merckx", WielrennerId = new Guid("0d35d870-5781-4423-ad33-57fb4489dbae"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecordCijfer");

                    b.Property<string>("RecordEenheid");

                    b.Property<Guid?>("RecordHistoryId");

                    b.Property<int>("RecordType");

                    b.Property<string>("Recordnaam");

                    b.Property<string>("Thropy");

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("Id");

                    b.HasIndex("RecordHistoryId");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Record");
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
                        new { Id = new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("55616386-bb6c-4d6c-a1db-ba0fd7f6123d"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("1be7c2a6-9ed6-488c-8676-fe75fe6c020b"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("d2149273-dfc8-4503-b33a-2f03cce7c93d"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("df702198-9f74-4350-82eb-3cea163631d0"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("b26127fd-2da8-4ebe-bcf8-9c61edcdbdfd"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("39035d25-c3ac-4d6e-b87b-4e3812780bee"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("465d6423-77e4-41ba-9ebe-ce0b72ee0383"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("9801abac-ce4a-40db-a9ac-899938ebf32e"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
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
                        new { Id = new Guid("0d35d870-5781-4423-ad33-57fb4489dbae"), AantalRecords = 0, Achternaam = "Franckaert", ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 31.0, GemiddeldeKM_Rit = 10, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 100, Voornaam = "Robin" },
                        new { Id = new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658"), AantalRecords = 0, Achternaam = "Jansma", ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 32.0, GemiddeldeKM_Rit = 20, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 101, Voornaam = "Johanna" },
                        new { Id = new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee"), AantalRecords = 0, Achternaam = "Vissers", ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 33.0, GemiddeldeKM_Rit = 30, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 102, Voornaam = "Bert" },
                        new { Id = new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9"), AantalRecords = 0, Achternaam = "Depardieu", ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 34.0, GemiddeldeKM_Rit = 40, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Gerard" },
                        new { Id = new Guid("155072b2-a97a-4abc-b87c-4173648595ac"), AantalRecords = 0, Achternaam = "Van Overmeire", ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 35.0, GemiddeldeKM_Rit = 50, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 104, Voornaam = "Marc" },
                        new { Id = new Guid("24917aeb-bb69-4c9f-9d04-4931098519ee"), AantalRecords = 0, Achternaam = "Camara", ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 36.0, GemiddeldeKM_Rit = 60, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 105, Voornaam = "Herdy" },
                        new { Id = new Guid("c7b59b49-b37a-456f-ad31-52819bcb74be"), AantalRecords = 0, Achternaam = "Donckerwolcke", ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 37.0, GemiddeldeKM_Rit = 70, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 106, Voornaam = "Thomas" },
                        new { Id = new Guid("59e7b3ca-0413-4835-a234-27ea29ee21b3"), AantalRecords = 0, Achternaam = "Garnaal", ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 38.0, GemiddeldeKM_Rit = 80, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 107, Voornaam = "Sofie" },
                        new { Id = new Guid("c6fe5ea4-b8e9-4650-af5d-8c35e8740411"), AantalRecords = 0, Achternaam = "Brokkenpap", ClubId = new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 39.0, GemiddeldeKM_Rit = 90, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 108, Voornaam = "Berend" },
                        new { Id = new Guid("e656a795-03c4-4f79-a286-11d2678b1de9"), AantalRecords = 0, Achternaam = "Mega", ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 40.0, GemiddeldeKM_Rit = 5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 109, Voornaam = "Mindy" },
                        new { Id = new Guid("82c212ac-c413-4b46-9d3a-3c21e4a8cb07"), AantalRecords = 0, Achternaam = "Scarlet", ClubId = new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 41.0, GemiddeldeKM_Rit = 6, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 110, Voornaam = "Johanson" },
                        new { Id = new Guid("407d720c-b512-482b-81eb-35992d3fcf40"), AantalRecords = 0, Achternaam = "Beukelaer", ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 42.0, GemiddeldeKM_Rit = 7, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Koekjes" },
                        new { Id = new Guid("c7d84dc8-7408-4053-9ac0-0cb443fbf4dd"), AantalRecords = 0, Achternaam = "Mertens", ClubId = new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 43.0, GemiddeldeKM_Rit = 8, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 112, Voornaam = "Evelyne" },
                        new { Id = new Guid("d105ddfa-2a0f-4f97-9f3c-eec2d5545c0e"), AantalRecords = 0, Achternaam = "VanHoof", ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 44.0, GemiddeldeKM_Rit = 9, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 113, Voornaam = "Emily" },
                        new { Id = new Guid("857ed997-8294-4039-b519-e5415c7a6b97"), AantalRecords = 0, Achternaam = "Vanderplas", ClubId = new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 45.0, GemiddeldeKM_Rit = 10, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 114, Voornaam = "Sonja" },
                        new { Id = new Guid("9030c945-de3c-45b4-be30-4ff75c38fc55"), AantalRecords = 0, Achternaam = "Bambino", ClubId = new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 46.0, GemiddeldeKM_Rit = 11, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 115, Voornaam = "Salvatore" },
                        new { Id = new Guid("0e36be6a-256d-4b0e-af31-a93b7b7af2a6"), AantalRecords = 0, Achternaam = "Zalinski", ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 47.0, GemiddeldeKM_Rit = 12, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 116, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("76717832-d230-4c9b-b970-09c1438781fe"), AantalRecords = 0, Achternaam = "Debruyne", ClubId = new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 48.0, GemiddeldeKM_Rit = 13, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 117, Voornaam = "Kevin" },
                        new { Id = new Guid("f216631a-bb64-45f8-9484-4c4716bfbb97"), AantalRecords = 0, Achternaam = "Hazard", ClubId = new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 49.0, GemiddeldeKM_Rit = 14, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 118, Voornaam = "Eden" },
                        new { Id = new Guid("b17d9345-8fe6-4c2a-b706-aa7e3ea54f83"), AantalRecords = 0, Achternaam = "Evenepoel", ClubId = new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 50.0, GemiddeldeKM_Rit = 15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 119, Voornaam = "Remco" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Web.RecordZoeker.RecordHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("RecordHistories");
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
                    b.HasOne("SuperCyclingWorld.Web.RecordZoeker.RecordHistory")
                        .WithMany("RecordHistories")
                        .HasForeignKey("RecordHistoryId");

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
#pragma warning restore 612, 618
        }
    }
}
