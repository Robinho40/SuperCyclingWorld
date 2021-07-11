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
    [Migration("20210710161109_AddLittletestSeeding")]
    partial class AddLittletestSeeding
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

                    b.Property<int?>("AantalRecords");

                    b.Property<Guid?>("Clubleider");

                    b.Property<string>("Clubnaam");

                    b.Property<int>("Oprichtingsjaar");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), SupporterId = new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") },
                        new { ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), SupporterId = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") },
                        new { ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), SupporterId = new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") },
                        new { ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), SupporterId = new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") },
                        new { ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), SupporterId = new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") },
                        new { ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), SupporterId = new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") },
                        new { ClubId = new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), SupporterId = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") },
                        new { ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), SupporterId = new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") },
                        new { ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), SupporterId = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") }
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
                        new { SupporterId = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), WielrennerId = new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") },
                        new { SupporterId = new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), WielrennerId = new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") },
                        new { SupporterId = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), WielrennerId = new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7") },
                        new { SupporterId = new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"), WielrennerId = new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") },
                        new { SupporterId = new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), WielrennerId = new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324") },
                        new { SupporterId = new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"), WielrennerId = new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") }
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
                        new { Id = new Guid("521495c3-204b-4aa0-bbac-8c1ba7ee3dc2"), Merk = "B-Twin", WielrennerId = new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("df4bafa4-de7d-4059-bce1-d531a3200610"), Merk = "Moldava", WielrennerId = new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7"), Zadel = "Geel zadel" },
                        new { Id = new Guid("4c124ace-f7d0-4abe-9f03-5b9497648150"), Merk = "Merckx", WielrennerId = new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324"), Zadel = "Oranje zadel" }
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

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Records");
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
                        new { Id = new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("4aec9698-5ebb-46da-8390-90809fe559ad"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("c7746fd1-0799-4db0-a13b-59e36238281e"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("d58d34ac-b86b-48d2-8148-42e4383e145e"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("05d5ea01-b939-4411-bfb9-3cb9b4c46a97"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("deea0c39-af39-488a-b144-c26f5ed11fd6"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("65422f61-b22c-4a3f-98bb-b671e021a395"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("7edba17c-47c7-4620-b809-422769a49a1c"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("522e6750-b633-49c2-91dd-94d482c71859"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
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

                    b.Property<int>("TotaalAantalGeredenKilometers");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324"), Achternaam = "Franckaert", ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Robin" },
                        new { Id = new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9"), Achternaam = "Jansma", ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 260, Voornaam = "Johanna" },
                        new { Id = new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7"), Achternaam = "Vissers", ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 301, Voornaam = "Bert" },
                        new { Id = new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702"), Achternaam = "Depardieu", ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 85, Voornaam = "Gerard" },
                        new { Id = new Guid("86bab186-f158-4342-9b21-e1d1305dce13"), Achternaam = "Van Overmeire", ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 256, Voornaam = "Marc" },
                        new { Id = new Guid("f2e8d257-7b1a-440d-98dd-9199bd0d9d29"), Achternaam = "Camara", ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 504, Voornaam = "Herdy" },
                        new { Id = new Guid("ba889c8c-c077-4fe7-8ba3-13e5125bca1e"), Achternaam = "Donckerwolcke", ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1100, Voornaam = "Thomas" },
                        new { Id = new Guid("aa512496-b3c9-4bd5-90ae-aeb12dcd057c"), Achternaam = "Garnaal", ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 250, Voornaam = "Sofie" },
                        new { Id = new Guid("a49f80d8-5c41-41d4-aafe-4454378f807f"), Achternaam = "Brokkenpap", ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 125, Voornaam = "Berend" },
                        new { Id = new Guid("9fc5d982-8b33-4fd0-8491-49c625c614b8"), Achternaam = "Mega", ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 568, Voornaam = "Mindy" },
                        new { Id = new Guid("59cffb08-b174-4c6c-a2db-cf56ea69fb2d"), Achternaam = "Scarlet", ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 308, Voornaam = "Johanson" },
                        new { Id = new Guid("9b92f185-02da-4038-827b-a187b3b07ddb"), Achternaam = "Beukelaer", ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Koekjes" },
                        new { Id = new Guid("3f5422a5-5292-4f9d-a3a8-345cd5bfdeec"), Achternaam = "Mertens", ClubId = new Guid("0378a453-4956-411c-aea7-54191c451f92"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 110, Voornaam = "Evelyne" },
                        new { Id = new Guid("cd3532c0-807a-448e-bb70-22c664947f98"), Achternaam = "VanHoof", ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 306, Voornaam = "Emily" },
                        new { Id = new Guid("438d4900-e5f2-4f56-8bba-04b7dd607a0a"), Achternaam = "Vanderplas", ClubId = new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 59, Voornaam = "Sonja" },
                        new { Id = new Guid("407d181a-d15f-4bc7-b35f-ed6b75da5fd8"), Achternaam = "Bambino", ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 257, Voornaam = "Salvatore" },
                        new { Id = new Guid("c7e28bb1-8de0-46e7-88ae-7e9ff86a77a4"), Achternaam = "Zalinski", ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 233, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("2e690940-487f-43a3-b63e-ad189d08c076"), Achternaam = "Debruyne", ClubId = new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 450, Voornaam = "Kevin" },
                        new { Id = new Guid("767da5e0-0365-43f2-ad4f-dd285c88390d"), Achternaam = "Hazard", ClubId = new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 23, Voornaam = "Eden" },
                        new { Id = new Guid("f07f2aa0-ac20-4116-8273-4e8f30ba9c52"), Achternaam = "Evenepoel", ClubId = new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Remco" }
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