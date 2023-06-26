using System.ComponentModel.DataAnnotations;

namespace lizardRoundUp.Models;
  public class Lizard

{
  public Lizard(string name, int? age, string color, bool? isCamouflaged, bool? hasCage, int id)
  {
    Name = name;
    Age = age;
    Color = color;
    IsCamouflaged = isCamouflaged;
    HasCage = hasCage;
    Id = id;
  }
  public string Name { get; set; }
  public int? Age { get; set; }
  public string Color { get; set; }
  public bool? IsCamouflaged { get; set; }
  public bool? HasCage { get; set; }
  public int Id { get; set; }
}