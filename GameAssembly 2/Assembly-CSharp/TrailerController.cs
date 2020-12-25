/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRTK;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class TrailerController : MonoBehaviour // TypeDefIndex: 6993
{
	// Fields
	public bool u091Bu091Bu091Du091Cu0925u0921u091Du0924u0928u0924u091F; // 0x18
	private int u091Fu091Du091Eu0920u0929u091Fu091Fu091Fu0922u0927u0921; // 0x1C
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Camera cam; // 0x20
	public TrailerCamera u0926u0926u0921u0926u0924u091Fu0927u0922u091Bu091Eu0922; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Nightvision cameraNightVision; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerArrivedSound; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource radioBeCarefulSound; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerNothingSound; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerDirtyWaterSound; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource radioSpiritOrWraithSound; // 0x58
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerGhostInTheBasementSound; // 0x60
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource radioDontGetAReadingSound; // 0x68
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public EVPRecorder u0924u0929u0921u0924u091Du0927u091Au0926u0928u0923u0920; // 0x70
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerConfirmEVPEvidenceSound; // 0x78
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource radioConfirmSpririt; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerEVPSound1; // 0x88
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerEVPSound2; // 0x90
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource playerLowVitalsSound; // 0x98
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LightSwitch tvRemote; // 0xA0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private EMF tvEMFSpot; // 0xA8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Door basementDoor; // 0xB0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource basementDoorOpeningSound; // 0xB8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private EMF basementEMFSpot; // 0xC0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LevelRoom basement; // 0xC8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject basementGhost; // 0xD0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LightSwitch basementLight; // 0xD8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Door mainDoor; // 0xE0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Animator mainDoorAnim; // 0xE8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject hallwayGhost; // 0xF0
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922; // 0xF8
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public VRTK_SlideObjectControlAction u091Cu091Du0926u0920u091Fu0921u091Eu0927u0929u0922u091B; // 0x100
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public VRTK_SlideObjectControlAction u0921u0926u0927u091Bu091Bu0929u0927u0928u0923u0929u0929; // 0x108
	private bool u091Eu0925u091Fu0927u091Eu0924u0925u091Du0924u091Du0921; // 0x110

	// Constructors
	public TrailerController() {} // 0x0000000181836880-0x0000000181836890
}

