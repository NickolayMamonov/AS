using OS.Models;

namespace OS.Data;

public class CountryStorage : ICountryStorage
{
    private List<Country> _countries;
    private readonly IMainlandStorage _mainlandStorage;
    public CountryStorage(IMainlandStorage mainlandStorage)
    {
        _mainlandStorage = mainlandStorage;
        _countries = new List<Country>()
        {
            new Country("Австралийский чеглок", "Хищная птица"),
            new Country("Австралийский ложный вампир", "Рукокрылые"),
            new Country("Австралийский бычерыл", "Хрящевая рыба"),
            new Country("Азиатский кеклик", "Птица")
        };
    }

    public IEnumerable<Country> GetAllCountries()
    {
        return _countries.Select(e => e).ToList();
    }

    public Country? GetCountryById(int id)
    {
        return _countries.FirstOrDefault(e => e.Id == id);
    }

    public Country? GetCountryByName(string name)
    {
        return _countries.FirstOrDefault(e => e.Name.Equals(name));
    }

    public Country? RemoveCountryById(int id)
    {
        var country = _countries.FirstOrDefault(e => e.Id == id);
        if (country != default)
        {
            _countries.Remove(country);
        }
        return country;
    }

    public Country AddCountry(Country country)
    {
        throw new NotImplementedException();
    }
}