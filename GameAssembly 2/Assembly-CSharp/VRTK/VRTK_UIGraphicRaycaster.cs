﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	public class VRTK_UIGraphicRaycaster : GraphicRaycaster // TypeDefIndex: 7610
	{
		// Fields
		protected Canvas u091Bu091Fu091Eu0924u0926u091Fu091Du0921u0929u091Du0922; // 0x40
		protected Vector2 u0920u091Bu0922u0927u0929u0926u0923u091Bu0920u0924u0928; // 0x48
		protected const float u091Cu0929u0927u0925u091Au091Au0921u091Cu0928u0921u091B = 1E-05f; // Metadata: 0x00653D40
		[NonSerialized]
		private static List<RaycastResult> u091Au0925u0924u0929u091Cu091Cu091Eu0921u091Bu0928u0927; // 0x00
	
		// Properties
		protected virtual Canvas णजणचढञदथजधट { get => default; } // 0x00000001812A13C0-0x00000001812A1470 
	
		// Constructors
		static VRTK_UIGraphicRaycaster() {} // 0x00000001812B1400-0x00000001812B1460
		public VRTK_UIGraphicRaycaster() {} // 0x00000001812B1460-0x00000001812B14C0
	
		// Methods
		protected virtual float u091Cu091Au0922u0923u0920u0922u0926u0925u0929u0923u0929(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812985F0-0x00000001812989D0
		protected virtual void u091Du0925u0927u0927u0929u091Eu0926u0926u091Cu0926u0922(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x000000018129B540-0x000000018129B8C0
		protected virtual void u0926u091Eu091Fu091Eu0922u091Cu0920u091Au0921u091Eu0920(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812AAB10-0x00000001812AB130
		protected virtual float u091Bu0921u0923u0926u091Fu0929u0924u0928u091Bu091Fu091E(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812979D0-0x0000000181297DB0
		protected virtual float u0923u091Bu091Cu091Bu0929u0929u0924u0928u091Fu0927u0921(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A3830-0x00000001812A3C10
		public override void u0928u0924u0929u0924u0925u091Du091Fu091Cu0921u091Cu0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812AF660-0x00000001812AF870
		protected virtual float u0925u0926u0922u0925u091Cu0927u0928u0925u0929u0927u0923(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A9800-0x00000001812A9BE0
		protected virtual float u0924u0924u091Cu091Bu091Bu0929u091Bu091Bu091Au0927u0928(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A74C0-0x00000001812A78A0
		protected virtual void u0927u0929u091Eu0924u0922u0929u0925u0922u0922u091Fu0920(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AE590-0x00000001812AE910
		protected virtual void u091Eu0920u091Du091Fu0925u0920u091Au091Fu0926u0920u0922(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129C040-0x000000018129C660
		protected virtual float u0927u0929u091Eu091Eu0929u0921u0925u0927u091Au0926u0921(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AE1B0-0x00000001812AE590
		public override void u0924u091Du091Cu0928u0925u0928u0923u0923u091Bu0924u091D(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A5F30-0x00000001812A6140
		protected virtual float u0920u0924u091Eu0928u0922u0928u0928u0921u0922u091Bu091D(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129FDE0-0x00000001812A01C0
		protected virtual void u091Bu0923u091Fu0920u0923u0928u0921u0925u0927u0923u091C(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x0000000181297DB0-0x00000001812983E0
		protected virtual void u0927u0924u091Fu091Au091Au091Bu091Au0927u091Cu091Bu091D(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812ADA50-0x00000001812ADDD0
		protected virtual Canvas u0921u091Cu0926u0925u091Cu0925u091Eu0929u091Fu091Au091B() => default; // 0x00000001812A1860-0x00000001812A1910
		public override void u0925u091Cu091Eu0920u0922u0923u091Du0927u0921u0928u091F(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A8A70-0x00000001812A8C80
		protected virtual float u0928u091Bu0927u0920u091Cu0929u0920u091Au091Du091Eu0929(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AECF0-0x00000001812AF0D0
		protected virtual void u0922u0926u091Eu0920u0926u091Bu0922u0927u0925u091Fu091D(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A2C10-0x00000001812A3230
		protected virtual Canvas u0921u0928u091Du091Fu091Au0924u091Cu091Eu0920u0921u0924() => default; // 0x00000001812A25E0-0x00000001812A2690
		protected virtual Canvas u0922u091Du091Eu091Fu091Eu091Cu0924u0921u091Fu0928u0924() => default; // 0x00000001812A2950-0x00000001812A2A00
		protected virtual float u0927u0921u0922u0921u091Bu0927u0925u0923u0923u0929u091A(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AD2F0-0x00000001812AD6D0
		public override void u091Fu0924u0925u091Au0922u091Cu0921u0924u0920u091Du0922(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x000000018129E5B0-0x000000018129E7C0
		protected virtual void u091Au091Fu0929u091Du091Bu091Du091Fu091Eu091Au0923u0922(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812960B0-0x00000001812966D0
		protected virtual float u0920u0929u0921u091Fu0928u091Bu091Bu091Bu091Fu0922u0926(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A0C00-0x00000001812A0FE0
		public override void u091Cu0921u091Cu091Du0928u0927u0926u0923u0927u0923u0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x0000000181298DB0-0x0000000181298FC0
		protected virtual Canvas u091Du091Bu091Au0926u0922u0923u091Eu091Fu091Eu0925u091D() => default; // 0x000000018129A830-0x000000018129A8E0
		protected virtual float u0920u0923u0929u091Bu0921u0925u091Eu091Eu0923u091Au0924(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129F950-0x000000018129FD30
		public override void u091Cu0924u0922u091Eu091Eu0924u091Cu091Eu0920u091Du0927(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812991D0-0x00000001812993E0
		protected virtual float u091Cu091Cu0927u0925u0927u091Fu091Cu0923u0923u0925u0923(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812989D0-0x0000000181298DB0
		protected virtual void u0927u0922u0929u091Eu091Cu0929u0922u091Eu0929u0927u0928(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AD6D0-0x00000001812ADA50
		protected virtual Canvas u0921u0924u0923u091Cu091Eu091Eu0928u0925u0920u0927u0922() => default; // 0x00000001812A2320-0x00000001812A23D0
		protected virtual Canvas u091Du0928u0929u0924u091Cu0927u0925u091Du0926u0927u0920() => default; // 0x000000018129B8C0-0x000000018129B970
		public override void u0929u091Cu0927u0928u0924u0926u091Au0925u0929u0926u091B(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812B0480-0x00000001812B0690
		public override void u091Au091Eu091Eu0923u0929u0924u0922u0922u0928u091Fu091C(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x0000000181295DF0-0x0000000181296000
		protected virtual float u0927u0929u0924u0927u0920u0923u0923u0926u0924u091Bu0927(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AE910-0x00000001812AECF0
		protected virtual float u0920u0929u0926u0922u0921u091Au0927u0923u0920u091Eu091B(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A0FE0-0x00000001812A13C0
		protected virtual float u091Eu0927u0921u0923u0921u0929u091Eu091Au091Fu091Du0927(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129C660-0x000000018129CA40
		public override void Raycast(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812954C0-0x00000001812956D0
		public override void u0923u0927u091Fu091Au0922u0920u0920u0924u0924u0922u0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A54F0-0x00000001812A5700
		public override void u0925u0923u0926u0920u0924u0926u0922u091Au0920u0928u091D(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A95F0-0x00000001812A9800
		protected virtual void u091Fu0924u0923u091Fu0926u091Du091Fu091Fu0928u0927u091F(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129DF90-0x000000018129E5B0
		protected virtual float u0925u091Cu091Fu0920u091Du091Du091Au0926u0929u0922u0927(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A8C80-0x00000001812A9060
		protected virtual Canvas u0928u091Eu0923u0920u091Cu091Fu091Cu091Cu0924u0921u0924() => default; // 0x00000001812AF0D0-0x00000001812AF180
		protected virtual Canvas u0920u0927u0923u0927u091Du0925u0920u0927u0921u0923u0921() => default; // 0x00000001812A0B50-0x00000001812A0C00
		protected virtual Canvas u091Du0925u0926u0922u091Eu091Bu091Au0925u0928u0920u091D() => default; // 0x000000018129B490-0x000000018129B540
		protected virtual Canvas u0928u091Fu0921u0926u0923u091Eu0926u0927u091Au091Cu0926() => default; // 0x00000001812AF230-0x00000001812AF2E0
		protected virtual float u091Cu0928u091Cu0920u0923u091Cu091Bu0923u0920u0926u0920(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x0000000181299AC0-0x0000000181299EA0
		protected virtual Canvas u091Eu0928u091Cu0926u091Au091Du091Bu0922u0927u091Eu091C() => default; // 0x000000018129CA40-0x000000018129CAF0
		protected virtual Canvas u0926u091Fu091Fu0927u091Cu0920u0921u091Cu0928u0927u0926() => default; // 0x00000001812AB130-0x00000001812AB1E0
		protected virtual void u0928u0920u0920u0929u091Cu0927u0925u0925u0929u0921u0926(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AF2E0-0x00000001812AF660
		protected virtual void u0924u0921u0927u0922u091Eu091Du0928u091Au0921u0927u0922(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812A6D60-0x00000001812A70E0
		protected virtual void u0925u0923u0925u091Cu0923u091Au0924u0929u0922u0923u0920(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812A9270-0x00000001812A95F0
		public override void u0929u0925u0929u091Du0925u0920u0929u091Eu0926u0925u0926(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812B1140-0x00000001812B1350
		protected virtual void u0924u0920u0923u0928u091Du091Bu091Bu0923u0920u091Cu091D(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A6740-0x00000001812A6D60
		public override void u091Bu0928u091Fu0927u0926u0922u091Cu091Du091Eu0920u0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812983E0-0x00000001812985F0
		protected virtual float u091Du0925u0920u091Eu091Eu0929u0920u0925u091Du0920u0926(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129B0A0-0x000000018129B490
		protected virtual void u091Au091Au0923u0929u0927u0928u0924u0926u091Eu091Du0920(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812956D0-0x0000000181295A50
		public override void u091Fu0923u091Bu091Eu0921u091Du0928u091Au091Du0927u0925(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x000000018129DD80-0x000000018129DF90
		protected virtual void u0926u091Du0929u091Au0929u091Du0924u091Au0921u0928u091B(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AA580-0x00000001812AA900
		protected virtual Canvas u0923u0920u0921u091Cu0925u0928u0925u091Cu091Cu0922u0920() => default; // 0x00000001812A4CE0-0x00000001812A4D90
		protected virtual float u0926u0925u091Eu0926u091Cu0927u091Fu0926u091Au091Du0922(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AC0F0-0x00000001812AC4D0
		protected virtual Canvas u0927u091Fu0922u0924u0928u0921u0922u091Au091Bu091Du0929() => default; // 0x00000001812AD240-0x00000001812AD2F0
		protected virtual float u091Du0920u091Cu091Du0929u0929u091Eu091Au091Du0923u091E(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129A8E0-0x000000018129ACC0
		public override void u091Au0928u091Du0926u0923u0923u0926u0920u0925u0928u0922(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x0000000181296BD0-0x0000000181296DE0
		protected virtual void u091Bu091Cu0924u091Au0929u0927u091Bu0925u0929u0920u0922(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x0000000181297270-0x0000000181297620
		protected virtual Canvas u0929u0926u0921u0927u091Cu0922u0923u0920u0926u0924u091B() => default; // 0x00000001812B1350-0x00000001812B1400
		protected virtual float u091Du0923u0922u0924u0922u0922u0926u0925u0929u0921u0924(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129ACC0-0x000000018129B0A0
		protected virtual void u091Cu0929u091Eu091Bu0925u0923u091Du0920u0928u091Au0925(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x0000000181299EA0-0x000000018129A240
		public override void u091Fu091Cu0927u091Fu0925u0925u0923u0926u091Au091Eu0927(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x000000018129D1C0-0x000000018129D3D0
		protected virtual float u0920u0924u0924u091Fu0928u0924u0927u0920u091Eu091Du091B(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A01C0-0x00000001812A05A0
		protected virtual void u091Bu091Du091Au0924u091Bu091Bu091Eu091Au0927u0920u091D(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x0000000181297620-0x00000001812979D0
		protected virtual float u091Bu091Cu091Du091Fu091Cu0922u091Du0922u0929u091Fu091D(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x0000000181296E90-0x0000000181297270
		protected virtual Canvas u091Au0920u0927u0921u0925u0921u0928u0922u091Eu0925u0926() => default; // 0x00000001812966D0-0x0000000181296780
		protected virtual void u0923u0922u091Bu091Du091Eu0929u091Eu0927u0920u0926u0927(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812A5170-0x00000001812A54F0
		protected virtual float u0924u0923u0926u0929u091Bu0923u0926u0925u091Du091Eu091C(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A70E0-0x00000001812A74C0
		protected virtual void u0920u0927u091Bu0922u0922u0928u0926u0922u091Du0924u091B(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812A07B0-0x00000001812A0B50
		public override void u0921u0924u0924u091Cu0926u0925u0928u0921u0925u091Eu0928(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A23D0-0x00000001812A25E0
		public override void u0922u091Du091Bu0929u0925u0921u091Eu0923u0924u091Eu0929(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A2740-0x00000001812A2950
		protected virtual Canvas u0929u0923u0926u091Bu0920u0927u0922u0920u091Eu091Eu091F() => default; // 0x00000001812B1090-0x00000001812B1140
		protected virtual float u0928u0928u0926u0920u0926u0927u0927u0929u0921u091Fu0920(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812AFA80-0x00000001812AFE60
		protected virtual float u0923u0921u091Cu0925u0922u091Au0927u0923u0924u0924u0920(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A4D90-0x00000001812A5170
		protected virtual Canvas u0923u091Eu0924u0922u091Du091Cu0923u091Eu0923u091Du0929() => default; // 0x00000001812A3C10-0x00000001812A3CC0
		public override void u0926u0925u0929u0922u0926u091Eu0929u0920u091Au0926u0928(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812AC4D0-0x00000001812AC6E0
		public override void u0924u091Bu091Fu091Fu0928u091Fu0922u0929u0924u091Cu0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A5D20-0x00000001812A5F30
		protected virtual float u0923u091Fu0921u091Bu0925u091Fu091Cu0924u0926u0928u0923(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A42E0-0x00000001812A46C0
		protected virtual void u0926u0920u0921u091Fu0924u091Bu0927u0920u0925u091Eu0929(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812AB3F0-0x00000001812ABA20
		protected virtual void u0921u091Du0928u091Bu0926u0925u0926u0921u0921u0922u091D(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A1CF0-0x00000001812A2320
		protected virtual void u0925u0927u0923u0929u0923u091Bu0927u0927u091Cu0923u0922(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A9BE0-0x00000001812AA200
		protected virtual void u091Fu091Eu091Eu0920u0924u091Cu091Bu0927u0921u0927u0921(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x000000018129DA00-0x000000018129DD80
		public override void u0923u091Au0922u0929u091Au091Du091Fu0927u0928u0929u0929(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A3620-0x00000001812A3830
		protected virtual void u0920u0920u091Bu0925u0924u091Fu0922u0920u0927u0920u091F(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129F330-0x000000018129F950
		protected virtual Canvas u091Fu091Bu091Eu091Au0922u0924u0924u0929u0920u0927u0920() => default; // 0x000000018129D110-0x000000018129D1C0
		protected virtual Canvas u0926u0922u091Bu0925u0929u0925u0928u091Fu0929u091Bu0923() => default; // 0x00000001812ABA20-0x00000001812ABAD0
		protected virtual void u0923u0927u0926u091Bu0924u0923u0920u091Fu091Cu0927u0926(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A5700-0x00000001812A5D20
		protected virtual void u0924u0929u0929u0923u091Au091Fu091Du091Fu091Cu091Fu091A(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812A80D0-0x00000001812A8450
		protected virtual void u0920u091Fu0927u0920u091Cu091Du091Bu091Bu0929u0922u091B(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x000000018129EF80-0x000000018129F330
		protected virtual void u0925u0929u091Eu0926u091Du091Fu091Fu0924u0926u0923u091F(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AA200-0x00000001812AA580
		protected virtual void u091Au0924u0925u0921u091Bu0922u091Cu0920u091Cu091Bu0921(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x0000000181296780-0x0000000181296B20
		protected virtual Canvas u091Cu0925u0925u0928u0926u0927u091Au091Au0920u091Eu0920() => default; // 0x00000001812993E0-0x0000000181299490
		protected virtual void u0923u091Eu0927u0928u0929u0929u0920u091Bu0920u0926u091F(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A3CC0-0x00000001812A42E0
		protected virtual float u0927u091Au091Fu0925u0927u091Bu091Eu0926u0925u0929u0926(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812ACE60-0x00000001812AD240
		protected virtual void u0926u0923u0929u0924u0923u091Cu0925u0924u0920u091Eu091F(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812ABAD0-0x00000001812AC0F0
		public override void u091Cu0924u091Du091Bu0926u091Bu091Au0927u091Du0922u0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x0000000181298FC0-0x00000001812991D0
		protected virtual void u091Cu0927u0922u0928u0929u0928u091Bu091Du0921u091Cu091B(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x0000000181299490-0x0000000181299AC0
		protected virtual Canvas u091Bu091Bu091Du0920u0922u0928u091Fu0924u0923u0923u091F() => default; // 0x0000000181296DE0-0x0000000181296E90
		public override void u0925u0920u091Bu091Bu0922u0928u0922u091Fu091Du091Cu0926(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A9060-0x00000001812A9270
		public override void u0924u0926u0924u091Fu0926u091Fu0929u091Cu0927u0927u0925(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A7EC0-0x00000001812A80D0
		protected virtual float u0926u0929u0927u0920u0920u0924u0926u091Fu0926u091Cu0927(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812ACA80-0x00000001812ACE60
		public override void u0920u0926u091Du0927u0922u091Bu0929u091Au0927u0928u091C(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A05A0-0x00000001812A07B0
		protected virtual void u091Eu091Au0920u0928u0920u0927u0925u091Fu0927u0923u091F(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129B970-0x000000018129BF90
		protected virtual float u0921u091Bu0925u091Cu0929u0929u091Cu091Au0923u091Cu091F(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A1470-0x00000001812A1860
		protected virtual Canvas u091Eu091Eu0922u091Au0923u0920u091Cu0921u0921u091Au0928() => default; // 0x000000018129BF90-0x000000018129C040
		protected virtual void u0929u091Bu0923u0920u0924u0926u0927u0922u0923u0928u0921(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812AFE60-0x00000001812B0480
		protected virtual float u0927u0929u091Cu0923u0927u0925u0928u0924u0924u0923u0929(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812ADDD0-0x00000001812AE1B0
		protected virtual Canvas u091Au0926u0922u091Bu0928u0924u091Du091Au0926u0928u091A() => default; // 0x0000000181296B20-0x0000000181296BD0
		protected virtual float u091Fu0924u0926u091Cu0923u0926u0924u0923u0926u0926u091D(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129E7C0-0x000000018129EBA0
		public override void u0926u091Eu091Eu0926u0928u091Fu0924u091Au091Du0921u0924(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812AA900-0x00000001812AAB10
		protected virtual float u0924u091Eu0921u0929u091Bu0927u0925u0929u0927u091Eu091B(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A6350-0x00000001812A6740
		protected virtual Canvas u0922u091Cu0924u0923u091Eu0923u0922u0926u0929u0924u091C() => default; // 0x00000001812A2690-0x00000001812A2740
		public override void u0928u0927u091Du091Du0929u0925u091Au0928u0921u0920u0922(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812AF870-0x00000001812AFA80
		public override void u091Cu0929u0921u091Bu091Fu0921u091Du0921u091Fu0920u0926(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x000000018129A240-0x000000018129A450
		protected virtual float u0922u0927u0929u0927u091Au091Eu0927u091Bu091Du091Bu091E(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A3230-0x00000001812A3620
		protected virtual void u091Fu091Eu091Cu0923u0926u0927u0927u0926u0921u0928u0929(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129D3D0-0x000000018129DA00
		protected virtual void u0926u0929u0923u0925u091Au091Eu091Cu0926u0925u0921u091E(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x00000001812AC6E0-0x00000001812ACA80
		protected virtual float u0929u091Fu091Eu091Du0928u091Cu091Bu0927u091Cu0926u0921(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812B0690-0x00000001812B0A70
		protected virtual Canvas u091Au091Fu0927u091Cu0924u0922u0926u091Au091Fu091Bu091B() => default; // 0x0000000181296000-0x00000001812960B0
		protected virtual void u0929u0922u0923u091Eu0920u091Bu091Du0927u0922u0926u0924(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812B0A70-0x00000001812B1090
		protected virtual void u091Au091Cu091Cu091Cu0925u0923u091Cu0920u091Fu0929u091E(ref PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, ref List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925, ref List<RaycastResult> u0929u091Cu091Fu0923u091Au0922u0922u091Fu0929u0924u091C) {} // 0x0000000181295A50-0x0000000181295DF0
		protected virtual Canvas u0920u0924u091Eu0920u091Au0929u091Bu0921u091Bu0926u0924() => default; // 0x000000018129FD30-0x000000018129FDE0
		protected virtual float u0921u091Du091Cu0920u0923u0921u091Au0922u0928u091Cu0920(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x00000001812A1910-0x00000001812A1CF0
		public override void u0926u0920u091Au0920u091Du0920u091Bu0926u0924u091Fu0926(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812AB1E0-0x00000001812AB3F0
		protected virtual Canvas u0928u091Fu091Eu0923u091Cu091Au0922u0926u091Du0923u0927() => default; // 0x00000001812AF180-0x00000001812AF230
		public override void u0924u091Du0926u091Du091Au0929u0921u091Eu0929u0923u0922(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A6140-0x00000001812A6350
		public override void u0922u091Fu091Bu0925u091Bu0928u0920u0925u091Eu0923u0925(PointerEventData u091Fu0927u0923u091Eu091Bu0921u0920u0922u091Au091Du0926, List<RaycastResult> u0926u0929u091Cu0921u091Fu0928u0924u0927u091Eu091Du0925) {} // 0x00000001812A2A00-0x00000001812A2C10
		protected virtual float u091Cu0929u0927u0928u0925u091Au0922u091Bu091Au0921u091E(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129A450-0x000000018129A830
		protected virtual float u091Fu0928u0924u0923u0925u0920u0921u0928u091Eu0926u0928(Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920) => default; // 0x000000018129EBA0-0x000000018129EF80
		protected virtual void u091Eu0928u0925u091Au091Eu091Bu0928u091Du091Bu0928u0923(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x000000018129CAF0-0x000000018129D110
		protected virtual void u0925u091Bu091Du091Eu0926u091Bu0927u091Cu0924u091Fu091A(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A8450-0x00000001812A8A70
		protected virtual void u0924u0925u0923u0921u0929u091Cu091Fu0929u091Au0928u091C(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A78A0-0x00000001812A7EC0
		protected virtual void u0923u091Fu0922u091Au0928u0922u0923u091Bu091Cu091Cu0923(Canvas u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F, Camera u091Fu091Au0920u091Cu091Au0920u0925u091Cu0926u0924u0929, Ray u0927u0922u091Fu091Au091Fu091Fu0923u0920u0921u0925u0920, ref List<RaycastResult> u0920u091Eu0923u091Eu0927u0921u0928u0924u0927u0922u0928) {} // 0x00000001812A46C0-0x00000001812A4CE0
	}
}