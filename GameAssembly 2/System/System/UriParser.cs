/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	public abstract class UriParser // TypeDefIndex: 2301
	{
		// Fields
		private const UriSyntaxFlags SchemeOnlyFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHavePath; // Metadata: 0x00648297
		private static readonly Dictionary<string, UriParser> m_Table; // 0x00
		private static Dictionary<string, UriParser> m_TempTable; // 0x08
		private UriSyntaxFlags m_Flags; // 0x10
		private UriSyntaxFlags m_UpdatableFlags; // 0x14
		private bool m_UpdatableFlagsUsed; // 0x18
		private const UriSyntaxFlags c_UpdatableFlags = UriSyntaxFlags.None | UriSyntaxFlags.UnEscapeDotsAndSlashes; // Metadata: 0x0064829B
		private int m_Port; // 0x1C
		private string m_Scheme; // 0x20
		internal const int NoDefaultPort = -1; // Metadata: 0x0064829F
		private const int c_InitialTableSize = 25; // Metadata: 0x006482A3
		internal static UriParser HttpUri; // 0x10
		internal static UriParser HttpsUri; // 0x18
		internal static UriParser WsUri; // 0x20
		internal static UriParser WssUri; // 0x28
		internal static UriParser FtpUri; // 0x30
		internal static UriParser FileUri; // 0x38
		internal static UriParser GopherUri; // 0x40
		internal static UriParser NntpUri; // 0x48
		internal static UriParser NewsUri; // 0x50
		internal static UriParser MailToUri; // 0x58
		internal static UriParser UuidUri; // 0x60
		internal static UriParser TelnetUri; // 0x68
		internal static UriParser LdapUri; // 0x70
		internal static UriParser NetTcpUri; // 0x78
		internal static UriParser NetPipeUri; // 0x80
		internal static UriParser VsMacrosUri; // 0x88
		private static readonly UriQuirksVersion s_QuirksVersion; // 0x90
		private const int c_MaxCapacity = 512; // Metadata: 0x006482A7
		private const UriSyntaxFlags UnknownV1SyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482AB
		private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
		private const UriSyntaxFlags FtpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482AF
		private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
		private const UriSyntaxFlags VsmacrosSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482B3
		private const UriSyntaxFlags GopherSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482B7
		private const UriSyntaxFlags NewsSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482BB
		private const UriSyntaxFlags NntpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482BF
		private const UriSyntaxFlags TelnetSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482C3
		private const UriSyntaxFlags LdapSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482C7
		private const UriSyntaxFlags MailtoSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482CB
		private const UriSyntaxFlags NetPipeSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482CF
		private const UriSyntaxFlags NetTcpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x006482D3
	
		// Properties
		internal string SchemeName { get; } // 0x0000000180246FE0-0x0000000180246FF0 
		internal int DefaultPort { get; } // 0x000000018027A6E0-0x000000018027A6F0 
		internal static bool ShouldUseLegacyV2Quirks { get; } // 0x00000001809CD2B0-0x00000001809CD310 
		internal UriSyntaxFlags Flags { get; } // 0x0000000180245EA0-0x0000000180246600 
		internal bool IsSimple { get; } // 0x00000001809CD2A0-0x00000001809CD2B0 
	
		// Nested types
		private enum UriQuirksVersion // TypeDefIndex: 2302
		{
			V2 = 2,
			V3 = 3
		}
	
		private class BuiltInUriParser : UriParser // TypeDefIndex: 2303
		{
			// Constructors
			public BuiltInUriParser() {} // Dummy constructor
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) {} // 0x0000000180AF5E90-0x0000000180AF5F30
		}
	
		// Constructors
		protected UriParser() {} // Dummy constructor
		static UriParser() {} // 0x00000001809CC780-0x00000001809CD240
		internal UriParser(UriSyntaxFlags flags) {} // 0x00000001809CD240-0x00000001809CD2A0
	
		// Methods
		protected virtual UriParser OnNewUri() => default; // 0x00000001802A78B0-0x00000001802A78C0
		protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) {
			parsingError = default;
		} // 0x00000001809CC300-0x00000001809CC3A0
		protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) {
			parsingError = default;
			return default;
		} // 0x00000001809CC590-0x00000001809CC780
		protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) => default; // 0x00000001809CBFA0-0x00000001809CC1C0
		protected virtual bool IsWellFormedOriginalString(Uri uri) => default; // 0x00000001809CC510-0x00000001809CC530
		internal bool NotAny(UriSyntaxFlags flags) => default; // 0x00000001809CC530-0x00000001809CC590
		internal bool InFact(UriSyntaxFlags flags) => default; // 0x00000001809CC2A0-0x00000001809CC300
		internal bool IsAllSet(UriSyntaxFlags flags) => default; // 0x00000001809CC440-0x00000001809CC4A0
		private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) => default; // 0x00000001809CC4A0-0x00000001809CC510
		internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) => default; // 0x00000001809CBC90-0x00000001809CBFA0
		internal static UriParser GetSyntax(string lwrCaseScheme) => default; // 0x00000001809CC1C0-0x00000001809CC2A0
		internal UriParser InternalOnNewUri() => default; // 0x00000001809CC3C0-0x00000001809CC420
		internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) {
			parsingError = default;
		} // 0x00000001809CC420-0x00000001809CC440
		internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) {
			parsingError = default;
			return default;
		} // 0x000000018086F220-0x000000018086F240
		internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) => default; // 0x00000001809CC3A0-0x00000001809CC3C0
		internal bool InternalIsWellFormedOriginalString(Uri thisUri) => default; // 0x00000001803EC730-0x00000001803EC750
	}
}
