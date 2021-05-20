using System;
using System.Net.Http;
using RestSharp;

namespace BettingProject
{
    public class SportsSelector
    {
        public SportsSelector()
        {

        }

        public string apisport()
        {
            var client = new RestClient("https://odds.p.rapidapi.com/v1/sports");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "5bbef5d0femsh3d3b711ff119776p1d4d12jsn5834953357d3");
            request.AddHeader("x-rapidapi-host", "odds.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
