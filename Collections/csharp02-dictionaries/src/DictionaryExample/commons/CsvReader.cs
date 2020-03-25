using System.Collections.Generic;
using System.IO;
using DictionaryExample.model;
using DictionaryExample.commons;

namespace DictionaryExample.commons
{
    public class CsvReader
    {
        public CsvReader(string path)
        {
            this.Path = path;

        }
        public string Path { get; set; }
        public Dictionary<string,Country> Countries { get; set; }

        public Dictionary<string,Country> readAllCountries()
        {
            using(var reader=new StreamReader(Path))
            {
                Countries= new Dictionary<string,Country>();
                reader.ReadLine(); // we read the header of the file contries_stats
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var country=readCountryLine(line);

                    Countries.Add(country.Code,country);
                }
                
                return Countries;
            }
        }

        private Country readCountryLine(string  line)
        {
            string name="";;
            string code="";;
            string continent="";
            int population=0;
            var countryParts = line.Split(","); // , is our delimiter

            switch(countryParts.Length)
            {
                case 4:
                {
                  name = countryParts[0];
                  code = countryParts[1];
                  continent = countryParts[2];
                  population = int.Parse(countryParts[3]);
                 break;
                }
                case 5:
                {
                    name= countryParts[0] + ", "+ countryParts[1];
                    name=name.Replace("\"",null).Trim();
                    code = countryParts[2];
                    continent = countryParts[3];
                    population = int.Parse(countryParts[4]);

                    break;
                }

            }
           

            Country country = new Country(name, code, continent, population);
        
            return country;
        }
    }
}