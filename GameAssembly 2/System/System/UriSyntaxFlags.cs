/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	[Flags] // 0x00000001800D4E50-0x00000001800D4E60
	internal enum UriSyntaxFlags // TypeDefIndex: 2308
	{
		None = 0,
		MustHaveAuthority = 1,
		OptionalAuthority = 2,
		MayHaveUserInfo = 4,
		MayHavePort = 8,
		MayHavePath = 16,
		MayHaveQuery = 32,
		MayHaveFragment = 64,
		AllowEmptyHost = 128,
		AllowUncHost = 256,
		AllowDnsHost = 512,
		AllowIPv4Host = 1024,
		AllowIPv6Host = 2048,
		AllowAnInternetHost = 3584,
		AllowAnyOtherHost = 4096,
		FileLikeUri = 8192,
		MailToLikeUri = 16384,
		V1_UnknownUri = 65536,
		SimpleUserSyntax = 131072,
		BuiltInSyntax = 262144,
		ParserSchemeOnly = 524288,
		AllowDOSPath = 1048576,
		PathIsRooted = 2097152,
		ConvertPathSlashes = 4194304,
		CompressPath = 8388608,
		CanonicalizeAsFilePath = 16777216,
		UnEscapeDotsAndSlashes = 33554432,
		AllowIdn = 67108864,
		AllowIriParsing = 268435456
	}
}
