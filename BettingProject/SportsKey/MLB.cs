using System;
using System.Collections.Generic;

namespace BettingProject.SportsKey
{
    public class MLB
    {
        public MLB()
        {
           
        }
        public string id { get; set; }
        public string sport_key { get; set; }
        public string sport_nice { get; set; }
        public List<string> teams { get; set; }
        public string home_team { get; set; }
        public DateTime commence_time { get; set; }
        public List<Site> sites { get; set; }
        public int sites_count { get; set; }
    }

        public class Odds
        {
            public List<double> H2h { get; set; }
            public List<double> H2hLay { get; set; }
        }

        public class Site
        {
            public string SiteKey { get; set; }
            public string SiteNice { get; set; }
            public DateTime LastUpdate { get; set; }
            public Odds Odds { get; set; }
        }

        public class Datum
        {
            public string Id { get; set; }
            public string SportKey { get; set; }
            public string SportNice { get; set; }
            public List<string> Teams { get; set; }
            public string HomeTeam { get; set; }
            public DateTime CommenceTime { get; set; }
            public List<Site> Sites { get; set; }
            public int SitesCount { get; set; }
        }

        public class Root
        {
            public bool Success { get; set; }
            public List<Datum> Data { get; set; }
        }

    

}
    

