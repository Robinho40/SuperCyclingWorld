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
                        new { Id = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), AantalRecords = 0, Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), AantalRecords = 0, Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), AantalRecords = 0, Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), AantalRecords = 0, Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), AantalRecords = 0, Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), SupporterId = new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                        new { ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                        new { ClubId = new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                        new { ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                        new { ClubId = new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                        new { ClubId = new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                        new { ClubId = new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), SupporterId = new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") },
                        new { ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), SupporterId = new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558") },
                        new { ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), SupporterId = new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                        new { ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), SupporterId = new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") }
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
                        new { SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025"), WielrennerId = new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                        new { SupporterId = new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), WielrennerId = new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") },
                        new { SupporterId = new Guid("68694416-8004-4879-88f8-95f25bbdc025"), WielrennerId = new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc") },
                        new { SupporterId = new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), WielrennerId = new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                        new { SupporterId = new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), WielrennerId = new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219") },
                        new { SupporterId = new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), WielrennerId = new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") }
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
                        new { Id = new Guid("1e9c518a-3587-4f0d-a455-7eec7dd553c3"), Merk = "B-Twin", WielrennerId = new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("e48cecb7-0381-462d-b311-70c31585b088"), Merk = "Moldava", WielrennerId = new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), Zadel = "Geel zadel" },
                        new { Id = new Guid("3bd9e414-f548-4b6f-b3ab-06a163b3425d"), Merk = "Merckx", WielrennerId = new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), Zadel = "Oranje zadel" }
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
                        new { Id = new Guid("68694416-8004-4879-88f8-95f25bbdc025"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("25ae9c9d-ef8e-4128-b4da-2d60d39c9d20"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("1a8dc8db-dd3f-4c62-b99d-53bcdaeb818e"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("acee2067-e053-4e0c-8011-948c6416ca6a"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("a988280a-8c13-4d59-9253-264046ed9a60"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("9ae17db2-861e-4c0d-8e18-12c57571ab57"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("1676ba06-42a3-4400-9c8f-806449308a17"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("bad97b6c-a0d5-4835-bce2-32ee66ecb7f2"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("b20212a3-b556-4a4f-bb70-dfb8872ad84e"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
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
                        new { Id = new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), Achternaam = "Franckaert", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Robin" },
                        new { Id = new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), Achternaam = "Jansma", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 260, Voornaam = "Johanna" },
                        new { Id = new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), Achternaam = "Vissers", ClubId = new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 301, Voornaam = "Bert" },
                        new { Id = new Guid("1c9d63a4-57de-4871-816b-194d32806ccf"), Achternaam = "Depardieu", ClubId = new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 85, Voornaam = "Gerard" },
                        new { Id = new Guid("346a7c39-79be-4a02-814e-fce9f8a78bd7"), Achternaam = "Van Overmeire", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 256, Voornaam = "Marc" },
                        new { Id = new Guid("04a1b5ff-2ac8-4ea8-846d-0aee440091f6"), Achternaam = "Camara", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 504, Voornaam = "Herdy" },
                        new { Id = new Guid("ec5193a6-5975-4909-92f7-76dd0524a10a"), Achternaam = "Donckerwolcke", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1100, Voornaam = "Thomas" },
                        new { Id = new Guid("603ab875-5194-4110-b55e-2ab0d6333771"), Achternaam = "Garnaal", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 250, Voornaam = "Sofie" },
                        new { Id = new Guid("07768fe0-aef0-4641-9cfd-adf53ea5eb3b"), Achternaam = "Brokkenpap", ClubId = new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 125, Voornaam = "Berend" },
                        new { Id = new Guid("d48d3567-24c6-4f56-a593-fa197ff73e2c"), Achternaam = "Mega", ClubId = new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 568, Voornaam = "Mindy" },
                        new { Id = new Guid("f0f1650f-0e01-48e3-9e9d-d08943487ea5"), Achternaam = "Scarlet", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 308, Voornaam = "Johanson" },
                        new { Id = new Guid("6b187433-eff0-4e90-b0d7-5c6c36e7d542"), Achternaam = "Beukelaer", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Koekjes" },
                        new { Id = new Guid("ef44c545-2da0-4b20-99ef-3423b5924713"), Achternaam = "Mertens", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 110, Voornaam = "Evelyne" },
                        new { Id = new Guid("874d1982-bf82-4fff-9974-c8517d108ee7"), Achternaam = "VanHoof", ClubId = new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 306, Voornaam = "Emily" },
                        new { Id = new Guid("ca39562d-fb33-4e47-9468-d52b3784391d"), Achternaam = "Vanderplas", ClubId = new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 59, Voornaam = "Sonja" },
                        new { Id = new Guid("72dd0c7c-335c-4f99-8ce0-0f5ea95eb148"), Achternaam = "Bambino", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 257, Voornaam = "Salvatore" },
                        new { Id = new Guid("10104c9b-c5a8-429c-9ab3-614ba900fb9c"), Achternaam = "Zalinski", ClubId = new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 233, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("b406f30e-69fe-45a5-b2a9-5a97f2e3fd6a"), Achternaam = "Debruyne", ClubId = new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 450, Voornaam = "Kevin" },
                        new { Id = new Guid("865a7e8a-ec7f-43d0-8080-843c9d9a926f"), Achternaam = "Hazard", ClubId = new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 23, Voornaam = "Eden" },
                        new { Id = new Guid("a48e6bd3-b87b-4fda-940b-cb4c85464be6"), Achternaam = "Evenepoel", ClubId = new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Remco" }
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
