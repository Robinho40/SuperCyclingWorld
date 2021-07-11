﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialCyclingWorld.Web.Data;

namespace SuperCyclingWorld.Web.Migrations
{
    [DbContext(typeof(SCWDbContext))]
    partial class SCWDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        new { Id = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), AantalRecords = 0, Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), AantalRecords = 0, Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), AantalRecords = 0, Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), AantalRecords = 0, Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), AantalRecords = 0, Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), SupporterId = new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                        new { ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                        new { ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                        new { ClubId = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                        new { ClubId = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                        new { ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                        new { ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), SupporterId = new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") },
                        new { ClubId = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), SupporterId = new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380") },
                        new { ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), SupporterId = new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                        new { ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), SupporterId = new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") }
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
                        new { SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), WielrennerId = new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                        new { SupporterId = new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), WielrennerId = new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") },
                        new { SupporterId = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), WielrennerId = new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8") },
                        new { SupporterId = new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), WielrennerId = new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                        new { SupporterId = new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), WielrennerId = new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1") },
                        new { SupporterId = new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), WielrennerId = new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") }
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
                        new { Id = new Guid("5c1a981a-fbd1-4eb3-8fa1-c14886872b5c"), Merk = "B-Twin", WielrennerId = new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("00cb1983-e5cd-452a-b4aa-bd4b722fd7d1"), Merk = "Moldava", WielrennerId = new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), Zadel = "Geel zadel" },
                        new { Id = new Guid("50bee6d5-22f8-4d2d-9800-6085916851d1"), Merk = "Merckx", WielrennerId = new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), Zadel = "Oranje zadel" }
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
                        new { Id = new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("471668ed-d025-498c-933d-2f08f1b413cb"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("4b147d17-7aa0-4a0f-980b-85b2e484ea35"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("71c72ed5-ab63-4941-a503-3b1c8531e147"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("526bb932-7077-485c-bef5-b36856c9fece"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("e58ae1a5-b332-4ce2-b09f-4daeb2d96efc"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("de658c6d-7026-4c0f-80bd-7f5ee9311d10"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("bd022d32-be48-43fa-8eaa-97a370ef1e1e"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("c6d37d37-eca8-4cbc-b0d8-04f33c8394d9"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
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

                    b.Property<string>("Paswoord");

                    b.Property<int>("TotaalAantalGeredenKilometers");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), AantalRecords = 0, Achternaam = "Franckaert", ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 15.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Robin" },
                        new { Id = new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), AantalRecords = 0, Achternaam = "Jansma", ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 33.8, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 260, Voornaam = "Johanna" },
                        new { Id = new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), AantalRecords = 0, Achternaam = "Vissers", ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.6, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 301, Voornaam = "Bert" },
                        new { Id = new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c"), AantalRecords = 0, Achternaam = "Depardieu", ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 85, Voornaam = "Gerard" },
                        new { Id = new Guid("f110f1e9-25ff-43ac-800f-ea121047a7a3"), AantalRecords = 0, Achternaam = "Van Overmeire", ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 41.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 256, Voornaam = "Marc" },
                        new { Id = new Guid("2f679ada-b355-4586-b53e-0f5984c4eb73"), AantalRecords = 0, Achternaam = "Camara", ClubId = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.51, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 504, Voornaam = "Herdy" },
                        new { Id = new Guid("8c3d56c3-4213-4c06-8abf-a5803c9fd0ec"), AantalRecords = 0, Achternaam = "Donckerwolcke", ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1100, Voornaam = "Thomas" },
                        new { Id = new Guid("df166eaa-3051-48aa-a6f1-f9fdd3686a5e"), AantalRecords = 0, Achternaam = "Garnaal", ClubId = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 42.1, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 250, Voornaam = "Sofie" },
                        new { Id = new Guid("e0a4680b-a765-4aae-840c-25f36af842ab"), AantalRecords = 0, Achternaam = "Brokkenpap", ClubId = new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 20.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 125, Voornaam = "Berend" },
                        new { Id = new Guid("7de1146f-23ef-4c36-9a39-e28153b07b17"), AantalRecords = 0, Achternaam = "Mega", ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 42.15, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 568, Voornaam = "Mindy" },
                        new { Id = new Guid("aeabe12a-f63b-4e05-a0c2-6c19963478c6"), AantalRecords = 0, Achternaam = "Scarlet", ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.5, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 308, Voornaam = "Johanson" },
                        new { Id = new Guid("3a29e165-fa1e-464d-96bf-927be1b5e86e"), AantalRecords = 0, Achternaam = "Beukelaer", ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 23.6, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Koekjes" },
                        new { Id = new Guid("ead0ad24-f8fc-41b9-8c7d-b89a50d8682a"), AantalRecords = 0, Achternaam = "Mertens", ClubId = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 22.65, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 110, Voornaam = "Evelyne" },
                        new { Id = new Guid("44a872bd-70e7-4f3b-a4d0-babc07cdfbfd"), AantalRecords = 0, Achternaam = "VanHoof", ClubId = new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 29.55, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 306, Voornaam = "Emily" },
                        new { Id = new Guid("a037319a-af21-4726-9484-d4e09c25c9f7"), AantalRecords = 0, Achternaam = "Vanderplas", ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 33.6, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 59, Voornaam = "Sonja" },
                        new { Id = new Guid("ec863ace-dd46-4ca9-bf70-7d3e0b65c847"), AantalRecords = 0, Achternaam = "Bambino", ClubId = new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 44.2, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 257, Voornaam = "Salvatore" },
                        new { Id = new Guid("1270dd91-0279-4527-92fa-86f1e7b09778"), AantalRecords = 0, Achternaam = "Zalinski", ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 31.6, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 233, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("9a1a5bc0-aafa-43c1-860e-795164abacab"), AantalRecords = 0, Achternaam = "Debruyne", ClubId = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 15.9, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 450, Voornaam = "Kevin" },
                        new { Id = new Guid("134d4a68-aec8-4ee7-9a14-7b51b3fb44d1"), AantalRecords = 0, Achternaam = "Hazard", ClubId = new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 44.2, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 23, Voornaam = "Eden" },
                        new { Id = new Guid("c79cac4d-0c96-432e-abac-54f8ca625053"), AantalRecords = 0, Achternaam = "Evenepoel", ClubId = new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GemiddeldKm_h = 12.53, Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Remco" }
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
