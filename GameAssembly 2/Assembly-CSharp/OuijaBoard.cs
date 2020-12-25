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

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class OuijaBoard : MonoBehaviour // TypeDefIndex: 7080
{
	// Fields
	private List<u0927u091Eu091Fu0928u0924u0927u0922u0921u091Du091Fu091D> u0925u0921u091Cu091Du0929u0928u0922u0926u0921u0929u0928; // 0x18
	private List<u091Fu0926u0925u0925u091Eu0924u0924u0922u0926u0921u091D> u0929u0929u0924u0926u0927u0929u0921u091Au0926u0920u0925; // 0x20
	private bool u0921u091Bu0920u091Eu0924u091Bu091Au0929u091Bu0923u0928; // 0x28
	public Transform u091Du0921u091Bu0924u0921u0927u091Eu091Cu0922u0924u091C; // 0x30
	public List<Transform> u0923u0920u0923u0924u0922u091Du0923u0922u0928u091Fu0927; // 0x38
	private List<string> u091Au091Eu0924u0920u0923u0923u0924u0923u091Bu091Cu0929; // 0x40
	private Vector3 u091Eu0920u0924u0928u0928u091Du0926u091Cu0920u0923u0929; // 0x48
	private Vector3 u0926u091Eu091Cu0925u0928u0925u091Bu091Eu0921u091Cu0925; // 0x54
	private bool u091Eu091Fu091Bu0928u091Bu091Cu0928u0925u0925u091Bu091E; // 0x60
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource source; // 0x68
	public PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x70
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PhotonObjectInteract photonInteract; // 0x78
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Noise noise; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Renderer rend; // 0x88

	// Constructors
	public OuijaBoard() {} // 0x000000018101E890-0x000000018101E980

	// Methods
	private void u091Du091Fu091Fu0921u0921u091Bu091Bu091Cu091Eu0920u0920() {} // 0x0000000181014980-0x00000001810149F0
	private void u091Bu091Du091Fu0923u091Eu0921u0928u0925u0921u0928u0926() {} // 0x00000001810130E0-0x00000001810131E0
	private void u091Au0922u0920u0921u0926u091Fu0921u0921u091Au091Au0927() {} // 0x00000001810128E0-0x0000000181012960
	private void u0925u091Fu0926u0921u091Eu0921u0929u091Du091Bu091Bu0923() {} // 0x000000018101A3A0-0x000000018101A410
	private void u091Du091Bu091Eu091Au0922u0921u0928u091Bu091Bu0921u091F() {} // 0x0000000181014080-0x00000001810140C0
	private Vector3 u0923u091Eu091Du091Bu091Au0920u0920u091Au091Bu091Cu0924(string u091Fu091Du0929u0926u0928u0929u0927u0926u0929u091Au091E) => default; // 0x00000001810185C0-0x0000000181019440
	private void u0923u0920u091Eu091Eu091Cu091Fu091Au091Fu091Cu091Eu0925() {} // 0x0000000181019480-0x0000000181019570
	// [IteratorStateMachine] // 0x0000000180146930-0x0000000180146980
	private IEnumerator u091Fu0924u0926u0926u091Cu0926u091Au091Eu0924u091Au091D() => default; // 0x00000001810165B0-0x0000000181016620
	private void u091Cu0925u0924u091Du0923u091Eu091Eu0923u091Cu091Cu091F() {} // 0x0000000181011160-0x00000001810111E0
	private LevelRoom u0929u0923u0924u091Fu091Cu0922u091Au091Eu0923u0921u0925() => default; // 0x000000018101E150-0x000000018101E3C0
	private void u091Fu0925u0920u091Au0923u091Cu091Du0925u0924u0927u0921() {} // 0x0000000181016620-0x0000000181016660
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void DisableOuijaBoard() {} // 0x0000000180FB3EE0-0x0000000180FB3F10
	private void u0926u091Du0925u091Du091Bu091Bu091Eu091Cu091Bu0925u0927() {} // 0x000000018101BC10-0x000000018101BD10
	private void u091Du0928u0927u0925u0923u0920u0925u0926u0921u091Au091A() {} // 0x0000000181015730-0x00000001810157A0
	public void u0929u0920u0927u0924u0926u0924u0921u0929u0924u0922u0928() {} // 0x000000018101D500-0x000000018101DD90
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void MaybeAnswer() {} // 0x00000001810112D0-0x0000000181011310
	private void u091Eu091Bu091Fu0924u091Fu091Cu091Eu0921u091Cu091Cu0928() {} // 0x0000000181015810-0x0000000181015890
	public void u0926u091Bu091Eu091Cu091Au0923u0920u091Eu0927u0924u0926(string u0920u0927u091Fu0928u0927u091Fu091Fu091Bu0929u0921u091F) {} // 0x000000018101A480-0x000000018101A7B0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void YesAnswer() {} // 0x000000018101E850-0x000000018101E890
	public void u0928u0924u091Du0925u0920u0923u0922u091Bu091Fu091Du0921(string u0920u0927u091Fu0928u0927u091Fu091Fu091Bu0929u0921u091F) {} // 0x000000018101D120-0x000000018101D420
	private void Start() {} // 0x00000001810127E0-0x00000001810128E0
	private LevelRoom u091Fu0922u0922u0921u0927u0925u091Eu091Cu091Cu091Fu0920() => default; // 0x0000000181016340-0x00000001810165B0
	public void SetupKeywords() {} // 0x0000000181011EA0-0x0000000181012750
	public void u091Fu0925u0921u0920u091Au0925u0929u0923u0925u091Bu091F(string u0920u0927u091Fu0928u0927u091Fu091Fu091Bu0929u0921u091F) {} // 0x0000000181016660-0x0000000181016960
	private void u0927u091Fu0925u091Fu0923u0920u0921u0928u091Bu091Cu0929() {} // 0x0000000181015810-0x0000000181015890
	private void u091Cu091Au091Cu0929u0923u0920u091Au091Bu091Cu091Au0926() {} // 0x0000000181013B50-0x0000000181013BD0
	private Vector3 u0927u091Eu0924u091Du0920u091Au0928u0923u0922u091Cu091D(string u091Fu091Du0929u0926u0928u0929u0927u0926u0929u091Au091E) => default; // 0x000000018101BD10-0x000000018101C2E0
	private void u091Eu0926u091Fu091Au0922u0922u0924u091Du0926u091Fu091B() {} // 0x0000000181015900-0x0000000181015940
	public void u0920u0920u091Fu091Fu0921u091Eu091Bu0927u0922u0927u0929() {} // 0x0000000181016960-0x0000000181017200
	public void u0926u091Cu0929u0927u091Fu0922u0925u091Au091Eu091Cu0925(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x000000018101A7B0-0x000000018101B1E0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void LocationAnswer() {} // 0x0000000181011250-0x00000001810112D0
	public void u0921u0922u0927u0923u091Cu091Cu091Fu0922u091Au091Fu0920(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x0000000181017670-0x00000001810180C0
	private void u0923u0928u0929u0923u0925u0922u091Du091Du0927u0927u0926() {} // 0x00000001810195E0-0x00000001810196E0
	private void u0925u091Fu091Eu0920u0923u0926u0929u0925u0921u091Fu0929() {} // 0x000000018101A320-0x000000018101A3A0
	public void OnPhraseRecognized(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x0000000181011350-0x0000000181011D00
	private void u0920u0921u0920u0929u0923u091Eu0921u091Du091Eu091Bu0920() {} // 0x0000000181017200-0x0000000181017240
	private void Update() {} // 0x000000018101E460-0x000000018101E850
	private void u091Eu0928u0922u0928u0925u0921u0926u0928u091Du0923u0928() {} // 0x0000000181015940-0x0000000181015980
	private void u0925u0929u091Fu091Au0921u0925u0924u091Au0928u0923u0924() {} // 0x000000018101A410-0x000000018101A480
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NoAnswer() {} // 0x0000000181011310-0x0000000181011350
	private void u091Bu091Bu0923u091Bu091Fu0924u0924u0929u0927u0929u091A() {} // 0x0000000181012FE0-0x00000001810130E0
	private void u091Bu091Eu091Du091Eu0920u091Au091Au091Au0924u0926u091D() {} // 0x00000001810131E0-0x0000000181013250
	private void u091Eu0921u091Du091Eu0921u091Eu0922u0924u0920u091Du0929() {} // 0x0000000181011160-0x00000001810111E0
	private void u091Bu0923u091Au091Fu0928u0926u0920u091Au091Bu091Du0925() {} // 0x0000000181013250-0x00000001810132C0
	private void u0922u0928u0924u0927u0925u091Fu0920u0929u091Bu091Fu0920() {} // 0x0000000181015810-0x0000000181015890
	private void u0929u0921u0920u091Bu0924u091Bu0929u091Au0928u0923u091F() {} // 0x000000018101DD90-0x000000018101E150
	private void u091Eu091Bu091Fu091Au091Eu091Fu0923u0929u091Eu0925u0920() {} // 0x00000001810157A0-0x0000000181015810
	private void u091Du0924u0929u091Du0923u0927u091Au0929u091Du0921u091B() {} // 0x0000000181014C80-0x0000000181014CC0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void RoomAnswer() {} // 0x0000000181011DA0-0x0000000181011EA0
	public void u091Bu0928u091Bu0921u0921u091Au0926u091Bu0927u091Fu0925() {} // 0x00000001810132C0-0x0000000181013B50
	private IEnumerator u0921u091Fu091Au091Bu091Au091Eu0929u091Bu0928u0927u091C() => default; // 0x0000000181017600-0x0000000181017670
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void AgeAnswer() {} // 0x0000000181010DC0-0x0000000181010E30
	private LevelRoom u091Du0924u0922u0921u0923u0926u0923u091Du0928u0926u091E() => default; // 0x00000001810149F0-0x0000000181014C80
	public void u0926u091Du0921u0926u0929u0926u091Cu0923u0921u0920u0920(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x000000018101B1E0-0x000000018101BC10
	private void u0922u0928u0929u0920u091Bu0922u0923u0922u091Bu091Fu091B() {} // 0x0000000180FB3EE0-0x0000000180FB3F10
	private void u091Fu091Bu0929u091Fu0920u0923u091Au091Bu091Au091Bu0925() {} // 0x0000000181016250-0x0000000181016290
	private void u091Au0928u091Cu091Bu0920u0928u0921u0921u0929u091Eu091B() {} // 0x0000000181012BF0-0x0000000181012FE0
	private void u0929u0925u091Eu0928u0926u0923u0928u091Fu0922u091Eu091E() {} // 0x000000018101E3C0-0x000000018101E460
	private IEnumerator u0929u0920u091Eu091Cu091Fu0925u0926u091Au091Eu091Au0929() => default; // 0x000000018101D490-0x000000018101D500
	private void u0923u091Fu0925u091Du0924u0922u091Du0925u0929u0922u0922() {} // 0x0000000181019440-0x0000000181019480
	private void u0920u091Cu0926u091Au0929u0924u0922u0920u0920u091Cu091D() {} // 0x0000000181011160-0x00000001810111E0
	private void u0920u0924u0920u0926u0926u0920u0923u091Fu0929u091Du091F() {} // 0x0000000181017240-0x0000000181017600
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void Sound(bool u091Du091Bu091Au091Eu091Du0921u0920u091Au0925u091Bu0925) {} // 0x0000000181012750-0x00000001810127E0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void DeadAnswer() {} // 0x00000001810111E0-0x0000000181011250
	private LevelRoom u0923u091Cu091Au0927u091Au0920u0923u0923u0923u0927u091F() => default; // 0x0000000181018330-0x00000001810185C0
	private LevelRoom u0922u0926u0924u091Du0928u091Eu0926u091Fu0922u0928u0921() => default; // 0x00000001810180C0-0x0000000181018330
	private void u091Du091Au0923u0923u0925u091Au0922u0922u0921u091Eu091F() {} // 0x0000000181013F80-0x0000000181014080
	private void Awake() {} // 0x0000000181011160-0x00000001810111E0
	private IEnumerator u0929u091Du0923u0920u0928u091Au091Eu0927u091Fu0927u0929() => default; // 0x000000018101D420-0x000000018101D490
	private void u091Fu091Du0922u0926u0922u0921u0925u0920u0927u091Du0927() {} // 0x0000000181016290-0x00000001810162D0
	public void u091Du091Bu0924u0922u091Eu0921u091Du0927u0926u091Fu0925() {} // 0x00000001810140C0-0x0000000181014980
	private void u0924u091Cu091Fu0927u091Du0922u091Du091Fu091Au0924u0920() {} // 0x0000000181019760-0x0000000181019860
	private void u091Eu0920u0921u0928u0927u0925u0921u0928u091Eu0928u091A() {} // 0x0000000181015890-0x0000000181015900
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void OuijaBoardNetworkedUse() {} // 0x0000000181011D00-0x0000000181011DA0
	public void u091Cu091Eu0925u0922u0925u0926u091Au0925u0923u0929u091A(string u0920u0927u091Fu0928u0927u091Fu091Fu091Bu0929u0921u091F) {} // 0x0000000181013C60-0x0000000181013F80
	public void u091Du0928u0927u0921u0921u0925u0924u0921u091Du0927u091D(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x0000000181014CC0-0x0000000181015730
	private void u0923u0921u091Bu091Eu0922u0927u0924u091Au091Cu091Eu0924() {} // 0x0000000181019570-0x00000001810195E0
	public void u0924u0920u0924u0922u0927u091Eu0928u091Cu091Fu0924u0924(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x0000000181019860-0x000000018101A2A0
	private void u0925u091Au0920u091Cu091Cu0921u0924u0924u0921u0924u0924() {} // 0x000000018101A2E0-0x000000018101A320
	private void u091Bu091Fu0928u0920u091Bu091Au091Fu0923u0923u0928u0922() {} // 0x0000000181011160-0x00000001810111E0
	public void u091Fu091Au0920u0926u0925u0926u0925u091Cu0922u0924u091C() {} // 0x0000000181015980-0x0000000181016250
	private void u0924u091Fu0920u091Eu0921u0920u0924u091Fu091Du091Eu091D() {} // 0x0000000181011160-0x00000001810111E0
	private LevelRoom u091Au0923u091Eu091Au0928u0924u091Eu091Bu0922u0921u0929() => default; // 0x0000000181012960-0x0000000181012BF0
	public void Answer(string u0920u0927u091Fu0928u0927u091Fu091Fu091Bu0929u0921u091F) {} // 0x0000000181010E30-0x0000000181011160
	private void u0924u0928u091Au0929u0929u091Fu091Bu0924u0924u0920u091E() {} // 0x000000018101A2A0-0x000000018101A2E0
	private void u0924u091Bu091Eu0928u091Bu0927u0928u091Au0920u091Eu091F() {} // 0x00000001810196E0-0x0000000181019760
	private void u0928u091Eu091Fu0924u0926u0921u091Eu0920u0928u0921u091D() {} // 0x000000018101CD20-0x000000018101D120
	private IEnumerator u091Fu091Eu091Cu0928u091Bu0920u091Fu091Eu0921u0924u0923() => default; // 0x00000001810162D0-0x0000000181016340
	private void u091Cu091Du091Du0922u091Fu0921u0927u091Fu0920u0926u0922() {} // 0x0000000181013BD0-0x0000000181013C60
	public void u0927u0928u0928u0925u0925u091Fu091Bu0927u0927u091Du091D(string u0929u0925u091Bu0920u0927u0927u0924u091Au0924u0928u091E) {} // 0x000000018101C2E0-0x000000018101CD20
	private void u0929u0925u091Du0925u091Bu091Bu0927u0920u0921u091Eu0921() {} // 0x0000000181011160-0x00000001810111E0
}
