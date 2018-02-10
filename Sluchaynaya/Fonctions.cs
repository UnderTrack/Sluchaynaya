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
			Console.WriteLine();
			Console.WriteLine("Multiplying...");
			byte A = Memory.SI[0];
			byte B = Memory.SI[1];
			int _R;
			_R = A * B;
			Memory.AX[0] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} * {1} = {2}", Memory.SI[0], Memory.SI[1], Memory.AX[0]);
			Console.WriteLine();
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
		public static void Divide(Memory Memory)
		{
			Console.WriteLine();
			Console.WriteLine("Dividing...");
			byte A = Memory.SI[2];
			byte B = Memory.SI[3];
			int _R;
			_R = A / B;
			Memory.AX[1] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} / {1} = {2}", Memory.SI[2], Memory.SI[3], Memory.AX[1]);
			Console.WriteLine();
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
		public static void Add(Memory Memory)
		{
			Console.WriteLine();
			Console.WriteLine("Adding...");
			byte A = Memory.SI[4];
			byte B = Memory.SI[5];
			int _R;
			_R = A + B;
			Memory.AX[2] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} + {1} = {2}", Memory.SI[4], Memory.SI[5], Memory.AX[2]);
			Console.WriteLine();
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
		public static void Substract(Memory Memory)
		{
			Console.WriteLine();
			Console.WriteLine("Substracting...");
			byte A = Memory.SI[6];
			byte B = Memory.SI[7];
			int _R;
			_R = A - B;
			Memory.AX[3] = BitConverter.GetBytes(_R)[0];
			Console.WriteLine("{0} - {1} = {2}", Memory.SI[6], Memory.SI[7], Memory.AX[3]);
			Console.WriteLine();
			/*Debug
			string RDebug = Convert.ToString(_R);
			Console.Write("Value sent to memory : ");
			Console.WriteLine(RDebug);*/
		}
		public class Reset
		{
			public static void AX(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting AX...");
				Memory.AX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void CX(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting CX...");
				Memory.CX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void DX(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting DX...");
				Memory.DX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void SI(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting SI...");
				Memory.SI = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void SP(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting SP...");
				Memory.SP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void BP(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting BP...");
				Memory.BP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void CS(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting CS...");
				Memory.CS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void DS(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting DS...");
				Memory.DS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void SS(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting SS...");
				Memory.SS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void ES(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting ES...");
				Memory.ES = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void IP(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting IP...");
				Memory.IP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
			public static void All(Memory Memory)
			{
				Console.WriteLine();
				Console.WriteLine("Reseting all Memory byte arrays...");
				Memory.AX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.CX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.DX = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.SI =  new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.SP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.BP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.CS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.DS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.SS = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.ES = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Memory.IP = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
				Console.WriteLine("Reset completed...");
			}
		}
	}
}