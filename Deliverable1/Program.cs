using System;

class Program
{
    static void Main()
    {
        //Stock values
        int sodaStock = 100;
        int chipsStock = 40;
        int candyStock = 60;

        //Restock values
        int sodaRestock = 40;
        int chipsRestock = 20;
        int candyRestock = 40;

        //Title to user
        Console.WriteLine("Welcome to the restocking tool!");

        //Question to user for number of of soda purchased
        Console.WriteLine("How many sodas have been sold today? " +  sodaStock + " are in stock.");
        int sodaSold = int.Parse(Console.ReadLine());
        

        //if user enters number over stock available
        while (sodaSold > sodaStock)
        {
            Console.WriteLine("You have entered an invalid number, please enter a number less than or equal to " + sodaStock + ".");
            sodaSold = int.Parse(Console.ReadLine());
        }

        //Question to user for number of chips sold
        Console.WriteLine("How many chips have been sold today? " + chipsStock + " are in stock.");
        int chipsSold = int.Parse(Console.ReadLine());
        

        // if user enters number over stock available
        while (chipsSold > chipsStock)
        {
            Console.WriteLine("You have entered an invalid number, please enter a number less than or equal to " + chipsStock + ".");
            chipsSold = int.Parse(Console.ReadLine());
        }

        //Question to user for number of candy sold
        Console.WriteLine("How many candies have been sold today? " + candyStock + " are in stock.");
        int candySold = int.Parse(Console.ReadLine());

        // if user enters number of stock available
        while (candySold > candyStock)
        {
            Console.WriteLine("You have entered an invalid number, please enter a number less than or equal to " + candyStock + ".");
            candySold = int.Parse(Console.ReadLine());
        }

        // Remaining stock calculation
        int sodaRemaining = sodaStock - sodaSold;
        int chipsRemaining = chipsStock - chipsSold;
        int candyRemaining = candyStock - candySold;

        //Restock needed status print to user
        if (sodaRemaining <= sodaRestock) {
            Console.WriteLine("There are " + sodaRemaining + " sodas remaining, please restock.");
        }
        else
        {
            Console.WriteLine(" There are " + sodaRemaining + " sodas remaining, no restock needed.");
        }
        if (chipsRemaining <= chipsRestock)
        {
            Console.WriteLine("There are " + chipsRemaining + " chips remaining, please restock.");
        }
        else
        {
            Console.WriteLine(" There are " + chipsRemaining + " chips remaining, no restock needed.");
        }
        if (candyRemaining <= candyRestock)
        {
            Console.WriteLine("There are " + candyRemaining + " candies remaining, please restock.");
        }
        else
        {
            Console.WriteLine(" There are " + candyRemaining + " candies remaining, no restock needed.");
        }
    }
}