using System;

namespace LoopsandConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            ///** selection statements  
            // if else statements 

            //Console.WriteLine("How old is your dog? Enter a whole number: ");

            //string userage = Console.ReadLine();

            //int ageofDog = int.Parse(userage);

            //if (ageofDog <= 1)
            //{
            //    Console.WriteLine("You have a puppy");
            //}

            //else if(ageofDog <= 3 && ageofDog > 1)
            //{
            //    Console.WriteLine("you have a young dog."); 
            //}

            //else if (ageofDog <= 7 )
            //{
            //    Console.WriteLine("You have a middle age dog. "); 
            //}

            //else
            //{
            //    Console.WriteLine("You have an old dog "); 
            //}




            //Switch Statements 

            // if else statements 

            //Console.WriteLine("How old is your dog? Enter a whole number: ");

            //string userage = Console.ReadLine();

            //int ageofDog = int.Parse(userage);

            //switch (ageofDog)
            //{
            //    case 0:
            //        Console.WriteLine("Your dogg is zero years old ");
            //        break;
            //    case 1:
            //        Console.WriteLine("Your dogg is one years old ");
            //        break;
            //    default:
            //        break; // do nothing if dog is not 0 or 1 
            // }



            // ternary statement 
            //Console.WriteLine("Do you live in Michigan? y/n");
            //string input = Console.ReadLine();
            //string message = input == "Y" ? "Go Blue" : "Go Green";
            //Console.WriteLine(message);
            //

            //**Loops**
            //int mpg = 26;
            //int gallonsInTank = 16;
            //int distanceTraveled = 0;
            //Console.WriteLine("Ther are " + gallonsInTank + "gallons in the tank");
            //Console.WriteLine("you traveled" + distanceTraveled + " miles");
            //while (gallonsInTank > 0)
            //{
            //    gallonsInTank--; //gallonsInTank = gallonsInTank - 1
            //    distanceTraveled += mpg; //distanceTraveled = distanceTraveled
            //}
            //Console.WriteLine("Ther are " + gallonsInTank + "gallons in the tank");
            //Console.WriteLine("you traveled" + distanceTraveled + " miles");

            // do while loops 

            int channelsWatched = 0;
            int boredomLevel = 5; 

            do
            {
                channelsWatched++;
                Console.WriteLine(channelsWatched);
                boredomLevel--;
            }
            while (boredomLevel > 0); 


        }
    }
    }

