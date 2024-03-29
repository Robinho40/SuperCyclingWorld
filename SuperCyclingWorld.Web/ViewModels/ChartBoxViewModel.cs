﻿using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class ChartBoxViewModel
    {
        public string ChartName { get; set; }
        public string ChartPicture { get; set; }
        public string ChartContentText { get; set; }
        public string MeerWetenText { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }

        public ChartBoxViewModel(ChartBox chartBox, string action, string controller)
        {
            ChartName = chartBox.Name;
            ChartPicture = chartBox.Picture;
            ChartContentText = chartBox.ContentText;
            MeerWetenText = chartBox.MeerWetenText;
            Action = action;
            Controller = controller;
        }
    }
}
