using OS.Models;

namespace OS.Data;

public class MainlandStorage : IMainlandStorage
{
    private List<Mainland> _mainlands;

    public MainlandStorage()
    {
        _mainlands = new List<Mainland>()
        {
            new Mainland("Евразия", new List<int>(){1, 2, 3}),
            new Mainland("Северная Америка", new List<int>(){4})
        };
    }

    public IEnumerable<Mainland> GetAllMainlands()
    {
        return _mainlands.Select(e => e).ToList();
    }

    public Mainland? GetMainlandById(int id)
    {
        return _mainlands.FirstOrDefault(e => e.Id == id);
    }

    public Mainland? GetMainlandByName(string name)
    {
        return _mainlands.FirstOrDefault(e => e.Name.Equals(name));
    }

    public Mainland? RemoveMainlandById(int id)
    {
        var mainland = _mainlands.FirstOrDefault(e => e.Id == id);
        if (mainland != default)
        {
            _mainlands.Remove(mainland);
        }

        return mainland;
    }

    public Mainland AddMainland(Mainland mainland)
    {
        throw new NotImplementedException();
    }
}