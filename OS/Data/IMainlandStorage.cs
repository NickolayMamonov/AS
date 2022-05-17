using OS.Models;

namespace OS.Data;

public interface IMainlandStorage
{
    public IEnumerable<Mainland> GetAllMainlands();
    public Mainland? GetMainlandById(int id);
    public Mainland? GetMainlandByName(string name);
    public Mainland? RemoveMainlandById(int id);
    public Mainland AddMainland(Mainland mainland);
}