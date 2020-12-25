/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	internal class AndroidJNISafe // TypeDefIndex: 3890
	{
		// Constructors
		public AndroidJNISafe() {} // Dummy constructor
	
		// Methods
		public static void CheckException() {} // 0x0000000180AB19A0-0x0000000180AB1B60
		public static void DeleteGlobalRef(IntPtr globalref) {} // 0x0000000180AB1B60-0x0000000180AB1BD0
		public static void DeleteWeakGlobalRef(IntPtr globalref) {} // 0x0000000180AB1C40-0x0000000180AB1CB0
		public static void DeleteLocalRef(IntPtr localref) {} // 0x0000000180AB1BD0-0x0000000180AB1C40
		public static IntPtr NewString(string chars) => default; // 0x0000000180AB33A0-0x0000000180AB3460
		public static string GetStringChars(IntPtr str) => default; // 0x0000000180AB3210-0x0000000180AB32D0
		public static IntPtr GetObjectClass(IntPtr ptr) => default; // 0x0000000180AB2810-0x0000000180AB28D0
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB2E40-0x0000000180AB2F10
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig) => default; // 0x0000000180AB2680-0x0000000180AB2750
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB25B0-0x0000000180AB2680
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) => default; // 0x0000000180AB2B20-0x0000000180AB2BF0
		public static IntPtr FromReflectedMethod(IntPtr refMethod) => default; // 0x0000000180AB22B0-0x0000000180AB2370
		public static IntPtr FindClass(string name) => default; // 0x0000000180AB1CB0-0x0000000180AB1D70
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB32D0-0x0000000180AB33A0
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2F10-0x0000000180AB2FD0
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB3150-0x0000000180AB3210
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2990-0x0000000180AB2A50
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2A50-0x0000000180AB2B20
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2BF0-0x0000000180AB2CC0
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2D80-0x0000000180AB2E40
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB3090-0x0000000180AB3150
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2FD0-0x0000000180AB3090
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB28D0-0x0000000180AB2990
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) => default; // 0x0000000180AB2CC0-0x0000000180AB2D80
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) {} // 0x0000000180AB1750-0x0000000180AB1810
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1410-0x0000000180AB14E0
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1680-0x0000000180AB1750
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0FE0-0x0000000180AB10B0
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB10B0-0x0000000180AB1190
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1190-0x0000000180AB1270
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1340-0x0000000180AB1410
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB15B0-0x0000000180AB1680
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB14E0-0x0000000180AB15B0
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0F10-0x0000000180AB0FE0
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1270-0x0000000180AB1340
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) {} // 0x0000000180AB18E0-0x0000000180AB19A0
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0CA0-0x0000000180AB0D70
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB1810-0x0000000180AB18E0
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0870-0x0000000180AB0940
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0940-0x0000000180AB0A20
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0A20-0x0000000180AB0B00
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0BD0-0x0000000180AB0CA0
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0E40-0x0000000180AB0F10
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0D70-0x0000000180AB0E40
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB07A0-0x0000000180AB0870
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x0000000180AB0B00-0x0000000180AB0BD0
		public static char[] FromCharArray(IntPtr array) => default; // 0x0000000180AB1EF0-0x0000000180AB1FB0
		public static double[] FromDoubleArray(IntPtr array) => default; // 0x0000000180AB1FB0-0x0000000180AB2070
		public static float[] FromFloatArray(IntPtr array) => default; // 0x0000000180AB2070-0x0000000180AB2130
		public static long[] FromLongArray(IntPtr array) => default; // 0x0000000180AB21F0-0x0000000180AB22B0
		public static short[] FromShortArray(IntPtr array) => default; // 0x0000000180AB2430-0x0000000180AB24F0
		public static byte[] FromByteArray(IntPtr array) => default; // 0x0000000180AB1E30-0x0000000180AB1EF0
		public static sbyte[] FromSByteArray(IntPtr array) => default; // 0x0000000180AB2370-0x0000000180AB2430
		public static bool[] FromBooleanArray(IntPtr array) => default; // 0x0000000180AB1D70-0x0000000180AB1E30
		public static int[] FromIntArray(IntPtr array) => default; // 0x0000000180AB2130-0x0000000180AB21F0
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) => default; // 0x0000000180AB39A0-0x0000000180AB3A60
		public static IntPtr ToCharArray(char[] array) => default; // 0x0000000180AB35E0-0x0000000180AB36A0
		public static IntPtr ToDoubleArray(double[] array) => default; // 0x0000000180AB36A0-0x0000000180AB3760
		public static IntPtr ToFloatArray(float[] array) => default; // 0x0000000180AB3760-0x0000000180AB3820
		public static IntPtr ToLongArray(long[] array) => default; // 0x0000000180AB38E0-0x0000000180AB39A0
		public static IntPtr ToShortArray(short[] array) => default; // 0x0000000180AB3B20-0x0000000180AB3BE0
		public static IntPtr ToByteArray(byte[] array) => default; // 0x0000000180AB3520-0x0000000180AB35E0
		public static IntPtr ToSByteArray(sbyte[] array) => default; // 0x0000000180AB3A60-0x0000000180AB3B20
		public static IntPtr ToBooleanArray(bool[] array) => default; // 0x0000000180AB3460-0x0000000180AB3520
		public static IntPtr ToIntArray(int[] array) => default; // 0x0000000180AB3820-0x0000000180AB38E0
		public static IntPtr GetObjectArrayElement(IntPtr array, int index) => default; // 0x0000000180AB2750-0x0000000180AB2810
		public static int GetArrayLength(IntPtr array) => default; // 0x0000000180AB24F0-0x0000000180AB25B0
	}
}
