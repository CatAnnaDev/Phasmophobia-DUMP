/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	[Serializable]
	[TypeConverter] // 0x00000001800F07E0-0x00000001800F0830
	public class Uri : ISerializable // TypeDefIndex: 2286
	{
		// Fields
		public static readonly string UriSchemeFile; // 0x00
		public static readonly string UriSchemeFtp; // 0x08
		public static readonly string UriSchemeGopher; // 0x10
		public static readonly string UriSchemeHttp; // 0x18
		public static readonly string UriSchemeHttps; // 0x20
		internal static readonly string UriSchemeWs; // 0x28
		internal static readonly string UriSchemeWss; // 0x30
		public static readonly string UriSchemeMailto; // 0x38
		public static readonly string UriSchemeNews; // 0x40
		public static readonly string UriSchemeNntp; // 0x48
		public static readonly string UriSchemeNetTcp; // 0x50
		public static readonly string UriSchemeNetPipe; // 0x58
		public static readonly string SchemeDelimiter; // 0x60
		private const int c_Max16BitUtf8SequenceLength = 12; // Metadata: 0x00647FD3
		internal const int c_MaxUriBufferSize = 65520; // Metadata: 0x00647FD7
		private const int c_MaxUriSchemeName = 1024; // Metadata: 0x00647FDB
		private string m_String; // 0x10
		private string m_originalUnicodeString; // 0x18
		private UriParser m_Syntax; // 0x20
		private string m_DnsSafeHost; // 0x28
		private Flags m_Flags; // 0x30
		private UriInfo m_Info; // 0x38
		private bool m_iriParsing; // 0x40
		private static bool s_ConfigInitialized; // 0x68
		private static bool s_ConfigInitializing; // 0x69
		private static UriIdnScope s_IdnScope; // 0x6C
		private static bool s_IriParsing; // 0x70
		private static bool useDotNetRelativeOrAbsolute; // 0x71
		private const UriKind DotNetRelativeOrAbsolute = (UriKind) 300; // Metadata: 0x00647FDF
		internal static readonly bool IsWindowsFileSystem; // 0x72
		private static object s_initLock; // 0x78
		private const UriFormat V1ToStringUnescape = (UriFormat) 32767; // Metadata: 0x00647FE3
		internal const char c_DummyChar = '\xffff'; // Metadata: 0x00647FE7
		internal const char c_EOL = '\xfffe'; // Metadata: 0x00647FE9
		internal static readonly char[] HexLowerChars; // 0x80
		private static readonly char[] _WSchars; // 0x88
	
		// Properties
		private bool IsImplicitFile { get => default; } // 0x00000001809DCC50-0x00000001809DCC60 
		private bool IsUncOrDosPath { get => default; } // 0x00000001809DCD30-0x00000001809DCD40 
		private bool IsDosPath { get => default; } // 0x00000001809DCB80-0x00000001809DCB90 
		private bool IsUncPath { get => default; } // 0x00000001809DCD40-0x00000001809DCD50 
		private Flags HostType { get => default; } // 0x00000001809DC8F0-0x00000001809DC900 
		private UriParser Syntax { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
		private bool IsNotAbsoluteUri { get => default; } // 0x00000001809DCD20-0x00000001809DCD30 
		private bool AllowIdn { get => default; } // 0x00000001809DC180-0x00000001809DC280 
		internal bool UserDrivenParsing { get => default; } // 0x00000001809DD5D0-0x00000001809DD5E0 
		private ushort SecuredPathIndex { get => default; } // 0x00000001809DD3A0-0x00000001809DD400 
		public string AbsolutePath { get => default; } // 0x00000001809DBF80-0x00000001809DC050 
		private string PrivateAbsolutePath { get => default; } // 0x00000001809DD110-0x00000001809DD1F0 
		public string AbsoluteUri { get => default; } // 0x00000001809DC050-0x00000001809DC180 
		public string LocalPath { get => default; } // 0x00000001809DCDE0-0x00000001809DCE60 
		public string Authority { get => default; } // 0x00000001809DC280-0x00000001809DC310 
		public UriHostNameType HostNameType { get => default; } // 0x00000001809DC7B0-0x00000001809DC8F0 
		public bool IsDefaultPort { get => default; } // 0x00000001809DCA90-0x00000001809DCB80 
		public bool IsFile { get => default; } // 0x00000001809DCB90-0x00000001809DCC50 
		public bool IsLoopback { get => default; } // 0x00000001809DCC60-0x00000001809DCD20 
		public string PathAndQuery { get => default; } // 0x00000001809DCF30-0x00000001809DD000 
		public string[] Segments { get => default; } // 0x00000001809DD400-0x00000001809DD5D0 
		public bool IsUnc { get => default; } // 0x00000001809DCD50-0x00000001809DCDE0 
		public string Host { get => default; } // 0x00000001809DC900-0x00000001809DC990 
		private static object InitializeLock { get => default; } // 0x00000001809DC990-0x00000001809DCA90 
		public int Port { get => default; } // 0x00000001809DD000-0x00000001809DD110 
		public string Query { get => default; } // 0x00000001809DD1F0-0x00000001809DD320 
		public string Fragment { get => default; } // 0x00000001809DC670-0x00000001809DC7A0 
		public string Scheme { get => default; } // 0x00000001809DD320-0x00000001809DD3A0 
		private bool OriginalStringSwitched { get => default; } // 0x00000001809DCE60-0x00000001809DCED0 
		public string OriginalString { get => default; } // 0x00000001809DCED0-0x00000001809DCF30 
		public string DnsSafeHost { get => default; } // 0x00000001809DC310-0x00000001809DC670 
		public bool IsAbsoluteUri { get => default; } // 0x000000018045E5E0-0x000000018045E5F0 
		public bool UserEscaped { get => default; } // 0x00000001809DD5E0-0x00000001809DD5F0 
		public string UserInfo { get => default; } // 0x00000001809DD5F0-0x00000001809DD680 
		internal bool HasAuthority { get => default; } // 0x00000001809DC7A0-0x00000001809DC7B0 
	
		// Nested types
		[Flags] // 0x00000001800D4E50-0x00000001800D4E60
		private enum Flags : ulong // TypeDefIndex: 2287
		{
			Zero = 0,
			HostNotParsed = 0,
			SchemeNotCanonical = 1,
			UserNotCanonical = 2,
			HostNotCanonical = 4,
			PortNotCanonical = 8,
			PathNotCanonical = 16,
			QueryNotCanonical = 32,
			FragmentNotCanonical = 64,
			CannotDisplayCanonical = 127,
			E_UserNotCanonical = 128,
			E_HostNotCanonical = 256,
			E_PortNotCanonical = 512,
			E_PathNotCanonical = 1024,
			E_QueryNotCanonical = 2048,
			E_FragmentNotCanonical = 4096,
			E_CannotDisplayCanonical = 8064,
			ShouldBeCompressed = 8192,
			FirstSlashAbsent = 16384,
			BackslashInPath = 32768,
			IndexMask = 65535,
			IPv6HostType = 65536,
			IPv4HostType = 131072,
			DnsHostType = 196608,
			UncHostType = 262144,
			BasicHostType = 327680,
			UnusedHostType = 393216,
			HostTypeMask = 458752,
			UnknownHostType = 458752,
			UserEscaped = 524288,
			AuthorityFound = 1048576,
			HasUserInfo = 2097152,
			LoopbackHost = 4194304,
			NotDefaultPort = 8388608,
			UserDrivenParsing = 16777216,
			CanonicalDnsHost = 33554432,
			ErrorOrParsingRecursion = 67108864,
			DosPath = 134217728,
			UncPath = 268435456,
			ImplicitFile = 536870912,
			MinimalUriInfoSet = 1073741824,
			AllUriInfoSet = 2147483648,
			IdnHost = 4294967296,
			HasUnicode = 8589934592,
			HostUnicodeNormalized = 17179869184,
			RestUnicodeNormalized = 34359738368,
			UnicodeHost = 68719476736,
			IntranetUri = 137438953472,
			UseOrigUncdStrOffset = 274877906944,
			UserIriCanonical = 549755813888,
			PathIriCanonical = 1099511627776,
			QueryIriCanonical = 2199023255552,
			FragmentIriCanonical = 4398046511104,
			IriCanonical = 8246337208320,
			CompressedSlashes = 17592186044416
		}
	
		private class UriInfo // TypeDefIndex: 2288
		{
			// Fields
			public string Host; // 0x10
			public string ScopeId; // 0x18
			public string String; // 0x20
			public Offset Offset; // 0x28
			public string DnsSafeHost; // 0x38
			public MoreInfo MoreInfo; // 0x40
	
			// Constructors
			public UriInfo() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		private struct Offset // TypeDefIndex: 2289
		{
			// Fields
			public ushort Scheme; // 0x00
			public ushort User; // 0x02
			public ushort Host; // 0x04
			public ushort PortValue; // 0x06
			public ushort Path; // 0x08
			public ushort Query; // 0x0A
			public ushort Fragment; // 0x0C
			public ushort End; // 0x0E
		}
	
		private class MoreInfo // TypeDefIndex: 2290
		{
			// Fields
			public string Path; // 0x10
			public string Query; // 0x18
			public string Fragment; // 0x20
			public string AbsoluteUri; // 0x28
			public int Hash; // 0x30
			public string RemoteUrl; // 0x38
	
			// Constructors
			public MoreInfo() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		[Flags] // 0x00000001800D4E50-0x00000001800D4E60
		private enum Check // TypeDefIndex: 2291
		{
			None = 0,
			EscapedCanonical = 1,
			DisplayCanonical = 2,
			DotSlashAttn = 4,
			FoundNonAscii = 8,
			BackslashInPath = 16,
			ReservedFound = 32,
			NotIriCanonical = 64,
			DotSlashEscaped = 128
		}
	
		// Constructors
		public Uri() {} // Dummy constructor
		public Uri(string uriString) {} // 0x00000001809DBEE0-0x00000001809DBF80
		public Uri(string uriString, UriKind uriKind) {} // 0x00000001809DBE40-0x00000001809DBEE0
		public Uri(Uri baseUri, string relativeUri) {} // 0x00000001809DBAC0-0x00000001809DBBA0
		public Uri(Uri baseUri, Uri relativeUri) {} // 0x00000001809DBBA0-0x00000001809DBDE0
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001809DB9E0-0x00000001809DBAC0
		private Uri(Flags flags, UriParser uriParser, string uri) {} // 0x00000001809DBDE0-0x00000001809DBE40
		static Uri() {} // 0x00000001809DB560-0x00000001809DB9E0
	
		// Methods
		internal static bool IriParsingStatic(UriParser syntax) => default; // 0x00000001809D6CB0-0x00000001809D6D50
		private bool AllowIdnStatic(UriParser syntax, Flags flags) => default; // 0x00000001809CD310-0x00000001809CD420
		private bool IsIntranet(string schemeHost) => default; // 0x0000000180250A70-0x0000000180250A80
		private void SetUserDrivenParsing() {} // 0x00000001809DAAC0-0x00000001809DAAE0
		private bool NotAny(Flags flags) => default; // 0x00000001809D6FF0-0x00000001809D7000
		private bool InFact(Flags flags) => default; // 0x00000001809D5AF0-0x00000001809D5B00
		private static bool StaticNotAny(Flags allFlags, Flags checkFlags) => default; // 0x00000001809DAB10-0x00000001809DAB20
		private static bool StaticInFact(Flags allFlags, Flags checkFlags) => default; // 0x00000001809DAAE0-0x00000001809DAAF0
		private UriInfo EnsureUriInfo() => default; // 0x00000001809D23B0-0x00000001809D23E0
		private void EnsureParseRemaining() {} // 0x00000001809D2390-0x00000001809D23B0
		private void EnsureHostString(bool allowDnsOptimization) {} // 0x00000001809D2330-0x00000001809D2390
		private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) {} // 0x00000001809D2160-0x00000001809D2330
		private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) => default; // 0x00000001809D3620-0x00000001809D3850
		private static UriFormatException GetException(ParsingError err) => default; // 0x00000001809D3E50-0x00000001809D3F70
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001809D4EE0-0x00000001809D4FB0
		protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001809D4EE0-0x00000001809D4FB0
		private static bool StaticIsFile(UriParser syntax) => default; // 0x00000001809DAAF0-0x00000001809DAB10
		private static void InitializeUriConfig() {} // 0x00000001809D5B00-0x00000001809D5DC0
		private string GetLocalPath() => default; // 0x00000001809D45E0-0x00000001809D4EE0
		internal static bool IsGenDelim(char ch) => default; // 0x00000001809D6E30-0x00000001809D6E60
		public static bool CheckSchemeName(string schemeName) => default; // 0x00000001809CFB50-0x00000001809CFC90
		public static bool IsHexDigit(char character) => default; // 0x00000001809D6E60-0x00000001809D6E90
		public static int FromHex(char digit) => default; // 0x00000001809D2D80-0x00000001809D2E20
		public override int GetHashCode() => default; // 0x00000001809D3F70-0x00000001809D4120
		public override string ToString() => default; // 0x00000001809DAC90-0x00000001809DADA0
		public static bool operator ==(Uri uri1, Uri uri2) => default; // 0x00000001809DD680-0x00000001809DD6B0
		public static bool operator !=(Uri uri1, Uri uri2) => default; // 0x00000001809DD6B0-0x00000001809DD700
		public override bool Equals(object comparand) => default; // 0x00000001809D23E0-0x00000001809D2AF0
		private static bool CheckForColonInFirstPathSegment(string uriString) => default; // 0x00000001809CF0A0-0x00000001809CF140
		internal static string InternalEscapeString(string rawString) => default; // 0x00000001809D6670-0x00000001809D6760
		private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) => default; // 0x00000001809D84C0-0x00000001809D85C0
		internal UriFormatException ParseMinimal() => default; // 0x00000001809D7000-0x00000001809D7080
		private ParsingError PrivateParseMinimal() => default; // 0x00000001809D86E0-0x00000001809D8EE0
		private void PrivateParseMinimalIri(string newHost, ushort idx) {} // 0x00000001809D85C0-0x00000001809D86E0
		private void CreateUriInfo(Flags cF) {} // 0x00000001809D1AF0-0x00000001809D2160
		private void CreateHostString() {} // 0x00000001809D1290-0x00000001809D1790
		private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) => default; // 0x00000001809D10B0-0x00000001809D1290
		private void GetHostViaCustomSyntax() {} // 0x00000001809D4120-0x00000001809D45E0
		internal string GetParts(UriComponents uriParts, UriFormat formatAs) => default; // 0x00000001809D3B80-0x00000001809D3D30
		private string GetEscapedParts(UriComponents uriParts) => default; // 0x00000001809D3D30-0x00000001809D3E50
		private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) => default; // 0x00000001809D5240-0x00000001809D5340
		private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) => default; // 0x00000001809D8EE0-0x00000001809DA5A0
		private string GetUriPartsFromUserString(UriComponents uriParts) => default; // 0x00000001809D5340-0x00000001809D5AF0
		private void ParseRemaining() {} // 0x00000001809D7080-0x00000001809D7FC0
		private static unsafe ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) => default; // 0x00000001809D7FC0-0x00000001809D84C0
		private static unsafe bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) => default; // 0x00000001809CF5A0-0x00000001809CFB50
		private static unsafe ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) => default; // 0x00000001809CFC90-0x00000001809CFDC0
		private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) => default; // 0x00000001809CDD60-0x00000001809CECF0
		private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) {} // 0x00000001809CD7E0-0x00000001809CDD60
		private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) {} // 0x00000001809CD4E0-0x00000001809CD7E0
		private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) {} // 0x00000001809D2CF0-0x00000001809D2D80
		private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) {} // 0x00000001809D2C80-0x00000001809D2CF0
		private unsafe Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) => default; // 0x00000001809CECF0-0x00000001809CF0A0
		private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) => default; // 0x00000001809D2E20-0x00000001809D3620
		private static unsafe void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) {} // 0x00000001809DB340-0x00000001809DB560
		private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) => default; // 0x00000001809D0930-0x00000001809D0DE0
		internal static int CalculateCaseInsensitiveHashCode(string text) => default; // 0x00000001809CD420-0x00000001809CD4E0
		private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) => default; // 0x00000001809CFDC0-0x00000001809D0930
		private static bool IsLWS(char ch) => default; // 0x00000001809D6E90-0x00000001809D6EC0
		private static bool IsAsciiLetter(char character) => default; // 0x00000001809D6DD0-0x00000001809D6DF0
		internal static bool IsAsciiLetterOrDigit(char character) => default; // 0x00000001809D6D50-0x00000001809D6DD0
		internal static bool IsBidiControlCharacter(char ch) => default; // 0x00000001809D6DF0-0x00000001809D6E30
		internal static unsafe string StripBidiControlCharacter(char* strToClean, int start, int length) => default; // 0x00000001809DAB20-0x00000001809DAC90
		private void CreateThis(string uri, bool dontEscape, UriKind uriKind) {} // 0x00000001809D1940-0x00000001809D1AF0
		private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) {
			e = default;
		} // 0x00000001809D5DC0-0x00000001809D6670
		private bool CheckForConfigLoad(string data) => default; // 0x00000001809CF140-0x00000001809CF1F0
		private bool CheckForUnicode(string data) => default; // 0x00000001809CF400-0x00000001809CF5A0
		private bool CheckForEscapedUnreserved(string data) => default; // 0x00000001809CF1F0-0x00000001809CF400
		public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) {
			result = default;
			return default;
		} // 0x00000001809DB070-0x00000001809DB160
		public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) {
			result = default;
			return default;
		} // 0x00000001809DADA0-0x00000001809DAEB0
		public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) {
			result = default;
			return default;
		} // 0x00000001809DAEB0-0x00000001809DB070
		public string GetComponents(UriComponents components, UriFormat format) => default; // 0x00000001809D3B80-0x00000001809D3D30
		public bool IsWellFormedOriginalString() => default; // 0x00000001809D6EC0-0x00000001809D6F00
		public static bool IsWellFormedUriString(string uriString, UriKind uriKind) => default; // 0x00000001809D6F00-0x00000001809D6FF0
		internal bool InternalIsWellFormedOriginalString() => default; // 0x00000001809D6760-0x00000001809D6CB0
		public static string UnescapeDataString(string stringToUnescape) => default; // 0x00000001809DB160-0x00000001809DB340
		public static string EscapeDataString(string stringToEscape) => default; // 0x00000001809D2AF0-0x00000001809D2C20
		internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) => default; // 0x00000001809D2C20-0x00000001809D2C80
		internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) => default; // 0x00000001809D0DE0-0x00000001809D10B0
		internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) {
			e = default;
			return default;
		} // 0x00000001809DA5A0-0x00000001809DAAC0
		private string GetRelativeSerializationString(UriFormat format) => default; // 0x00000001809D4FB0-0x00000001809D5240
		internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) => default; // 0x00000001809D3850-0x00000001809D3B80
		private void CreateThisFromUri(Uri otherUri) {} // 0x00000001809D1790-0x00000001809D1940
	}
}
