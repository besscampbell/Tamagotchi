using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public bool IsAlive { get; set; }
    public int Id { get; }

    private static List<Pet> _instances = new List<Pet> {};

    public Pet(string name)
    {
      Name = name;
      Food = 10;
      Attention = 10;
      Rest = 10;
      IsAlive = true;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}