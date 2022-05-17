using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OS.Models;

public class Country
{
    private static int idst = 0;
    public Country(string name, string square)
    {
        Id = ++idst;
        Name = name;
        Square = square;
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Square { get; set; }
}