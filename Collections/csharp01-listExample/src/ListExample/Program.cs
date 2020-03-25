using System;
using ListExample.commons;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH=@"YOUR PATH"; // copy path of file countries_stats.csv located in the source folder and paste it here

            CsvReader reader= new CsvReader(PATH);
            
            var countriesResult=reader.readAllCountries();

            foreach (var country in countriesResult)
            {
                Console.WriteLine($"Population:  {country.Population}, Name: {country.Name}");
            }


        }
    }
}
