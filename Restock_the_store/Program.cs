
//****************************************************************
//*   Filename: Deliverable1                                     *
//*   Author: Kevin Balias                                       *
//*   Class: C# .Net                                             *
//*   Date:  9/14/2023                                           *
//*   Purpose: Restock_the_store                                 *
//*                                                              *
//*                                                              *
//****************************************************************



using System;
public class Restock
{
    public static void Main(string[] args)
    {

        // Input Starting Stock Variables 
        int soda = 100;
        int chips = 40;
        int candy = 60;

        //Input Restock Variables  
        int restockSoda = 40;
        int restockChips = 20;
        int restockCandy = 40;


        // Variables for remaining Stock 
        int sodaLeft;
        int chipsLeft;
        int candyLeft;



        // Soda
        Console.WriteLine("How many sodas have we sold today?");
        int sodaSold = int.Parse(Console.ReadLine());

        while (sodaSold > soda)
        {
            Console.WriteLine("To High");
            sodaSold = int.Parse(Console.ReadLine());
        }
        sodaLeft = soda - sodaSold;
        Console.WriteLine("number of sodas left: " + sodaLeft);




        // Chips 
        Console.WriteLine("How many chips have we sold today?");
        int chipsSold = int.Parse(Console.ReadLine());

        while (chipsSold > chips)
        {
            Console.WriteLine("To High");
            chipsSold = int.Parse(Console.ReadLine());
        }

        chipsLeft = chips - chipsSold;
        Console.WriteLine("number of chips left: " + chipsLeft);




        // Candy 
        Console.WriteLine("How much candy have we sold today?");
        int candySold = int.Parse(Console.ReadLine());

        while (candySold > candy)
        {
            Console.WriteLine("To High");
            candySold = int.Parse(Console.ReadLine());
        }

        candyLeft = candy - candySold;
        Console.WriteLine("number of candy left: " + candyLeft);
        Console.WriteLine();


        // Output Message 
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked!");
        Console.WriteLine();



        // Restock Orders Output 
        if (sodaLeft <= restockSoda)
            Console.Write("Soda needs to be restocked!");
        Console.WriteLine();

        if (chipsLeft <= restockChips)
            Console.Write("Chips needs to be restocked!");
        Console.WriteLine();

        if (candyLeft <= restockCandy)
            Console.Write("Candy needs to be restocked!");
        Console.WriteLine();
    }
}