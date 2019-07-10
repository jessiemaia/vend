namespace vend.Interfaces
{
  interface IPurchasable
  {
    double Price { get; set; }
    string Name { get; set; }
    int Quantity { get; set; }
  }
}