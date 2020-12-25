/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class Framer<T> // TypeDefIndex: 4710
	{
		// Fields
		private T[] frame;
		private int sizeofT;
		private int framePos;
	
		// Constructors
		public Framer() {} // Dummy constructor
		public Framer(int frameSize) {}
	
		// Methods
		public int Count(int bufLen) => default;
		// [IteratorStateMachine] // 0x0000000180132940-0x0000000180132990
		public IEnumerable<T[]> Frame(T[] buf) => default;
	}
}
