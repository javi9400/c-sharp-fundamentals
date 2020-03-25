using System;
using DictionaryExample.commons;
using DictionaryExample.model;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH=@"C:\Users\Devjm\Documents\Dev\C#\c-sharp-fundamentals\Collections\csharp02-dictionaries\src\DictionaryExample\source\countries_stats.csv"; // copy path of file countries_stats.csv located in the source folder and paste it here

            CsvReader reader= new CsvReader(PATH);
            
            var countriesResult=reader.readAllCountries();

            Console.WriteLine("Which country would you like to see (Example FRC, CHN, USA) ");
            var res=Console.ReadLine().ToUpper();

            var chosenCountry=countriesResult.TryGetValue(res, out Country country);

            if(chosenCountry)
            {
                Console.WriteLine($"You chose {country.Name}");
            }
            else
            {
                Console.WriteLine($"Lo siento amigo that country does not exists");
            }
            
            
        }
    }
}
