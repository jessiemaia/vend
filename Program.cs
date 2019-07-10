using System;
using vend.Models;

namespace vendingmachine
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      VendingMachine vm = new VendingMachine(true);
      VendingMachine vm2 = new VendingMachine(false);

      bool inVend = true;
      while (inVend)
      {
        vm.PrintContents();
        System.Console.WriteLine("Press a number to chose an item or 'd' to deposit money");
        string choice = Console.ReadLine().ToLower();
        if (choice == "d")
        {
          System.Console.Write("Enter an amount: ");
          string amount = Console.ReadLine();
          vm.AddMoney(amount);
          continue;
        }
        vm.Vend(choice);
      }


    }
  }
}