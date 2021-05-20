﻿using System;
using System.Collections.Generic;

namespace BettingProject.SportsKey
{
    public class MMA
    {
        public MMA()
        {
        }

        public List<double> H2h { get; set; }

        public List<double> H2hLay { get; set; }

        //public string SiteKey { get; set; }

        public string SiteNice { get; set; }

        public DateTime LastUpdate { get; set; }

        public MMA Odds { get; set; }

       // public string Id { get; set; }

        //public string SportKey { get; set; }

        public string SportNice { get; set; }

        public List<string> Teams { get; set; }

        public string HomeTeam { get; set; }

        public DateTime CommenceTime { get; set; }

        public List<MMA> Sites { get; set; }

        //public int SitesCount { get; set; }

        public bool Success { get; set; }

        public List<MMA> Data { get; set; }
    }
}

