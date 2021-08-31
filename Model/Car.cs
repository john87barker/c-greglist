namespace c_greglist.Model
{
    public class Car
    {
      [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    [Range(1950, 2021)]
    public int Year { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Price { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(80)]
    public string Description { get; set; }
  
    public string ImgUrl { get; set; }
    public string Pictures { get; set; }


    public Car(string make, string model, int year, int price, string description, string imgUrl, string pictures)
    {
      Make = make;
      Model = Model;
      Year = year;
      Price = price;
      Description = description;
      ImgUrl = imgUrl;
      Pictures = pictures;
    }
  }
}