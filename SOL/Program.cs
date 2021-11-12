using System;
using System.Collections.Generic;
using System.Text;

namespace OOPclasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class estateConstruction
    {

        public List<Buildings> allStandardBuildings { get; set; }
        double GetTotalMonthly(List<IMonthlyRate> monthlies)
        {
            var totalMonthlyRate = 0d;
            foreach (var Buildings in monthlies)
            {
                totalMonthlyRate += Buildings.GetMonthly();
            }
            return totalMonthlyRate;
        }

        double GetTotalyearly(List<IYearlyRate> yearlies)
        {
            var totalYearlyRate = 0d;
            foreach (var Buildings in yearlies)
            {
                totalYearlyRate += Buildings.GetYearly();
            }
            return totalYearlyRate;

        }

    }


    public class Buildings
    {
        public int BuildingNumber { get; set; }
        public string BuildingStreet { get; set; }
        public string Storey { get; set; }

    }

    public class ElectricityRate
    {

    }
    public class WaterRate
    {

    }
    public class SecurityRate
    {

    }
    public interface IMonthlyRate
    {
        public double GetMonthly();
    }
    public interface IYearlyRate
    {
        public double GetYearly();
    }
}
