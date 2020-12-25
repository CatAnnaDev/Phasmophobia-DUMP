/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	// [NativeConditional] // 0x00000001801343B0-0x0000000180134430
	// [NativeHeader] // 0x00000001801343B0-0x0000000180134430
	// [StaticAccessor] // 0x00000001801343B0-0x0000000180134430
	public static class AndroidJNI // TypeDefIndex: 3889
	{
		// Methods
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr FindClass(string name) => default; // 0x0000000180AB4540-0x0000000180AB4580
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr FromReflectedMethod(IntPtr refMethod) => default; // 0x0000000180AB4740-0x0000000180AB4780
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ExceptionOccurred() => default; // 0x0000000180AB4510-0x0000000180AB4540
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void ExceptionClear() {} // 0x0000000180AB44E0-0x0000000180AB4510
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int PushLocalFrame(int capacity) => default; // 0x0000000180AB4FD0-0x0000000180AB5010
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr PopLocalFrame(IntPtr ptr) => default; // 0x0000000180AB4F90-0x0000000180AB4FD0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewGlobalRef(IntPtr obj) => default; // 0x0000000180AB4DA0-0x0000000180AB4DE0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void DeleteGlobalRef(IntPtr obj) {} // 0x0000000180AB4420-0x0000000180AB4460
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewWeakGlobalRef(IntPtr obj) => default; // 0x0000000180AB4F50-0x0000000180AB4F90
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void DeleteWeakGlobalRef(IntPtr obj) {} // 0x0000000180AB44A0-0x0000000180AB44E0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewLocalRef(IntPtr obj) => default; // 0x0000000180AB4DE0-0x0000000180AB4E20
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void DeleteLocalRef(IntPtr obj) {} // 0x0000000180AB4460-0x0000000180AB44A0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4E70-0x0000000180AB4ED0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetObjectClass(IntPtr obj) => default; // 0x0000000180AB4940-0x0000000180AB4980
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB48A0-0x0000000180AB4900
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB4840-0x0000000180AB48A0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB4BC0-0x0000000180AB4C20
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB4A70-0x0000000180AB4AD0
		public static IntPtr NewString(string chars) => default; // 0x0000000180AB4F10-0x0000000180AB4F50
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		private static IntPtr NewStringFromStr(string chars) => default; // 0x0000000180AB4F10-0x0000000180AB4F50
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static string GetStringChars(IntPtr str) => default; // 0x0000000180AB4D60-0x0000000180AB4DA0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4360-0x0000000180AB43C0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3E20-0x0000000180AB3E80
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3D60-0x0000000180AB3DC0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3BE0-0x0000000180AB3C40
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3EE0-0x0000000180AB3F40
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3E80-0x0000000180AB3EE0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3C40-0x0000000180AB3CA0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3D00-0x0000000180AB3D60
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3CA0-0x0000000180AB3D00
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3DC0-0x0000000180AB3E20
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) {} // 0x0000000180AB43C0-0x0000000180AB4420
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB42A0-0x0000000180AB4300
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4180-0x0000000180AB41E0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB40C0-0x0000000180AB4120
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3F40-0x0000000180AB3FA0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4240-0x0000000180AB42A0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB41E0-0x0000000180AB4240
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB3FA0-0x0000000180AB4000
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4060-0x0000000180AB40C0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4000-0x0000000180AB4060
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB4120-0x0000000180AB4180
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) {} // 0x0000000180AB4300-0x0000000180AB4360
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4D10-0x0000000180AB4D60
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4C20-0x0000000180AB4C70
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4980-0x0000000180AB49D0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4C70-0x0000000180AB4CC0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB49D0-0x0000000180AB4A20
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4CC0-0x0000000180AB4D10
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4B20-0x0000000180AB4B70
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4B70-0x0000000180AB4BC0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4AD0-0x0000000180AB4B20
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB4A20-0x0000000180AB4A70
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToBooleanArray(bool[] array) => default; // 0x0000000180AB5060-0x0000000180AB50A0
		[Obsolete] // 0x0000000180138CC0-0x0000000180138D00
		[ThreadSafe] // 0x0000000180138CC0-0x0000000180138D00
		public static IntPtr ToByteArray(byte[] array) => default; // 0x0000000180AB50A0-0x0000000180AB50E0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToSByteArray(sbyte[] array) => default; // 0x0000000180AB5270-0x0000000180AB52B0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToCharArray(char[] array) => default; // 0x0000000180AB50E0-0x0000000180AB5120
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToShortArray(short[] array) => default; // 0x0000000180AB52B0-0x0000000180AB52F0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToIntArray(int[] array) => default; // 0x0000000180AB51A0-0x0000000180AB51E0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToLongArray(long[] array) => default; // 0x0000000180AB51E0-0x0000000180AB5220
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToFloatArray(float[] array) => default; // 0x0000000180AB5160-0x0000000180AB51A0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToDoubleArray(double[] array) => default; // 0x0000000180AB5120-0x0000000180AB5160
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) => default; // 0x0000000180AB5220-0x0000000180AB5270
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static bool[] FromBooleanArray(IntPtr array) => default; // 0x0000000180AB4580-0x0000000180AB45C0
		[Obsolete] // 0x0000000180139750-0x00000001801397A0
		[ThreadSafe] // 0x0000000180139750-0x00000001801397A0
		public static byte[] FromByteArray(IntPtr array) => default; // 0x0000000180AB45C0-0x0000000180AB4600
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static sbyte[] FromSByteArray(IntPtr array) => default; // 0x0000000180AB4780-0x0000000180AB47C0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static char[] FromCharArray(IntPtr array) => default; // 0x0000000180AB4600-0x0000000180AB4640
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static short[] FromShortArray(IntPtr array) => default; // 0x0000000180AB47C0-0x0000000180AB4800
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int[] FromIntArray(IntPtr array) => default; // 0x0000000180AB46C0-0x0000000180AB4700
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static long[] FromLongArray(IntPtr array) => default; // 0x0000000180AB4700-0x0000000180AB4740
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static float[] FromFloatArray(IntPtr array) => default; // 0x0000000180AB4680-0x0000000180AB46C0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static double[] FromDoubleArray(IntPtr array) => default; // 0x0000000180AB4640-0x0000000180AB4680
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static int GetArrayLength(IntPtr array) => default; // 0x0000000180AB4800-0x0000000180AB4840
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewShortArray(int size) => default; // 0x0000000180AB4ED0-0x0000000180AB4F10
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) => default; // 0x0000000180AB4E20-0x0000000180AB4E70
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static IntPtr GetObjectArrayElement(IntPtr array, int index) => default; // 0x0000000180AB4900-0x0000000180AB4940
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) {} // 0x0000000180AB5010-0x0000000180AB5060
	}
}
