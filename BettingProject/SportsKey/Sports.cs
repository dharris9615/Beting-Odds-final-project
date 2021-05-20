using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BettingProject.SportsKey
{
    public class Sports
    {
        public Sports()
        {
        }
        public class Datum
        {
            public string Key { get; set; }
            public bool Active { get; set; }
            public string Group { get; set; }
            public string Details { get; set; }
            public string Title { get; set; }
            public bool HasOutrights { get; set; }
        }

        public class Root
        {
            public bool Success { get; set; }
            public List<Datum> Data { get; set; }
        }


    }
}
