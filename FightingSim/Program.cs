using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingSim
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Fighter g1 = new Fighter();
            Fighter g2 = new Fighter();

            

            Console.WriteLine("Welcome to a Fighting sim");
            Console.WriteLine("Write player A`s name below");

            string player1Name = Name();

            Console.WriteLine("Write player B`s name below");

            string player2Name = Name2();

            Console.WriteLine("Let`s go");

            while (g1.isAlive() == true && g2.isAlive() == true)
            {
                
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine(player1Name + " attacks");
                    int randomAttack = g1.Attack();
                    g2.Hurt(randomAttack);
                    Console.WriteLine(player2Name + " health is " + g2.GetHp());

                if (g1.isAlive() == true && g2.isAlive() == true)
                {

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(player2Name + " attacks");
                    randomAttack = g2.Attack();
                    g1.Hurt(randomAttack);
                    Console.WriteLine(player1Name + " health is " + g1.GetHp());


                }



            }


            if (!g1.isAlive() || !g2.isAlive())
            {
                if (!g1.isAlive() && g2.isAlive() == true)
                {
                    Console.WriteLine(player2Name + " wins");
                    Console.WriteLine("That was all my friends see you next time, in the fighting sim");

                }
                else if (g1.isAlive() == true && !g2.isAlive())
                {


                    Console.WriteLine(player1Name + " wins");
                    Console.WriteLine("That was all my friends see you next time, in the fighting sim");

                }
                else
                {
                    Console.WriteLine(" No one wins");
                    Console.WriteLine("That was all my friends see you next time, in the fighting sim");

                }
            }
           
            


           Console.ReadLine();
        }
        static string Name()
        {

            string input = Console.ReadLine(); /**Här skapar jag en variabel vid namn input. I den sparas det som användaren skriver in. Denna är till 
            för att spelare 1 ska skriva in vad de vill att deras karaktär ska heta**/

            int result; //Här skapar jag int result. Just nu har inten result ett innehåll som inte är bestämt än 

            bool success = int.TryParse(input, out result); /** Här så skapar jag en bool som kallas success och i den sparas det om det gick att göra om stringen input till inten result eller inte. 
            Här gör vi alltså om en string till en in **/

            while (success == true || input.Length > 32 || input.Length < 3) /** Denna while körs ifall man har skrivit in ett nummer eller om längden på det man skrivit i input överstiger 32 eller 
                om det man skrivit understiger 3. Den är till för spelare 1 **/
            {

                if (success == false && input.Length > 32) //Denna if körs om man skrivit in bokstäver vars längd överskrider 32 karaktärer
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your name needs to be less than 32 characters");

                }

                if (success == false && input.Length < 3) //Denna if skrivs ifall man skrivit in bokstäver vars längd underskrider 3 karakärer
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your username needs to be over 3 characters");

                }
                else if (success == true)//Denna if körs ifall man skrivit in något som bara är siffror
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your username is not valid, try again");

                }

                Console.ForegroundColor = ConsoleColor.White;// Detta kommando ändrar färg på texten som kommer precis efter den 

                input = Console.ReadLine(); /**Sedan gör man så att datorn läser in ett nytt värde från användaren som sparas i stringen input. Sedan prövar datorn igen med en try parse och koden körs om tills man skriver in något som gör att 
                man kommer ur whilen, alltså att man skriva in något som funkar enligt instruktionerna **/

                success = int.TryParse(input, out result);

            }


            if (success == false || input.Length < 32 || input.Length > 3)   /**Denna if körs ifall man skrev in bokstäver (Att tryparse inte funkade) eller om längden är
            under 32 eller om längden på texten är över 3 tecken**/
            {

                Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                Console.WriteLine("Welcome " + input);

                return input;
            }

            return input;

        }
        static string Name2()
        {

            string input2 = Console.ReadLine(); /**Här skapar jag en variabel vid namn input. I den sparas det som användaren skriver in. Denna är till 
            för att spelare 1 ska skriva in vad de vill att deras karaktär ska heta**/

            int result2; //Här skapar jag int result. Just nu har inten result ett innehåll som inte är bestämt än 

            bool sucess2 = int.TryParse(input2, out result2); /** Här så skapar jag en bool som kallas success och i den sparas det om det gick att göra om stringen input till inten result eller inte. 
            Här gör vi alltså om en string till en in **/

            while (sucess2 == true || input2.Length > 32 || input2.Length < 3) /** Denna while körs ifall man har skrivit in ett nummer eller om längden på det man skrivit i input överstiger 32 eller 
                om det man skrivit understiger 3. Den är till för spelare 1 **/
            {

                if (sucess2 == false && input2.Length > 32) //Denna if körs om man skrivit in bokstäver vars längd överskrider 32 karaktärer
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your name needs to be less than 32 characters");

                }

                if (sucess2 == false && input2.Length < 3) //Denna if skrivs ifall man skrivit in bokstäver vars längd underskrider 3 karakärer
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your username needs to be over 3 characters");

                }
                else if (sucess2 == true)//Denna if körs ifall man skrivit in något som bara är siffror
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                    Console.WriteLine("Your username is not valid, try again");

                }

                Console.ForegroundColor = ConsoleColor.White;// Detta kommando ändrar färg på texten som kommer precis efter den 

                input2 = Console.ReadLine(); /**Sedan gör man så att datorn läser in ett nytt värde från användaren som sparas i stringen input. Sedan prövar datorn igen med en try parse och koden körs om tills man skriver in något som gör att 
                man kommer ur whilen, alltså att man skriva in något som funkar enligt instruktionerna **/

                sucess2 = int.TryParse(input2, out result2);

            }


            if (sucess2 == false || input2.Length < 32 || input2.Length > 3)   /**Denna if körs ifall man skrev in bokstäver (Att tryparse inte funkade) eller om längden är
            under 32 eller om längden på texten är över 3 tecken**/
            {

                Console.ForegroundColor = ConsoleColor.Yellow;// Detta kommando ändrar färg på texten som kommer precis efter den 

                Console.WriteLine("Welcome " + input2);

                return input2;
            }

            return input2;
        }
    }
}
