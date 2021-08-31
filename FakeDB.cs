using System.Collections.Generic;
using c_greglist.Model;

namespace c_greglist
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Toyota", "Rav4", 2008, 2000, "Nice Car to live in!", "NA", "NA") };
  }
}