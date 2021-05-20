using System;
using System.Collections.Generic;
using BettingProject.SportsKey;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BettingProject.OddsGenerator
{
    public class MLBOdds
    {
        public MLBOdds()
        {
        }

        public static IRestResponse MLBBets()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=baseball_mlb&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response;
        }

        public static void OddsParse(IRestResponse response)
        {
            var MLBobj = JObject.Parse(response.Content).SelectToken("Data[0]").ToString();
            

            var data = JsonConvert.DeserializeObject<MLBData>(response.Content);

            // var MLBH2h = MLBobj["H2h"];

            //foreach(var mlb in data.Data)
            //{
            //    var odds = JObject.Parse(mlb.Odds).GetValue("h2h[0]");
            //    Console.WriteLine($"{odds}");
            //}

            //var mlb = new MLB()
            //{
            //    H2h = new List<double> {MLBH2h}
            //};

            //return mlb;

            Console.WriteLine(MLBobj);
            

        }
    }
}
