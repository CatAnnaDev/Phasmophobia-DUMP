/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public abstract class IK : SolverManager // TypeDefIndex: 6697
	{
		// Constructors
		protected IK() {} // 0x00000001809C03B0-0x00000001809C03C0
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver() {} // 0x00000001809C02D0-0x00000001809C03B0
		protected override void InitiateSolver() {} // 0x00000001809C0260-0x00000001809C02D0
		protected override void FixTransforms() {} // 0x00000001809C01F0-0x00000001809C0260
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
