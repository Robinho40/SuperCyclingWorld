﻿using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class ClubListViewModel
    {
        public List<Club> Clubs { get; set; }
        public List<Wielrenner> Recordhouders { get; set; }
        public List<Record> Records { get; set; }
    }
}
