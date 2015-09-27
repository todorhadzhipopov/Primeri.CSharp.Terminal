using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//bool _b = true;
			//bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };
			int _ui  = Convert.ToInt32 (Console.ReadLine () );

//			bool _check01= _ui <= _i.Length;
//			bool _check02 = _ui > 0;
//
//			bool _exp01 = _check01 && _check02; //Логическo и "&&"
//			bool _exp02 = _check01 || _check02; //Логическо или "||"
//			bool _exp03 = ! _check01;  //Отрицание "!"
//
//
//			Console.WriteLine ("Логическо И: " + _exp01);
//			Console.WriteLine ("Логическо Или: "+ _exp02);
//			Console.WriteLine ("Отрицание на : " + _check01 + ": " + _exp03);

			if (_ui > 0 && _ui <= _i.Length) {
				Console.WriteLine (_i [_ui - 1]);

			} 

			{
				if (_ui > _i.Length)
					Console.WriteLine ("Индексът е прекалено голям\n\n");
		
			}

			{
				if (_ui <= _i.Length)
					Console.WriteLine ("Индексът е прекалено малък\n\n");
			}			
	}



	}
}
