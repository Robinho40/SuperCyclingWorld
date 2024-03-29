﻿using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
using SuperCyclingWorld.Core.Enums;
using SuperCyclingWorld.Web.RecordZoeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class AccountViewModel
    {
        public Guid Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get;  set; }
        public Club Club { get; private set; } = null;
        public ICollection<Club> Clubs { get; private set; }
        public ICollection<Wielrenner> Wielrenners { get;  set; }
        public string AccountType { get; private set; }
        public int Leeftijd { get; private set; }
        public ICollection<Fiets> Fietsen { get; private set; } = new List<Fiets>();
        public List<AccountTile> AccountTiles { get; set; } = new List<AccountTile>();
        public int SelectedAccountTile { get; set; } = 0;
        public int AantalRecordsThisAccount { get; set; }
        public ICollection<Record> RecordsOfThisPerson { get; set; }
        public AccountViewModel(Persoon account, ICollection<AccountTile>accountTiles, ICollection<Club> clubs, ICollection<Wielrenner> wielrenners)
        {
            
            Id = account.Id;
            Voornaam = account.Voornaam;
            Achternaam = account.Achternaam;
            Wielrenners = wielrenners;
            Clubs = clubs;
            Leeftijd = DateTime.Now.Year - account.GeboorteDatum.Year;
            SetAccount(account);
            GetAccountTiles(accountTiles);
            UpdateClubs();

        }



        private void UpdateClubs()
        {
            foreach(Club club in Clubs)
            {
                    club.AantalRecords = RecordList.Records.Where(r => r.Wielrenner.Club.Id == club.Id && r.RecordType == Recordtype.Site).Count();
            }       
        }

        private void UpdateAantalRecords()
        {
            AantalRecordsThisAccount = RecordList.Records.Where(r => r.Wielrenner.Id == Id).Count();
            RecordsOfThisPerson = RecordList.Records.Where(r => r.Wielrenner.Id == Id).ToList();
        }

        private void SetAccount(Persoon account)
        {

            if (account is Wielrenner)
            { 
                AccountType = "Wielrenner";
                Wielrenner convertedPersoon = (Wielrenner)account;
                Club = convertedPersoon.Club;
                Fietsen = convertedPersoon.Fietsen;
                UpdateClubs();
                UpdateAantalRecords();
            }

            else
            {
                AccountType = "Supporter";
                Supporter convertedPersoon = (Supporter)account;

            }
        }

        private void GetAccountTiles(ICollection<AccountTile> accountTiles)
        {
            if(AccountType == "Wielrenner")
            {
                foreach(AccountTile accountTile in accountTiles)
                {
                    if(accountTile.TyleType == TileType.Wielrenner || accountTile.TyleType == TileType.Persoon)
                    {
                        AccountTiles.Add(accountTile);
                    }
                }
            }
            else
            {
                foreach (AccountTile accountTile in accountTiles)
                {
                    if (accountTile.TyleType == TileType.Supporter || accountTile.TyleType == TileType.Persoon)
                    {
                        AccountTiles.Add(accountTile);
                    }
                }
            }
           
        }



    }
}
