/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class IAPurchase // TypeDefIndex: 7398
	{
		// Constructors
		public IAPurchase() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public static extern void IsReady(IAPurchaseCallback callback, string pchAppKey); // 0x0000000181B4F7B0-0x0000000181B4F850
		public static extern void IsReady_64(IAPurchaseCallback callback, string pchAppKey); // 0x0000000181B4F4A0-0x0000000181B4F540
		public static extern void Request(IAPurchaseCallback callback, string pchPrice); // 0x0000000181B51860-0x0000000181B51900
		public static extern void Request_64(IAPurchaseCallback callback, string pchPrice); // 0x0000000181B517C0-0x0000000181B51860
		public static extern void Request(IAPurchaseCallback callback, string pchPrice, string pchUserData); // 0x0000000181B51DA0-0x0000000181B51E60
		public static extern void Request_64(IAPurchaseCallback callback, string pchPrice, string pchUserData); // 0x0000000181B51700-0x0000000181B517C0
		public static extern void Purchase(IAPurchaseCallback callback, string pchPurchaseId); // 0x0000000181B4FBD0-0x0000000181B4FC70
		public static extern void Purchase_64(IAPurchaseCallback callback, string pchPurchaseId); // 0x0000000181B4F8B0-0x0000000181B4F950
		public static extern void Query(IAPurchaseCallback callback, string pchPurchaseId); // 0x0000000181B50920-0x0000000181B509C0
		public static extern void Query_64(IAPurchaseCallback callback, string pchPurchaseId); // 0x0000000181B50500-0x0000000181B505A0
		public static extern void Query(IAPurchaseCallback callback); // 0x0000000181B50620-0x0000000181B506A0
		public static extern void Query_64(IAPurchaseCallback callback); // 0x0000000181B505A0-0x0000000181B50620
		public static extern void GetBalance(IAPurchaseCallback callback); // 0x0000000181B4F3B0-0x0000000181B4F440
		public static extern void GetBalance_64(IAPurchaseCallback callback); // 0x0000000181B4F0C0-0x0000000181B4F150
		public static extern void RequestSubscription(IAPurchaseCallback callback, string pchPrice, string pchFreeTrialType, int nFreeTrialValue, string pchChargePeriodType, int nChargePeriodValue, int nNumberOfChargePeriod, string pchPlanId); // 0x0000000181B515D0-0x0000000181B51700
		public static extern void RequestSubscription_64(IAPurchaseCallback callback, string pchPrice, string pchFreeTrialType, int nFreeTrialValue, string pchChargePeriodType, int nChargePeriodValue, int nNumberOfChargePeriod, string pchPlanId); // 0x0000000181B51150-0x0000000181B51280
		public static extern void RequestSubscriptionWithPlanID(IAPurchaseCallback callback, string pchPlanId); // 0x0000000181B50E30-0x0000000181B50ED0
		public static extern void RequestSubscriptionWithPlanID_64(IAPurchaseCallback callback, string pchPlanId); // 0x0000000181B50D90-0x0000000181B50E30
		public static extern void Subscribe(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B51F60-0x0000000181B52000
		public static extern void Subscribe_64(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B51EC0-0x0000000181B51F60
		public static extern void QuerySubscription(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B50460-0x0000000181B50500
		public static extern void QuerySubscription_64(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B50140-0x0000000181B501E0
		public static extern void QuerySubscriptionList(IAPurchaseCallback callback); // 0x0000000181B500C0-0x0000000181B50140
		public static extern void QuerySubscriptionList_64(IAPurchaseCallback callback); // 0x0000000181B4FDF0-0x0000000181B4FE70
		public static extern void CancelSubscription(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B4EFC0-0x0000000181B4F060
		public static extern void CancelSubscription_64(IAPurchaseCallback callback, string pchSubscriptionId); // 0x0000000181B4ECA0-0x0000000181B4ED40
	}
}
