using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OS.Models;

public class Mainland
{
    private static int idst = 0;
    public Mainland(string name)
    {
        Id = ++idst;
        Name = name;
    }
    public Mainland(string name, List<int> ids)
    {
        Id = ++idst;
        Name = name;
        IdsCountries = new List<int>();
        ids.ForEach(e =>
        {
            IdsCountries.Add(e);
        });
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    [AllowNull]
    public List<int> IdsCountries { get; set; }
}