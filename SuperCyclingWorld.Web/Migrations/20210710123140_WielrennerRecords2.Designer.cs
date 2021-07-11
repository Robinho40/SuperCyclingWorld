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
    [Migration("20210710123140_WielrennerRecords2")]
    partial class WielrennerRecords2
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

                    b.Property<Guid?>("Clubleider");

                    b.Property<string>("Clubnaam");

                    b.Property<int>("Oprichtingsjaar");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), SupporterId = new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                        new { ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), SupporterId = new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                        new { ClubId = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), SupporterId = new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") },
                        new { ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), SupporterId = new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") },
                        new { ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), SupporterId = new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                        new { ClubId = new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), SupporterId = new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") },
                        new { ClubId = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), SupporterId = new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                        new { ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), SupporterId = new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") }
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
                        new { SupporterId = new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), WielrennerId = new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                        new { SupporterId = new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), WielrennerId = new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") },
                        new { SupporterId = new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), WielrennerId = new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951") },
                        new { SupporterId = new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), WielrennerId = new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                        new { SupporterId = new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), WielrennerId = new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9") },
                        new { SupporterId = new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), WielrennerId = new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") }
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
                        new { Id = new Guid("9c23eec8-80ec-4ec8-a12a-5b459e8c7ce3"), Merk = "B-Twin", WielrennerId = new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("d2a1e7b5-f11f-4bfe-9158-9a4ef54581b8"), Merk = "Moldava", WielrennerId = new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), Zadel = "Geel zadel" },
                        new { Id = new Guid("0d954ef3-8e8c-4c13-8ace-bd9d0744898d"), Merk = "Merckx", WielrennerId = new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

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
                        new { Id = new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("a0edf372-2381-466e-bc06-ff41640b4627"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("62d0725e-9a69-409b-8c50-eae1631af0dd"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("a966c410-01de-473e-89f8-1940dfa29a78"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("d24364df-ad04-4e8e-aec8-5c67554a4bb2"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("fe200d2e-e039-4b99-80ae-0df22e33602a"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("3df57f63-fb85-4311-9938-017afa6604b9"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("a2fdf7ed-f4d8-470a-b32c-9d8d2aa32a6d"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("d44a7aab-23ff-4db7-b1e7-5b6a3ffb823b"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<Guid?>("ClubId")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<string>("Paswoord");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), Achternaam = "Franckaert", ClubId = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Robin" },
                        new { Id = new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), Achternaam = "Jansma", ClubId = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Johanna" },
                        new { Id = new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), Achternaam = "Vissers", ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145"), Achternaam = "Depardieu", ClubId = new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Gerard" },
                        new { Id = new Guid("2d863a91-c79a-42e6-b602-0e126b77670a"), Achternaam = "Van Overmeire", ClubId = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marc" },
                        new { Id = new Guid("be75615a-2a6e-4e53-a405-f6028f072713"), Achternaam = "Camara", ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Herdy" },
                        new { Id = new Guid("c0d47a62-8883-4fa1-968b-0e0d55959915"), Achternaam = "Donckerwolcke", ClubId = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("37db1132-88d6-4209-9833-2fa52f28028b"), Achternaam = "Garnaal", ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Sofie" },
                        new { Id = new Guid("f9025da7-1cd1-4381-a2c7-d3b2a486a2c7"), Achternaam = "Brokkenpap", ClubId = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Berend" },
                        new { Id = new Guid("06b84abc-6885-4d75-b5fc-a9749a583530"), Achternaam = "Mega", ClubId = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Mindy" },
                        new { Id = new Guid("01190cdb-8a84-4909-9b0f-0e8dc26ba267"), Achternaam = "Scarlet", ClubId = new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Johanson" },
                        new { Id = new Guid("d011c3c6-bdc4-42fa-97a1-58170066c8ea"), Achternaam = "Beukelaer", ClubId = new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koekjes" },
                        new { Id = new Guid("7bae6c19-27c7-4149-8f18-36f7febd4e4c"), Achternaam = "Mertens", ClubId = new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Evelyne" },
                        new { Id = new Guid("ddcc2560-cd0d-4fec-bf8d-15de297bc939"), Achternaam = "VanHoof", ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Emily" },
                        new { Id = new Guid("2027e6ab-8786-4766-8d11-3e69b98ba33e"), Achternaam = "Vanderplas", ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Sonja" },
                        new { Id = new Guid("b37db182-678a-434a-9c9c-e73d7bb87b7b"), Achternaam = "Bambino", ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Salvatore" },
                        new { Id = new Guid("d28ee37e-bb2e-41d2-b64e-7445a754ca0b"), Achternaam = "Zalinski", ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Wosznjeck" },
                        new { Id = new Guid("79d93d2a-3c5c-449e-9102-56357ec9d2dd"), Achternaam = "Debruyne", ClubId = new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Kevin" },
                        new { Id = new Guid("201f464e-54e8-4fd1-ba1c-e0c686f4ff98"), Achternaam = "Hazard", ClubId = new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Eden" },
                        new { Id = new Guid("19099198-5b87-448b-8d5c-f1b8ba606184"), Achternaam = "Evenepoel", ClubId = new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Remco" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.WielrennerRecords", b =>
                {
                    b.Property<Guid>("RecordId");

                    b.Property<Guid>("WielrennersId");

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("RecordId", "WielrennersId");

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
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany("Records")
                        .HasForeignKey("WielrennerId");
                });
#pragma warning restore 612, 618
        }
    }
}
