namespace vend.Models
{
  class Bottled : Drink
  {
    public bool Glass { get; set; }
    public Bottled(double price, string name, int quant, double flOz, bool glass) : base(price, name, quant, flOz)
    {
      Glass = glass;
    }
  }
}