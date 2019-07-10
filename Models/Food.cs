using vend.Interfaces;

namespace vend.Models
{
  abstract class Food : IPurchasable
  {
    public double Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public bool SugarFree { get; set; }
    public Food(double price, string name, int quantity, bool sf)
    {
      Price = price;
      Name = name;
      Quantity = quantity;
      SugarFree = sf;
    }
  }
}