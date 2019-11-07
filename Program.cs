using System;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bag = new List<string>();
            int x = 0;
            while ( x != 4)
            {
                Console.Clear();
                Console.WriteLine("\n");
                switch(x)
                {
                    case 1:
                        
                        if(bag.Count <= 5){
                            Console.WriteLine("     Lägg in föremål i ryggsäcken");
                            string input = Console.ReadLine();
                            bag.Add(input);
                        }else {
                            Console.WriteLine("     Tyvärr väskan är full");
                            Console.WriteLine("\n     Tryck enter för att gå vidare...");
                            Console.ReadLine();
                        }
                        
                        x = 0;

                    break;

                    case 2:
                    
                        Console.WriteLine("     Saker som ligger i väskan.\n");

                        if(bag.Count <= 0){
                            Console.WriteLine("     Väskan är tom.");
                        }

                        for(int i = 0; i < bag.Count; i++){
                            Console.WriteLine("     " + bag[i]);
                        }
                    
                        Console.WriteLine("\n     Tryck enter för att gå vidare...");
                        string y = Console.ReadLine();
                        x = 0;

                    break;

                    case 3:

                        if(bag.Count <= 0){

                            Console.WriteLine("     Det finns inget i väskan att plocka bort!");
                            Console.WriteLine("\n     Tryck enter för att gå vidare...");
                            Console.ReadLine();
                            
                        }else {
                            bag.RemoveAt(bag.Count - 1);
                        }
                        
                        // detta tar bort hela innehållet i listan bag
                        // bag.Clear();

                        x = 0;
                    break;

                    default:

                        Console.WriteLine("     Välkommen till ryggsäcken!");
                        Console.WriteLine("     ---------------------------");
                        Console.WriteLine("     [1] Lägg i ett föremål");
                        Console.WriteLine("     [2] Titta i väskan");
                        Console.WriteLine("     [3] Ta bort den senaste");
                        Console.WriteLine("     [4] Avsluta");
                        Console.WriteLine("     ---------------------------");
                        Console.WriteLine("     Välj: ");
                        x = int.Parse(Console.ReadLine());
                        
                    break;
                }
            }
        }
    }
}