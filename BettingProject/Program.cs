using System;
using BettingProject.OddsGenerator;

namespace BettingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sport = new SportsSelector();
            //Console.WriteLine($"{sport.apisport()}");

            //var NFL = new OddsCalculator();
            //Console.WriteLine($"{NFL.NFLOdds()}");

            //var NBA = new OddsCalculator();
            //Console.WriteLine($"{NBA.NBAOdds()}");

            //var MLB = new OddsCalculator();
            //Console.WriteLine($"{MLB.MLBOdds()}");

            //var MMA = new OddsCalculator();
            //Console.WriteLine($"{MMA.MMAOdds()}");

            //var NHL = new OddsCalculator();
            //Console.WriteLine($"{NHL.NHLOdds()}");

            var response = MLBOdds.MLBBets();

             MLBOdds.OddsParse(response);

            
        }


    }
}
