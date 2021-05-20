using System;
using RestSharp;

namespace BettingProject
{
    public class OddsCalculator
    {
        public OddsCalculator()
        {
        }

        public string NFLOdds()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=americanfootball_nfl&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public string NBAOdds()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=basketball_nba&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }


        public string NHLOdds()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=icehockey_nhl&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public string MMAOdds()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=mma_mixed_martial_arts&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        public string MLBOdds()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/odds?sport=baseball_mlb&region=us&mkt=h2h&dateFormat=iso&oddsFormat=decimal");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
