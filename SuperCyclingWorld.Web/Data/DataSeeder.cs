﻿using Microsoft.EntityFrameworkCore;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Data
{
    public class DataSeeder
    {
        private static Random _random = new Random();

        public static void Seed(ModelBuilder modelBuilder)
        {
            

            var clubs = new[]
{
                new {Id = Guid.NewGuid(), Clubnaam = "WTC", Oprichtingsjaar = DateTime.Now.Year - 20, AantalRecords = 0},
                new {Id = Guid.NewGuid(), Clubnaam = "DCTV", Oprichtingsjaar = DateTime.Now.Year - 5, AantalRecords = 0},
                new {Id = Guid.NewGuid(), Clubnaam = "De lustige rijders", Oprichtingsjaar = DateTime.Now.Year - 30, AantalRecords = 0},
                new {Id = Guid.NewGuid(), Clubnaam = "WTC Melsele", Oprichtingsjaar = DateTime.Now.Year - 55, AantalRecords = 0},
                new {Id = Guid.NewGuid(), Clubnaam = "The master cyclists", Oprichtingsjaar = DateTime.Now.Year - 10, AantalRecords = 0}
            };

            var wielrenners = new[]
            {
                new  {Id = Guid.NewGuid(), Achternaam = "Franckaert", Voornaam = "Robin", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Franckaert@live.be", TotaalAantalGeredenKilometers = 100, AantalRecords = 0, GemiddeldKm_h = 31.0, GemiddeldeKM_Rit = 10, WattageRecord = 55},
                new  {Id = Guid.NewGuid(), Achternaam = "Jansma", Voornaam = "Johanna", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Jansma@live.be", TotaalAantalGeredenKilometers = 101, AantalRecords = 0, GemiddeldKm_h = 32.0, GemiddeldeKM_Rit = 20, WattageRecord = 66 },
                new  {Id = Guid.NewGuid(), Achternaam = "Vissers", Voornaam = "Bert", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Vissers@live.be", TotaalAantalGeredenKilometers = 102, AantalRecords = 0, GemiddeldKm_h = 33.0, GemiddeldeKM_Rit = 30, WattageRecord = 77 },
                new  {Id = Guid.NewGuid(), Achternaam = "Depardieu", Voornaam = "Gerard", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Depardieu@live.be", TotaalAantalGeredenKilometers = 103, AantalRecords = 0, GemiddeldKm_h = 34.0, GemiddeldeKM_Rit = 40, WattageRecord = 88 },
                new  {Id = Guid.NewGuid(), Achternaam = "Van Overmeire", Voornaam = "Marc", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "VanOvermeire@live.be", TotaalAantalGeredenKilometers = 104, AantalRecords = 0, GemiddeldKm_h = 35.0, GemiddeldeKM_Rit = 50, WattageRecord = 99 },
                new  {Id = Guid.NewGuid(), Achternaam = "Camara", Voornaam = "Herdy", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Camara@live.be", TotaalAantalGeredenKilometers = 105, AantalRecords = 0, GemiddeldKm_h = 36.0, GemiddeldeKM_Rit = 60, WattageRecord = 41},
                new  {Id = Guid.NewGuid(), Achternaam = "Donckerwolcke", Voornaam = "Thomas", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Donckerwolcke@live.be", TotaalAantalGeredenKilometers = 106, AantalRecords = 0, GemiddeldKm_h = 37.0, GemiddeldeKM_Rit = 70, WattageRecord = 105 },
                new  {Id = Guid.NewGuid(), Achternaam = "Garnaal", Voornaam = "Sofie", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Garnaal@live.be", TotaalAantalGeredenKilometers = 107, AantalRecords = 0, GemiddeldKm_h = 38.0, GemiddeldeKM_Rit = 80, WattageRecord = 50 },
                new  {Id = Guid.NewGuid(), Achternaam = "Brokkenpap", Voornaam = "Berend", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Brokkenpap@live.be", TotaalAantalGeredenKilometers = 108, AantalRecords = 0, GemiddeldKm_h = 39.0, GemiddeldeKM_Rit = 90, WattageRecord = 30 },
                new  {Id = Guid.NewGuid(), Achternaam = "Mega", Voornaam = "Mindy", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "Mega@live.be", TotaalAantalGeredenKilometers = 109, AantalRecords = 0, GemiddeldKm_h = 40.0, GemiddeldeKM_Rit = 5, WattageRecord = 31 },
                new  {Id = Guid.NewGuid(), Achternaam = "Scarlet", Voornaam = "Johanson", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Scarlet@live.be", TotaalAantalGeredenKilometers = 110, AantalRecords = 0, GemiddeldKm_h = 41.0, GemiddeldeKM_Rit = 6, WattageRecord = 32 },
                new  {Id = Guid.NewGuid(), Achternaam = "Beukelaer", Voornaam = "Koekjes", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Beukelaer@live.be", TotaalAantalGeredenKilometers = 111, AantalRecords = 0, GemiddeldKm_h = 42.0, GemiddeldeKM_Rit = 7, WattageRecord = 33 },
                new  {Id = Guid.NewGuid(), Achternaam = "Mertens", Voornaam = "Evelyne", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Mertens@live.be", TotaalAantalGeredenKilometers = 112, AantalRecords = 0, GemiddeldKm_h = 43.0, GemiddeldeKM_Rit = 8, WattageRecord = 34 },
                new  {Id = Guid.NewGuid(), Achternaam = "VanHoof", Voornaam = "Emily", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Vanhoof@live.be", TotaalAantalGeredenKilometers = 113, AantalRecords = 0, GemiddeldKm_h = 44.0, GemiddeldeKM_Rit = 9, WattageRecord = 35},
                new  {Id = Guid.NewGuid(), Achternaam = "Vanderplas", Voornaam = "Sonja", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "Vanderplas@live.be", TotaalAantalGeredenKilometers = 114, AantalRecords = 0, GemiddeldKm_h = 45.0, GemiddeldeKM_Rit = 10, WattageRecord = 36 },
                new  {Id = Guid.NewGuid(), Achternaam = "Bambino", Voornaam = "Salvatore", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Bambino@live.be", TotaalAantalGeredenKilometers = 115, AantalRecords = 0, GemiddeldKm_h = 46.0, GemiddeldeKM_Rit = 11, WattageRecord = 37},
                new  {Id = Guid.NewGuid(), Achternaam = "Zalinski", Voornaam = "Wosznjeck", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Zalinski@live.be", TotaalAantalGeredenKilometers = 116, AantalRecords = 0, GemiddeldKm_h = 47.0, GemiddeldeKM_Rit = 12, WattageRecord = 38 },
                new  {Id = Guid.NewGuid(), Achternaam = "Debruyne", Voornaam = "Kevin", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Debruyne@live.be", TotaalAantalGeredenKilometers = 117, AantalRecords = 0, GemiddeldKm_h = 48.0, GemiddeldeKM_Rit = 13, WattageRecord = 39 },
                new  {Id = Guid.NewGuid(), Achternaam = "Hazard", Voornaam = "Eden", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Hazard@live.be", TotaalAantalGeredenKilometers = 118, AantalRecords = 0, GemiddeldKm_h = 49.0, GemiddeldeKM_Rit = 14, WattageRecord = 21 },
                new  {Id = Guid.NewGuid(), Achternaam = "Evenepoel", Voornaam = "Remco", ClubId = clubs[_random.Next(0,clubs.Length)].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "Evenepoel@live.be", TotaalAantalGeredenKilometers = 119, AantalRecords = 0, GemiddeldKm_h = 50.0, GemiddeldeKM_Rit = 15, WattageRecord = 12 }
            };

            var supporters = new[]
            {
                new {Id = Guid.NewGuid(), Achternaam = "The Pooh", Voornaam = "Winnie", GeboorteDatum = DateTime.Parse("Jan 1, 2009"), Paswoord = MD5.CreateMD5("123"), Email = "ThePooh@live.be" },
                new {Id = Guid.NewGuid(), Achternaam = "Van Achtmaal", Voornaam = "Thomas", GeboorteDatum = DateTime.Parse("Jan 1, 2000"), Paswoord = MD5.CreateMD5("123"), Email = "VanAchtmaal@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "VanKerkhove", Voornaam = "Nico", GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "VanKerkhove@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Kronenburg", Voornaam = "Koen", GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Kronenburg@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Van Kruisem", Voornaam = "Willy", GeboorteDatum = DateTime.Parse("Jan 1, 2009"), Paswoord = MD5.CreateMD5("123"), Email = "VanKruisem@live.be" },
                new {Id = Guid.NewGuid(), Achternaam = "Wezemaal", Voornaam = "Bert", GeboorteDatum = DateTime.Parse("Jan 1, 2000"), Paswoord = MD5.CreateMD5("123"), Email = "Wezemaal@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Opdorp", Voornaam = "Alfons", GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Opdorp@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "AppelGate", Voornaam = "Christina", GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Appelgate@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Monroe", Voornaam = "Marlyn", GeboorteDatum = DateTime.Parse("Jan 1, 2009"), Paswoord = MD5.CreateMD5("123"), Email = "Monroe@live.be" },
                new {Id = Guid.NewGuid(), Achternaam = "Clooney", Voornaam = "George", GeboorteDatum = DateTime.Parse("Jan 1, 2000"), Paswoord = MD5.CreateMD5("123"), Email = "Clooney@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Peeters", Voornaam = "Jan", GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Peeters@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Reyns", Voornaam = "Rita", GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Reyns@live.be"},
            };

            var fietsen = new[]
            {
                new { Id = Guid.NewGuid(), Merk = "B-Twin", Zadel = "Zwart zadel", WielrennerId = wielrenners[1].Id},
                new { Id = Guid.NewGuid(), Merk = "Moldava", Zadel = "Geel zadel", WielrennerId = wielrenners[2].Id},
                new { Id = Guid.NewGuid(), Merk = "Merckx", Zadel = "Oranje zadel", WielrennerId = wielrenners[0].Id}
            };


            var ClubSupporters = new[]
            {
                new { ClubId = clubs[2].Id, SupporterId = supporters[1].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[1].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[2].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[3].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[4].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[1].Id, SupporterId = supporters[2].Id},
                new { ClubId = clubs[2].Id, SupporterId = supporters[3].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[1].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[2].Id},
                


            };

            var FanRegistraties = new[]
            {
                new { WielrennerId = wielrenners[1].Id, SupporterId = supporters[0].Id},
                new { WielrennerId = wielrenners[3].Id, SupporterId = supporters[3].Id},
                new { WielrennerId = wielrenners[2].Id, SupporterId = supporters[0].Id},
                new { WielrennerId = wielrenners[1].Id, SupporterId = supporters[1].Id},
                new { WielrennerId = wielrenners[0].Id, SupporterId = supporters[3].Id},
                new { WielrennerId = wielrenners[3].Id, SupporterId = supporters[2].Id}

            };


            modelBuilder.Entity<Fiets>()
                .HasData(fietsen);

            modelBuilder.Entity<Wielrenner>()
                .HasData(wielrenners);

            modelBuilder.Entity<Supporter>()
                .HasData(supporters);

            modelBuilder.Entity<Club>()
                .HasData(clubs);

            modelBuilder.Entity<ClubSupporter>()
                .HasData(ClubSupporters);

            modelBuilder.Entity<FanRegistratie>()
                .HasData(FanRegistraties);

        }

        


    }
}
