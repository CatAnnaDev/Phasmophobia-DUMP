﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class ParabolicMicrophone : MonoBehaviour // TypeDefIndex: 7084
{
	// Fields
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u091Du091Au0928u091Cu091Au0926u0925u0922u091Au091Du091A; // 0x18
	public List<Noise> u091Bu0923u091Du0929u0929u0927u0922u091Cu091Du0929u0925; // 0x20
	private float u0923u091Eu0926u0923u091Du0926u0920u091Eu0922u0922u0929; // 0x28
	private PhotonObjectInteract u091Cu0926u0926u091Au091Eu091Fu0921u091Eu091Bu091Du0920; // 0x30
	private PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x38
	private float u091Fu091Fu0922u091Bu0921u0929u0925u0929u0924u091Eu0928; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private BoxCollider col; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text screenText; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Renderer rend; // 0x58

	// Constructors
	public ParabolicMicrophone() {} // 0x0000000181A07610-0x0000000181A07680

	// Methods
	private void u0921u0924u091Fu091Au0927u0928u0922u0928u0925u091Au0925() {} // 0x0000000181A04520-0x0000000181A046E0
	private void u0926u0920u091Cu091Au091Du091Bu0929u0927u091Fu091Cu0927() {} // 0x0000000181A06070-0x0000000181A06250
	private void u0927u091Du0921u0925u091Cu0923u091Cu0924u091Bu0926u0928() {} // 0x0000000181A06340-0x0000000181A06500
	private IEnumerator u091Du0921u0927u0927u091Au0923u0920u0922u0928u091Cu0923() => default; // 0x0000000181A03740-0x0000000181A037B0
	private IEnumerator u091Bu0922u0924u0920u0921u091Bu091Au0925u091Eu0926u0920() => default; // 0x0000000181A02EF0-0x0000000181A02F60
	private void u0925u0923u0929u0926u0922u0922u0926u0924u0926u091Cu0928() {} // 0x0000000181A059D0-0x0000000181A05A40
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void UseNetworked() {} // 0x0000000181A07530-0x0000000181A07610
	private void u0921u0928u0922u091Bu091Du0923u091Cu0923u0922u0926u091F() {} // 0x0000000181A04830-0x0000000181A048B0
	private IEnumerator u0928u091Fu091Eu0928u0923u0927u0929u091Eu0920u0926u0928() => default; // 0x0000000181A069C0-0x0000000181A06A30
	private void u091Fu0922u091Fu091Fu091Cu0929u091Au0920u091Au0929u0929() {} // 0x0000000181A03FF0-0x0000000181A04060
	private void Awake() {} // 0x0000000181A029E0-0x0000000181A02AA0
	private void u0927u0926u0923u091Fu0927u091Cu0927u0921u0928u091Eu0921() {} // 0x0000000181A06630-0x0000000181A066B0
	private IEnumerator u0924u0920u091Eu091Du091Fu091Cu091Du091Fu091Bu0922u0923() => default; // 0x0000000181A057A0-0x0000000181A05810
	private void u091Eu0924u091Du0922u091Eu0924u0926u0928u0920u0921u091E() {} // 0x0000000181A03B20-0x0000000181A03BE0
	private IEnumerator u0929u0922u0922u0925u0925u091Fu0923u0927u091Au0928u0923() => default; // 0x0000000181A07270-0x0000000181A072E0
	private void u091Eu0921u091Bu0926u091Eu091Du0924u0928u091Fu0922u0927() {} // 0x0000000181A03AA0-0x0000000181A03B20
	private void u0927u091Cu0921u0928u0929u0928u091Au091Eu0920u091Au0922() {} // 0x0000000181A062C0-0x0000000181A06340
	private void u0922u091Au0927u091Fu0925u091Cu091Au0927u0927u091Du091B() {} // 0x0000000181A04A90-0x0000000181A04B00
	private void u0920u0924u0922u0923u0926u091Du0924u0923u091Eu091Bu091F() {} // 0x0000000181A04290-0x0000000181A04300
	private void u0928u0927u0925u091Eu0927u091Bu091Cu0924u0920u0920u0927() {} // 0x0000000181A06F50-0x0000000181A06FD0
	private IEnumerator u0925u0922u0921u091Bu0927u0925u0921u091Fu0928u0923u0923() => default; // 0x0000000181A05960-0x0000000181A059D0
	private void u0921u0923u091Eu0925u0921u0920u0923u091Au091Au0929u0920() {} // 0x0000000181A044A0-0x0000000181A04520
	private void u091Fu091Au091Du091Du0921u091Eu0920u0921u091Bu091Fu091A() {} // 0x0000000181A03DC0-0x0000000181A03F80
	private void u0928u091Fu091Cu091Eu0923u0920u0924u091Fu091Bu0923u091D() {} // 0x0000000181A068E0-0x0000000181A069C0
	private IEnumerator u091Eu091Cu091Bu0929u0929u0928u0926u0921u091Fu091Bu091D() => default; // 0x0000000181A03A30-0x0000000181A03AA0
	private void u0923u0927u091Au091Cu091Cu091Bu091Au0926u091Bu0929u0923() {} // 0x0000000181A05340-0x0000000181A05400
	private void u091Du091Eu091Cu0929u091Fu0921u091Du0929u0929u091Eu0928() {} // 0x0000000181A036C0-0x0000000181A03740
	private void u0920u0927u0925u0922u0926u0924u0920u0927u091Cu091Du0921() {} // 0x0000000181A04370-0x0000000181A04430
	private IEnumerator u091Du0927u0926u0926u0927u0920u0920u0927u0922u0928u091C() => default; // 0x0000000181A03890-0x0000000181A03900
	private void u0924u0927u0924u091Fu0925u0921u0924u091Du091Cu0928u091F() {} // 0x0000000181A05880-0x0000000181A058F0
	private IEnumerator u091Cu0926u091Du0921u0925u0927u0921u0929u0927u091Du0929() => default; // 0x0000000181A03480-0x0000000181A034F0
	private void u0928u0924u091Au091Eu0923u0922u0927u091Fu0929u091Bu0927() {} // 0x0000000181A06CD0-0x0000000181A06E90
	private void u091Bu0925u091Eu0920u091Bu091Du091Du0927u0924u0922u0924() {} // 0x0000000181A02FD0-0x0000000181A031B0
	private void u0921u0925u091Eu0929u0928u0921u091Au091Fu0921u091Bu0920() {} // 0x0000000181A046E0-0x0000000181A047C0
	private void u0922u091Fu091Cu0926u0925u0920u091Fu091Au0920u0929u091D() {} // 0x0000000181A04CC0-0x0000000181A04D80
	private void u091Bu0929u0920u091Au091Au0924u091Cu091Eu091Au0926u091D() {} // 0x0000000181A031B0-0x0000000181A03230
	private void u0924u091Du0924u0924u091Cu0922u0928u091Au091Du0926u0921() {} // 0x0000000181A05630-0x0000000181A056A0
	private void u0922u091Fu0929u0927u0920u091Cu091Du091Bu091Bu0927u0928() {} // 0x0000000181A04D80-0x0000000181A04E00
	private void u0920u091Cu0924u091Au091Eu0926u0926u0925u0924u0929u091F() {} // 0x0000000181A04220-0x0000000181A04290
	private void u091Cu0924u091Au091Bu091Cu091Bu0920u0926u0922u0920u091E() {} // 0x0000000181A03330-0x0000000181A03410
	private void u091Bu091Au0924u0928u091Au0925u0924u0926u0921u0920u0926() {} // 0x0000000181A02BE0-0x0000000181A02C50
	private void u0926u091Eu091Du091Cu0929u091Du0927u0929u0925u091Au0923() {} // 0x0000000181A05FF0-0x0000000181A06070
	private void u0923u091Eu0925u0928u0924u0927u091Eu091Eu0926u0922u091C() {} // 0x0000000181A05260-0x0000000181A05340
	private void u091Du091Au0920u0922u0923u0924u0920u0925u091Du091Du0924() {} // 0x0000000181A034F0-0x0000000181A035D0
	private void u0925u0929u0922u0928u0929u0927u0923u0926u0920u0921u0922() {} // 0x0000000181A05C70-0x0000000181A05E30
	private void u0922u091Du0921u0927u091Fu0927u0929u0923u0920u0924u091A() {} // 0x0000000181A04B00-0x0000000181A04CC0
	private void u0928u0922u091Au0921u0926u091Eu0927u0926u091Au091Du0925() {} // 0x0000000181A06BF0-0x0000000181A06CD0
	private void u0927u0928u0927u0929u0927u0926u0921u0929u091Eu091Eu0927() {} // 0x0000000181A06870-0x0000000181A068E0
	private void Update() {} // 0x0000000181A07350-0x0000000181A07530
	private void u0922u0927u0924u0926u0922u0923u091Fu0928u091Du0921u091C() {} // 0x0000000181A04FE0-0x0000000181A050C0
	private void u091Cu0921u0922u091Fu0924u0924u091Bu0924u091Cu0920u091E() {} // 0x0000000181A032B0-0x0000000181A03330
	private void u0925u0926u0926u091Cu091Bu091Eu0921u0923u0927u091Eu091E() {} // 0x0000000181A05AB0-0x0000000181A05B90
	private void u0925u091Fu0923u0925u0926u0924u091Fu0921u0920u0927u091B() {} // 0x0000000181A058F0-0x0000000181A05960
	private IEnumerator u0920u0926u0922u0923u091Cu091Fu0923u0927u091Bu091Bu091A() => default; // 0x0000000181A04300-0x0000000181A04370
	private void u0929u091Au0927u0924u0926u091Bu091Du091Au0925u0923u0928() {} // 0x0000000181A06FD0-0x0000000181A07040
	private void Start() {} // 0x0000000181A02AA0-0x0000000181A02B20
	private void u091Du0924u0929u091Cu091Fu0924u0929u0925u0928u0929u091C() {} // 0x0000000181A037B0-0x0000000181A03890
	private IEnumerator u091Bu0923u0929u091Fu0926u0923u091Bu091Bu091Du0925u0924() => default; // 0x0000000181A02F60-0x0000000181A02FD0
	private void u0927u091Eu0921u0920u0927u0928u0926u091Bu091Du0925u091B() {} // 0x0000000181A06500-0x0000000181A065C0
	private IEnumerator u0926u0921u0923u0922u0928u0925u0924u0926u0921u091Du0925() => default; // 0x0000000181A06250-0x0000000181A062C0
	private IEnumerator u0925u0924u0927u0924u091Cu091Du0925u0920u0928u0925u091C() => default; // 0x0000000181A05A40-0x0000000181A05AB0
	private void u0923u091Au0925u0921u0929u091Fu0925u0920u0926u091Eu0922() {} // 0x0000000181A051A0-0x0000000181A05260
	private void u091Du091Bu0928u091Eu0924u091Bu091Bu0928u0929u091Fu091E() {} // 0x0000000181A035D0-0x0000000181A03650
	private IEnumerator u0921u091Cu0920u091Du091Eu091Au091Du0921u091Eu091Fu091B() => default; // 0x0000000181A04430-0x0000000181A044A0
	private void u091Eu091Bu091Fu0924u091Fu091Cu091Eu0921u091Cu091Cu0928() {} // 0x0000000181A03970-0x0000000181A03A30
	// [IteratorStateMachine] // 0x0000000180149F70-0x0000000180149FC0
	private IEnumerator u091Fu0926u091Cu091Du0924u0925u091Au091Bu091Bu0925u091A() => default; // 0x0000000181A040D0-0x0000000181A04140
	private void u091Cu091Cu0927u0924u0927u091Bu0920u0924u0923u091Du0924() {} // 0x0000000181A03230-0x0000000181A032B0
	private IEnumerator u091Fu091Eu091Du091Bu0927u0922u091Eu0924u091Au091Eu0927() => default; // 0x0000000181A03F80-0x0000000181A03FF0
	private void u091Au091Cu0924u0921u0920u0929u0924u091Eu091Du091Fu0923() {} // 0x0000000181A02B20-0x0000000181A02BE0
	private void u0924u091Cu0924u091Bu0926u0928u0922u0921u091Fu0926u0927() {} // 0x0000000181A05400-0x0000000181A055C0
	private void u0924u0921u091Du091Fu091Fu091Au091Bu0922u091Au0924u0922() {} // 0x0000000181A05810-0x0000000181A05880
	private void u0922u091Au0922u0920u091Bu091Fu0922u091Du0927u0922u0927() {} // 0x0000000181A048B0-0x0000000181A04A90
	private void u091Eu091Bu091Fu091Au091Eu091Fu0923u0929u091Eu0925u0920() {} // 0x0000000181A03900-0x0000000181A03970
	private void u0924u091Eu0925u091Au091Fu0926u0921u0929u0920u0923u091C() {} // 0x0000000181A056A0-0x0000000181A05720
	private void u0922u0927u0928u0920u0925u0923u0925u091Eu0929u091Du091C() {} // 0x0000000181A050C0-0x0000000181A051A0
	private void u091Fu0925u0927u0922u0922u0929u0924u091Bu0924u091Cu0923() {} // 0x0000000181A04060-0x0000000181A040D0
	private void u0928u0927u0923u0928u0928u0920u0926u091Cu0922u0923u091D() {} // 0x0000000181A06E90-0x0000000181A06F50
	private void u0929u091Du091Eu091Cu0926u0925u091Fu091Bu0928u0924u0926() {} // 0x0000000181A07200-0x0000000181A07270
	private void u0927u0920u0929u0924u0926u091Du0922u091Au091Eu0924u0928() {} // 0x0000000181A065C0-0x0000000181A06630
	private void u0927u0927u091Bu091Eu0921u0921u091Bu091Eu0927u0920u0929() {} // 0x0000000181A066B0-0x0000000181A06870
	private void u091Du091Du0921u0927u0929u0926u0924u0926u0922u091Au0927() {} // 0x0000000181A03650-0x0000000181A036C0
	private void u0924u091Fu0920u0929u0920u0922u091Eu091Cu0927u0927u0920() {} // 0x0000000181A05720-0x0000000181A057A0
	private IEnumerator u0925u0928u0923u0920u091Fu0929u0926u091Bu091Au0922u0920() => default; // 0x0000000181A05B90-0x0000000181A05C00
	private void u091Bu091Fu0926u091Fu091Eu091Fu091Cu091Bu0928u091Du0921() {} // 0x0000000181A02E10-0x0000000181A02EF0
	private void u091Eu0928u091Eu0929u091Eu0928u091Du091Fu0926u0926u0927() {} // 0x0000000181A03BE0-0x0000000181A03DC0
	private void u091Fu0928u0920u0926u0923u0926u091Au0927u091Fu0925u0924() {} // 0x0000000181A04140-0x0000000181A04220
	private void u0929u091Au0929u0922u091Bu0927u0921u0921u0922u091Cu0929() {} // 0x0000000181A07040-0x0000000181A07200
	private IEnumerator u091Cu0925u0923u0923u091Eu091Bu0928u091Bu0920u0924u0925() => default; // 0x0000000181A03410-0x0000000181A03480
	private IEnumerator u0925u0929u091Du0927u0923u0924u0920u091Cu0925u0922u0927() => default; // 0x0000000181A05C00-0x0000000181A05C70
	private void u0925u0929u0926u091Au0921u091Fu091Au0926u0928u0925u0928() {} // 0x0000000181A05E30-0x0000000181A05FF0
	private IEnumerator u0921u0927u0929u0923u091Cu091Bu0928u0929u0927u091Bu091D() => default; // 0x0000000181A047C0-0x0000000181A04830
	private void u0922u0920u091Cu091Du091Eu0927u0928u0929u091Cu091Au0924() {} // 0x0000000181A04E00-0x0000000181A04FE0
	private void u0929u0925u091Eu0925u0920u091Eu0926u0929u0926u0923u0928() {} // 0x0000000181A072E0-0x0000000181A07350
	private void u0928u0920u091Fu091Du0925u0927u0926u0924u0928u091Cu091A() {} // 0x0000000181A06A30-0x0000000181A06BF0
	private void u091Bu091Bu0925u0928u0924u0925u0924u0920u091Eu0925u0925() {} // 0x0000000181A02C50-0x0000000181A02E10
	private void u0924u091Cu0929u091Du091Cu091Eu0923u0924u0924u0926u0924() {} // 0x0000000181A055C0-0x0000000181A05630
}
