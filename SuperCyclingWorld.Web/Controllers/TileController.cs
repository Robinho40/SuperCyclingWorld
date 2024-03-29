﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
using SuperCyclingWorld.Core.Repositories;
using SuperCyclingWorld.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class TileController : Controller
    {
        private readonly SCWDbContext _dbContext;
        private readonly AccountTileRepository _accountTileService;

        public TileController(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
            _accountTileService = new AccountTileRepository();
        }

        [Route("/Tile/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            string personId = "";

            if (HttpContext.Session.Keys.Contains("LoggedInId"))
            {
                personId = HttpContext.Session.GetString("LoggedInId");
            }
            else
            {
                return NotFound();
            }


            List<Club> clubs = new List<Club>();
            List<Wielrenner> wielrenners = new List<Wielrenner>();

            Persoon account1 = await _dbContext.Wielrenners.Where(w => w.Id == Guid.Parse(personId)).Include(w => w.Club).Include(w => w.Wielrenners).Include(f => f.Fietsen).SingleOrDefaultAsync();
            if (account1 == null)
            {

                account1 = await _dbContext.Supporters.Where(w => w.Id == Guid.Parse(personId)).Include(w => w.Wielrenners).Include(w => w.Clubs).SingleOrDefaultAsync();
                Supporter ingelogdeSupporter = (Supporter)account1;
                foreach(var clubsup in ingelogdeSupporter.Clubs)
                {
                    clubs.Add(_dbContext.Clubs.Where(c => c.Id == clubsup.ClubId).SingleOrDefault());
                    wielrenners = _dbContext.Wielrenners.Where(w => w.ClubId == clubsup.ClubId).ToList();
                }

            }
            AccountViewModel accountVm = new AccountViewModel(account1, _accountTileService.AccountTiles, clubs, wielrenners);

            accountVm.SelectedAccountTile = id;

            return View(accountVm);
        }
    }
}
