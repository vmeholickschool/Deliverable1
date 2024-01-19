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

        //Question to user for number of of items purchased
        Console.WriteLine("How many soda's have been sold today? " +  sodaStock + " are in stock.");
        int sodasSold = int.Parse(Console.ReadLine());

        Console.WriteLine("How many chips have been sold today? " + chipsStock + " are in stock.");
        int chipsSold = int.Parse(Console.ReadLine());

        Console.WriteLine("How many candies have been sold today? " + candyStock + " are in stock.");
        int candySold = int.Parse(Console.ReadLine());

        // Remaining stock calculation
        int sodaRemaining = sodaStock - sodasSold;
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
        if (candyRemaining <= candy)
        {
            Console.WriteLine("There are " + candyRemaining + " candies remaining, please restock.");
        }
        else
        {
            Console.WriteLine(" There are " + candyRemaining + " candies remaining, no restock needed.");
        }
    }
}