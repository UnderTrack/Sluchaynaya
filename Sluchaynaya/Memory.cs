// Copyright 2018 - Underen
//
// > Memory.cs
//
using System;

namespace Sluchaynaya
{
	public class Memory
	{
		//General Registers
		public byte[] AX; //Will be the storage for Advanced Maths but also, at some point string storage.
		public byte   BX; //Will be the MOV fonction's buffer.
		public byte[] CX; //Will be a counter for operations.
		public byte[] DX; //Will be listing O/I ports if I do it one day.
		//Others Registers
		public byte[] SI; //Will be the Source for operations.
		public byte   DI; //Will be the Destination of Operations.
		public byte[] SP; //Not sure if I implement stacks properly yet.
		public byte[] BP; //Not sure if I implement stacks properly yet.
		//General Segments
		public byte[] CS; //Will be to store code/strings.
		public byte[] DS; //Willl be to store data/mapping.
		public byte[] SS; //Will be to manage Stacks if I implement them.
		public byte[] ES; //Will be for whatever esle I have to store/manage.
		//Other Segments
		public byte   FS; //In case I need it ?
		public byte   GS; //In case I need it too ?
		public byte   FLAG; //Will handle FLAGs if I implement them.
		public byte[] IP; //Will handle Instructions' addrs if I decide to get on it.
		//Extra
		public byte DG; //Will be for storing stuff for debugging
		public byte EP; //Will be for printing stuff for debugging
	}
}