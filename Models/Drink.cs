using vend.Interfaces;

namespace vend.Models
{
  abstract class Drink : IPurchasable
  {
    public double Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double FlOz { get; set; }
    public Drink(double price, string name, int quantity, double floz)
    {
      Price = price;
      Name = name;
      Quantity = quantity;
      FlOz = floz;
    }
  }

}