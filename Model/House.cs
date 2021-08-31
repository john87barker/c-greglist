using System;
using System.ComponentModel.DataAnnotations;

namespace c_greglist.Model
{
    public class House
    {
    public string Id { get; set; }
    [Required]
    public int Year { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }


    public House(int year, int bedrooms, int bathrooms)
    {
      Year = year;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Id = Guid.NewGuid().ToString();
    }
  }
}