using System;
using System.Collections.Generic;

namespace RestaurantManager
{
	class Program
	{

		static void Main(string[] args)
		{
			Table table1 = new Table(4);
            Table table2 = new Table(2);
            Table table3 = new Table(2);
            Table table4 = new Table(1);
            List<Table> listofTables = new List<Table>();
            listofTables.Add(table1);
            listofTables.Add(table2);
            listofTables.Add(table3);
            listofTables.Add(table4);

            while (true)
			{
				Console.WriteLine("Please give me how many seats are needed");

				
				string input = Console.ReadLine();
				int seatsNeeded;
				bool isInt = int.TryParse(input, out seatsNeeded);
				if (input.Length >= 0 && !isInt)
				{
					Console.WriteLine("You gave invalid input");
				}
				else
				{
                    for (int i =0; i < listofTables.Count; i++)
                    {
                        if (seatsNeeded > 0)
                        {

                            if (listofTables[i].CanSeat(seatsNeeded))
                            {
                                Console.WriteLine("We have " + seatsNeeded + " spots open for you.");
                                i++;
                         
                            }
                            else
                            {

                                Console.WriteLine("We do not have " + seatsNeeded + " spots open for you at this time.");
                                i++;
                            }

                        }
                        else
                        {

                            Console.WriteLine("You gave an invalid number of seats to check for. Please try again.");
                        }
                    }

				}


			}

		}

	}
}
