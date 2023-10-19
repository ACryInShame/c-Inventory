using System;

class main
{
    static void Main(String[] args)
    {
        Inventory TestInventory = new Inventory();
        bool run = true;

        do
        {
            string inventory = TestInventory.ToString();

            Console.WriteLine(inventory);
            Console.WriteLine("Enter Command: 1) add item 2) remove item 3) switch items 4) exit");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar == '1' )
            {
                Console.WriteLine("what item do you want to add?");
                string input = "";
                input += Console.ReadLine();
                if (input == "")
                    input = "Open";

                TestInventory.AddItem(new Item(input) );
            }
            if (key.KeyChar == '2')
            {
                Console.WriteLine("Which item to remove?");
                key = Console.ReadKey();
                int index = key.KeyChar - '0';

                TestInventory.RemoveItem(index);
            }
            if (key.KeyChar == '3')
            {

            }
            if (key.KeyChar == '4')
            {
                run = false;
            }



        } while (run);
    }

}