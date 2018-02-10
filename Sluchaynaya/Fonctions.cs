// Copyright 2018 - Underen
//
// > Fonctions.cs
//
using System;
namespace Sluchaynaya
{
	public class Fonctions
	{
		public static void Multiply(Memory Memory)
		{
			Console.WriteLine("Multiplying...");
			byte A = Memory.SI[0];
			byte B = Memory.SI[1];
			int _R;
			_R = A * B;
			Memory.AX[0] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} * {1} = {2}", Memory.SI[0], Memory.SI[1], Memory.AX[0]);
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
		public static void Divide(Memory Memory)
		{
			Console.WriteLine("Dividing...");
			byte A = Memory.SI[2];
			byte B = Memory.SI[3];
			int _R;
			_R = A / B;
			Memory.AX[1] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} / {1} = {2}", Memory.SI[2], Memory.SI[3], Memory.AX[1]);
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
	}
}
