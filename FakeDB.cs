using System.Collections.Generic;
using c_greglist.Model;

namespace c_greglist
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Toyota", "Rav4", 2008, 2000) };
    static public List<House> Houses { get; set; } = new List<House>() { new House(2000, 3, 2) };
    static public List<Job> Jobs { get; set; } = new List<Job>() { new Job("Burger Man", 20) };
  }
}