namespace vend.Models
{
  class Canned : Drink
  {
    public double Deposit { get; set; }
    public Canned(double price, string name, int quant, double flOz, double deposit) : base(price, name, quant, flOz)
    {
      Deposit = deposit;
    }
  }
}