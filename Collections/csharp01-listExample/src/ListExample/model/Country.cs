namespace ListExample.model
{
    public class Country
    {
    
    public string Name { get; set; }
    public string Code { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }

    public Country(string name, string code, string continent, int population)
    {
        this.Name = name;
        this.Code = code;
        this.Continent = continent;
        this.Population = population;

    }

}
}