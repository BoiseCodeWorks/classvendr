using System;
using System.Collections.Generic;

namespace classvendr.Models
{
    class VendingMachine
    {
        decimal TotalCash { get; set; }
        public decimal CurrentTransaction { get; private set; }
        //no access modifier means private by default       
        Dictionary<String, Snack> Snacks { get; set; }
        List<Electronic> Electronics { get; set; }
        #region AddItem
        public void AddItem(Snack snack)
        {
            //add is the new push
            Snacks.Add(snack.Name, snack);
        }

        // public void AddItem(Snack snack, int index)
        // {
        //     Snacks.Insert(index, snack);
        // }

        // public void AddItem(Electronic electronic)
        // {
        //     //add is the new push
        //     Electronics.Add(electronic);
        // }

        // public void AddItem(Electronic electronic, int index)
        // {
        //     Electronics.Insert(index, electronic);
        // }
        #endregion

        public string AddQuarter()
        {
            CurrentTransaction += .25m;
            return CurrentTransaction.ToString();
        }


        //vending for lists
        // public Snack ListVend(int snackIndex)
        // {
        //     if (snackIndex < 0 || snackIndex > Snacks.Count - 1)
        //     {
        //         Console.WriteLine("Invalid Selection");
        //         return null;
        //     }
        //     Snack selection = Snacks[snackIndex];
        //     if (CurrentTransaction >= selection.Price)
        //     {
        //         CurrentTransaction -= selection.Price;
        //         return selection;
        //     }
        //     Console.WriteLine("NOT ENOUGH DOUGH");
        //     return null;
        // }



        public Snack Vend(string snackName)
        {
            //check dictionary for property
            if (!Snacks.ContainsKey(snackName))
            {
                Console.WriteLine("Invalid Selection");
                return null;
            }
            Snack selection = Snacks[snackName];
            if (CurrentTransaction >= selection.Price)
            {
                CurrentTransaction -= selection.Price;
                return selection;
            }
            Console.WriteLine("NOT ENOUGH DOUGH");
            return null;
        }

        public bool RemoveSnack(string snackName)
        {
            if (!Snacks.ContainsKey(snackName))
            {
                Console.WriteLine("Invalid Selection");
                return false;
            }
            Snacks.Remove(snackName);
            return true;
        }


        public VendingMachine()
        {
            Snacks = new Dictionary<String, Snack>();
            Electronics = new List<Electronic>(){
            new Electronic("Fritos", 1.25m),
            new Electronic("Tab", 1.00m),
            new Electronic("Mt. Dew", 1.00m)
            };
        }
    }
}