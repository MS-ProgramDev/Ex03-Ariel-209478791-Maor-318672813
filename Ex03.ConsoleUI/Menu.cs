using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
	internal static class Menu
	{




	public void ShowMainMenu()
		{
			Console.Clear();
			Console.WriteLine("Welcome to the main menu!");
			Console.WriteLine("Please press the number of the option you want to choose");
			Console.WriteLine("1. Loading Vehicle from Vehicles.db file");
			Console.WriteLine("2. Insert new car to the Garage");
			Console.WriteLine("3. List of Number License of the vehicles in the garage(with filter by status)");
			Console.WriteLine("4. Change status of car in the Garage");
			Console.WriteLine("5. Inflate tires to maximum");
			Console.WriteLine("6. Refuel vehicle");
			Console.WriteLine("7. Charge vehicle");
			Console.WriteLine("8. Show full vehicle details");
			Console.WriteLine("9. Exit");
		}
		public static void Show()
		{
			ShowMainMenu();
			string userInput = Console.ReadLine();
			switch (userInput)
			{
				case "1":
					Console.WriteLine("You selected Option 1.");
					break;
				case "2":
					Console.WriteLine("You selected Option 2.");
					break;
				case "3":
					Console.WriteLine("Exiting...");
					break;
				default:
					Console.WriteLine("Invalid selection. Please try again.");
					Show();
					break;
			}
		}



	}
}
