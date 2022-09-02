using System;

namespace VendingMachines
{
    class Program
    {

        static void initialise(VendingMachines[] vms)
        {
            Random r = new Random();
            vms[0].addCans(r.Next(1, 11));
            vms[0].setName("Machine 1");
            vms[0].setLocation("Hallway");

            vms[1].addCans(r.Next(1, 11));
            vms[1].setName("Machine 2");
            vms[1].setLocation("First Floor");

            vms[2].addCans(r.Next(1, 11));
            vms[2].setName("Machine 3");
            vms[2].setLocation("Lower Ground Floor");

            vms[3].setName("Machine 4");
            vms[3].setLocation("Lower Ground Floor");

            vms[4].setName("Machine 5");
            vms[4].setLocation("Lower Ground Floor");
        }
        static void print(VendingMachines[] vms)
        {
            foreach (VendingMachines vm in vms)
            {
                Console.WriteLine(vm.ToString());
            }
        }
        static void buyCans(VendingMachines[] vms)
        {
            Random r = new Random();
            foreach (VendingMachines vm in vms)
            {
                int cansToBuy = r.Next(1, 11);
                if (vm.insertToken(cansToBuy))
                {
                    Console.WriteLine("Successfully bought " + cansToBuy + " cans");
                }
            }
        }
        static void Main(string[] args)
        {
            VendingMachines[] vendingMachines =
            {
                new VendingMachines(),
                new VendingMachines(),
                new VendingMachines(),
                new VendingMachines(10),
                new VendingMachines(10)
            };

            initialise(vendingMachines);
            print(vendingMachines);
            buyCans(vendingMachines);

           
        }
    }
}

