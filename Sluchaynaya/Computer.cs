// Copyright 2018 - Underen
//
// > Program.cs
//
using System;

namespace Sluchaynaya
{
	class PCMain
	{
		static void Main()
		{
			//Initializing a memory
			Memory MEM = new Memory();
			MEM.AX = new byte[4] { 0, 0, 0, 0 };
			MEM.BX = 0;
			MEM.CX = new byte[4] { 0, 0, 0, 0 };
			MEM.DX = new byte[4] { 0, 0, 0, 0 };
			MEM.SI = new byte[4] { 0, 0, 0, 0 };
			MEM.DI = 0;
			MEM.SP = new byte[4] { 0, 0, 0, 0 };
			MEM.BP = new byte[4] { 0, 0, 0, 0 };
			MEM.CS = new byte[4] { 0, 0, 0, 0 };
			MEM.DS = new byte[4] { 0, 0, 0, 0 };
			MEM.SS = new byte[4] { 0, 0, 0, 0 };
			MEM.ES = new byte[4] { 0, 0, 0, 0 };
			MEM.FS = 0;
			MEM.GS = 0;
			MEM.FLAG = 0;
			MEM.IP = new byte[4] { 0, 0, 0, 0 };
			MEM.DG = 0;
			MEM.EP = 0;

			//YKR
			Console.WriteLine("Hello World !");

			//Initialising data for multiplication
			Console.WriteLine("Initializing Bytes :");
			MEM.SI[0] = 2;
			MEM.SI[1] = 3;
			//Debug
			Console.WriteLine("AX : {0} ", BitConverter.ToString(MEM.AX));
			Console.WriteLine("SI : {0} ", BitConverter.ToString(MEM.SI));
			//Multiplying
			Fonctions.Multiply(MEM);
			//Debug
			Console.WriteLine("AX : {0} ", BitConverter.ToString(MEM.AX));
			Console.WriteLine("SI : {0} ", BitConverter.ToString(MEM.SI));

			//Initialising data for division
			Console.WriteLine("Initializing Bytes :");
			MEM.SI[2] = 10;
			MEM.SI[3] = 5;
			//Debug
			Console.WriteLine("AX : {0} ", BitConverter.ToString(MEM.AX));
			Console.WriteLine("SI : {0} ", BitConverter.ToString(MEM.SI));
			//Dividing
			Fonctions.Divide(MEM);
			//Debug
			Console.WriteLine("AX : {0} ", BitConverter.ToString(MEM.AX));
			Console.WriteLine("SI : {0} ", BitConverter.ToString(MEM.SI));

			//Clean-up
			Console.SetCursorPosition(0, Console.WindowHeight - 1);
		}
	}
}
