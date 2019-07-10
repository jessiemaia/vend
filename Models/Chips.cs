namespace vend.Models
{
  class Chips : Food
  {
    public bool Spicy { get; set; }
    public Chips(double price, string name, int quantity, bool sf, bool spicy) : base(price, name, quantity, sf)
    {
      Spicy = spicy;
    }
  }
}