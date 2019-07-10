using System;
using System.Collections.Generic;
using vend.Interfaces;

namespace vend.Models
{
  class VendingMachine
  {
    public List<IPurchasable> Items { get; set; } = new List<IPurchasable>();

    public double TransactionTotal { get; set; }

    public void FillMachine()
    {
      Items = new List<IPurchasable>(){
                new Bottled(1.99, "Water", 10, 12, false),
                new Bottled(1.00, "Mt. Dew", 15, 12, true),
                new Candy(.75, "Snickers", 12, false, true),
                new Chips(1.00, "Doritos: Spicy Nacho", 5, true, true),
                new Canned(.50, "Grape", 4, 8, .05),
            };
    }

    public void AddMoney(string value)
    {
      if (double.TryParse(value, out double val))
      {
        TransactionTotal += val;
        System.Console.WriteLine($"Depositing {value}, total {TransactionTotal}");
        return;
      }
      System.Console.WriteLine("INVALID MONEY");
    }
    public IPurchasable Vend(string input)
    {
      Console.Clear();
      Console.WriteLine("here1");
      if (int.TryParse(input, out int index))
      {
        index--;
        if (index > -1 && index < Items.Count)
        {
          IPurchasable item = Items[index];
          if (item.Quantity > 0 && item.Price < TransactionTotal)
          {
            System.Console.WriteLine("Vrrrmmm");
            item.Quantity--;
            TransactionTotal -= item.Price;
            System.Console.WriteLine($"Enjoy your {item.Name}");
            return item;
          }
        }
      }
      System.Console.WriteLine("Invalid Selection");
      return null;
    }

    public void PrintContents()
    {
      int counter = 1;
      foreach (var item in Items)
      {
        string status = item.Quantity > 0 ? "" : "sold out";
        System.Console.WriteLine($"{counter}. {item.Name} -- {item.Price} {status}");
        counter++;
      }
    }

    public VendingMachine(bool autofill)
    {
      Items = new List<IPurchasable>();
      if (autofill)
      {
        FillMachine();
      }
    }
  }
}