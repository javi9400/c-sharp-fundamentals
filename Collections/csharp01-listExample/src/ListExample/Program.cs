using System;
using ListExample.commons;
using ListExample.model;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH=@"FILE PATH"; // copy path of file countries_stats.csv located in the source folder and paste it here

            CsvReader reader= new CsvReader(PATH);
            
            var countriesResult=reader.readAllCountries();
           
            /*
               Adding a new country to our list
            */
            Country fictionalCountry= new Country("Mustafar","MT","A",1);

            int fictionalCountryIndex=countriesResult.FindIndex(x=>x.Population<2000000);

            /*
              Inserts the new country
            */
            countriesResult.Insert(fictionalCountryIndex,fictionalCountry);

           /* 
             Removing by index
           */
            countriesResult.RemoveAt(fictionalCountryIndex);


            foreach (var country in countriesResult)
            {
                Console.WriteLine($"Population:  {country.Population}, Name: {country.Name}");
            }


        }
    }
}
