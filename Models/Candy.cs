namespace vend.Models
{
  class Candy : Food
  {
    public bool Chocolate { get; set; }
    public Candy(double price, string name, int quantity, bool sf, bool chocolate) : base(price, name, quantity, sf)
    {
      Chocolate = chocolate;
    }
  }
}
