using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{ "Иван", 		"Георгиев",		"19" },
				{ "Стилян", 	"Харалампиев",  "23" },
				{ "Кристина",	"Бочева", 		"58" },
				{"Светльо",     "Черничев", 	"43" },
				{"Ани",         "Петрова", 		"11" },
				{"Велислава",  	"Тончева",  	"19" } 
			};
			//Антетка на таблица
			Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight (12) + "Години".PadRight (12));
			Console.WriteLine ("============================================");

		

			//Тяло на таблица
			for (int i = 0; i < _table.Length / 3; i++) 
			{ 
				for (int j = 0; j < 3; j++)
				{
				Console.Write (_table [i, j].PadRight (12));
				}
				Console.WriteLine ();
			}

		}
	}
}
