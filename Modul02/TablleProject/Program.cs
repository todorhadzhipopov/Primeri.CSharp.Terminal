using System;

namespace TablleProject
{
	class MainClass
	{

		enum ti {ime =0, familia, godini};


		public static void Main (string[] args)
		{
			//Дефиниране таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0,(int) ti.ime] = "Тодор"; table[0,(int) ti.familia] = "Хаджипопов";table[0,(int)ti.godini] = "19"; 


			//Въвеждане на втори ред
			table[1,(int)ti.ime] = "Кирил"; table[1,(int)ti.familia] = "Манолов";table[1,(int)ti.godini] = "18";

			//Console.WriteLine ((table [0, 0]) [0] + ". " + table [0, 1] + ", " + table [0, 2] + " г.");

			//Печат
			Console.Write ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine  ()) -1;

			Console.WriteLine (
				(
				table [_index,(int) ti.ime]) [0] + ". " + 
				table [_index, (int)ti.familia] + ", " + 
				table [_index,(int) ti.godini] + " -. ");

			//Създаване на масив
			//			string[] row = new string[3];
			//
			//			row [0] = "Ред 1";
			//			row [1] = "Ред 2";
			//			row [2] = "Ред 3"; 
			//		 
			//			Console.WriteLine ("Масив row:" + row [0] + ", "+ row [1] + ", "+ row [2] + "\n");
			//
			//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			//			Console.WriteLine ("Броят на цифрите в масива:\n" + "1,2,3,4,5,6,7,8,9\n\nе: " + parse.Length);
			//
			//			string list1 = string.Join (";", parse);
			//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");

		}
	}
}
