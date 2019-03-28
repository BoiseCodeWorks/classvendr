using System;
using classvendr.Models;

namespace classvendr
{
    class Program
    {
        static void Main(string[] args)
        {
            Snack doritos = new Snack("Doritos", 1.25m);
            Snack chipsAhoy = new Snack("Chips Ahoy", 1.50m);
            Snack cheetos = new Snack("Cheetos", 1.25m);
            // System.Console.WriteLine($"{doritos.Name}: {doritos.Price}");
            // System.Console.WriteLine("New Price: " + doritos.UpdatePrice(1.50m));
            // System.Console.WriteLine($"{doritos.Name}: {doritos.Price}");
            // System.Console.WriteLine("New Price: " + doritos.UpdatePrice(1.20m));
            // System.Console.WriteLine($"{doritos.Name}: {doritos.Price}");
            VendingMachine vm = new VendingMachine();
            vm.AddItem(doritos);
            vm.AddItem(chipsAhoy);
            vm.AddItem(cheetos);
        }
    }
}
