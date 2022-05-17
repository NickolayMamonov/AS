using OS.Models;

namespace OS.Data;

public interface ICountryStorage
{
    public IEnumerable<Country> GetAllCountries();
    public Country? GetCountryById(int id);
    public Country? GetCountryByName(string name);
    public Country? RemoveCountryById(int id);
    public Country AddCountry(Country country);
}