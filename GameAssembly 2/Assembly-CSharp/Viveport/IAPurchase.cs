/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	public class IAPurchase // TypeDefIndex: 7363
	{
		// Fields
		private static IAPurchaseCallback isReadyIl2cppCallback; // 0x00
		private static IAPurchaseCallback request01Il2cppCallback; // 0x08
		private static IAPurchaseCallback request02Il2cppCallback; // 0x10
		private static IAPurchaseCallback purchaseIl2cppCallback; // 0x18
		private static IAPurchaseCallback query01Il2cppCallback; // 0x20
		private static IAPurchaseCallback query02Il2cppCallback; // 0x28
		private static IAPurchaseCallback getBalanceIl2cppCallback; // 0x30
		private static IAPurchaseCallback requestSubscriptionIl2cppCallback; // 0x38
		private static IAPurchaseCallback requestSubscriptionWithPlanIDIl2cppCallback; // 0x40
		private static IAPurchaseCallback subscribeIl2cppCallback; // 0x48
		private static IAPurchaseCallback querySubscriptionIl2cppCallback; // 0x50
		private static IAPurchaseCallback querySubscriptionListIl2cppCallback; // 0x58
		private static IAPurchaseCallback cancelSubscriptionIl2cppCallback; // 0x60
	
		// Nested types
		private class IAPHandler : BaseHandler // TypeDefIndex: 7364
		{
			// Fields
			private static IAPurchaseListener listener; // 0x00
	
			// Constructors
			public IAPHandler() {} // Dummy constructor
			public IAPHandler(IAPurchaseListener cb) {} // 0x0000000181B4E360-0x0000000181B4E3C0
	
			// Methods
			public IAPurchaseCallback getIsReadyHandler() => default; // 0x0000000181B4E4C0-0x0000000181B4E540
			protected override void IsReadyHandler(int code, string message) {} // 0x0000000181B4A270-0x0000000181B4A730
			public IAPurchaseCallback getRequestHandler() => default; // 0x0000000181B4E7C0-0x0000000181B4E840
			protected override void RequestHandler(int code, string message) {} // 0x0000000181B4CE10-0x0000000181B4D2D0
			public IAPurchaseCallback getPurchaseHandler() => default; // 0x0000000181B4E540-0x0000000181B4E5C0
			protected override void PurchaseHandler(int code, string message) {} // 0x0000000181B4A730-0x0000000181B4ADD0
			public IAPurchaseCallback getQueryHandler() => default; // 0x0000000181B4E5C0-0x0000000181B4E640
			protected override void QueryHandler(int code, string message) {} // 0x0000000181B4ADD0-0x0000000181B4B930
			public IAPurchaseCallback getQueryListHandler() => default; // 0x0000000181B4E640-0x0000000181B4E6C0
			protected override void QueryListHandler(int code, string message) {} // 0x0000000181B4B930-0x0000000181B4C490
			public IAPurchaseCallback getBalanceHandler() => default; // 0x0000000181B4E3C0-0x0000000181B4E440
			protected override void BalanceHandler(int code, string message) {} // 0x0000000181B497A0-0x0000000181B49E40
			public IAPurchaseCallback getRequestSubscriptionHandler() => default; // 0x0000000181B4E840-0x0000000181B4E8C0
			protected override void RequestSubscriptionHandler(int code, string message) {} // 0x0000000181B4D2D0-0x0000000181B4D770
			public IAPurchaseCallback getRequestSubscriptionWithPlanIDHandler() => default; // 0x0000000181B4E8C0-0x0000000181B4E940
			protected override void RequestSubscriptionWithPlanIDHandler(int code, string message) {} // 0x0000000181B4D770-0x0000000181B4DC10
			public IAPurchaseCallback getSubscribeHandler() => default; // 0x0000000181B4E940-0x0000000181B4E9C0
			protected override void SubscribeHandler(int code, string message) {} // 0x0000000181B4DC10-0x0000000181B4E360
			public IAPurchaseCallback getQuerySubscriptionHandler() => default; // 0x0000000181B4E6C0-0x0000000181B4E740
			protected override void QuerySubscriptionHandler(int code, string message) {} // 0x0000000181B4C490-0x0000000181B4C950
			public IAPurchaseCallback getQuerySubscriptionListHandler() => default; // 0x0000000181B4E740-0x0000000181B4E7C0
			protected override void QuerySubscriptionListHandler(int code, string message) {} // 0x0000000181B4C950-0x0000000181B4CE10
			public IAPurchaseCallback getCancelSubscriptionHandler() => default; // 0x0000000181B4E440-0x0000000181B4E4C0
			protected override void CancelSubscriptionHandler(int code, string message) {} // 0x0000000181B49E40-0x0000000181B4A270
		}
	
		private abstract class BaseHandler // TypeDefIndex: 7365
		{
			// Constructors
			protected BaseHandler() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			protected abstract void IsReadyHandler(int code, string message);
			protected abstract void RequestHandler(int code, string message);
			protected abstract void PurchaseHandler(int code, string message);
			protected abstract void QueryHandler(int code, string message);
			protected abstract void QueryListHandler(int code, string message);
			protected abstract void BalanceHandler(int code, string message);
			protected abstract void RequestSubscriptionHandler(int code, string message);
			protected abstract void RequestSubscriptionWithPlanIDHandler(int code, string message);
			protected abstract void SubscribeHandler(int code, string message);
			protected abstract void QuerySubscriptionHandler(int code, string message);
			protected abstract void QuerySubscriptionListHandler(int code, string message);
			protected abstract void CancelSubscriptionHandler(int code, string message);
		}
	
		public class IAPurchaseListener // TypeDefIndex: 7366
		{
			// Constructors
			public IAPurchaseListener() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public virtual void OnSuccess(string pchCurrencyName) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnRequestSuccess(string pchPurchaseId) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnPurchaseSuccess(string pchPurchaseId) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnQuerySuccess(QueryResponse response) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnQuerySuccess(QueryListResponse response) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnBalanceSuccess(string pchBalance) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnFailure(int nCode, string pchMessage) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnRequestSubscriptionSuccess(string pchSubscriptionId) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnRequestSubscriptionWithPlanIDSuccess(string pchSubscriptionId) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnSubscribeSuccess(string pchSubscriptionId) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnQuerySubscriptionSuccess(Subscription[] subscriptionlist) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnQuerySubscriptionListSuccess(Subscription[] subscriptionlist) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnCancelSubscriptionSuccess(bool bCanceled) {} // 0x0000000180246DB0-0x0000000180246DC0
		}
	
		public class QueryResponse // TypeDefIndex: 7367
		{
			// Properties
			public string order_id { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public string purchase_id { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public string status { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
			public string price { get; set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
			public string currency { get; set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
			public long paid_timestamp { get; set; } // 0x0000000180246FD0-0x0000000180246FE0 0x00000001804578D0-0x00000001804578E0
	
			// Constructors
			public QueryResponse() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class QueryResponse2 // TypeDefIndex: 7368
		{
			// Properties
			public string order_id { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public string app_id { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public string purchase_id { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
			public string user_data { get; set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
			public string price { get; set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
			public string currency { get; set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
			public long paid_timestamp { get; set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000181B53140-0x0000000181B53150
	
			// Constructors
			public QueryResponse2() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class QueryListResponse // TypeDefIndex: 7369
		{
			// Fields
			public List<QueryResponse2> purchaseList; // 0x20
	
			// Properties
			public int total { get; set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
			public int from { get; set; } // 0x00000001802932A0-0x00000001802932B0 0x00000001802932F0-0x0000000180293300
			public int to { get; set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
	
			// Constructors
			public QueryListResponse() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class StatusDetailTransaction // TypeDefIndex: 7370
		{
			// Properties
			public long create_time { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x00000001802D5F50-0x00000001802D5F60
			public string payment_method { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public string status { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
	
			// Constructors
			public StatusDetailTransaction() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class StatusDetail // TypeDefIndex: 7371
		{
			// Properties
			public long date_next_charge { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x00000001802D5F50-0x00000001802D5F60
			public StatusDetailTransaction[] transactions { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public string cancel_reason { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
	
			// Constructors
			public StatusDetail() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class TimePeriod // TypeDefIndex: 7372
		{
			// Properties
			public string time_type { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public int value { get; set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
	
			// Constructors
			public TimePeriod() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class Subscription // TypeDefIndex: 7373
		{
			// Properties
			public string app_id { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public string order_id { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public string subscription_id { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
			public string price { get; set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
			public string currency { get; set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
			public long subscribed_timestamp { get; set; } // 0x0000000180246FD0-0x0000000180246FE0 0x00000001804578D0-0x00000001804578E0
			public TimePeriod free_trial_period { get; set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
			public TimePeriod charge_period { get; set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
			public int number_of_charge_period { get; set; } // 0x0000000180255F80-0x0000000180255F90 0x0000000180422DE0-0x0000000180422DF0
			public string plan_id { get; set; } // 0x0000000180246F30-0x0000000180246F40 0x00000001802470C0-0x00000001802470D0
			public string plan_name { get; set; } // 0x0000000180274940-0x0000000180274950 0x0000000180280570-0x0000000180280580
			public string status { get; set; } // 0x0000000180274930-0x0000000180274940 0x00000001803CD190-0x00000001803CD1A0
			public StatusDetail status_detail { get; set; } // 0x0000000180274980-0x0000000180274990 0x0000000180280510-0x0000000180280520
	
			// Constructors
			public Subscription() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public class QuerySubscritionResponse // TypeDefIndex: 7374
		{
			// Properties
			public int statusCode { get; set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
			public string message { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
			public List<Subscription> subscriptions { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
	
			// Constructors
			public QuerySubscritionResponse() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public IAPurchase() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180126F70-0x0000000180126FC0
		private static void IsReadyIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4F440-0x0000000181B4F4A0
		public static void IsReady(IAPurchaseListener listener, string pchAppKey) {} // 0x0000000181B4F540-0x0000000181B4F7B0
		// [MonoPInvokeCallback] // 0x0000000180127090-0x00000001801270E0
		private static void Request01Il2cppCallback(int errorCode, string message) {} // 0x0000000181B50C10-0x0000000181B50C70
		public static void Request(IAPurchaseListener listener, string pchPrice) {} // 0x0000000181B51B70-0x0000000181B51DA0
		// [MonoPInvokeCallback] // 0x0000000180127120-0x0000000180127170
		private static void Request02Il2cppCallback(int errorCode, string message) {} // 0x0000000181B50C70-0x0000000181B50CD0
		public static void Request(IAPurchaseListener listener, string pchPrice, string pchUserData) {} // 0x0000000181B51900-0x0000000181B51B70
		// [MonoPInvokeCallback] // 0x00000001801272A0-0x00000001801272F0
		private static void PurchaseIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4F850-0x0000000181B4F8B0
		public static void Purchase(IAPurchaseListener listener, string pchPurchaseId) {} // 0x0000000181B4F950-0x0000000181B4FBD0
		// [MonoPInvokeCallback] // 0x0000000180127360-0x00000001801273B0
		private static void Query01Il2cppCallback(int errorCode, string message) {} // 0x0000000181B4FC70-0x0000000181B4FCD0
		public static void Query(IAPurchaseListener listener, string pchPurchaseId) {} // 0x0000000181B506A0-0x0000000181B50920
		// [MonoPInvokeCallback] // 0x0000000180127500-0x0000000180127550
		private static void Query02Il2cppCallback(int errorCode, string message) {} // 0x0000000181B4FCD0-0x0000000181B4FD30
		public static void Query(IAPurchaseListener listener) {} // 0x0000000181B509C0-0x0000000181B50C10
		// [MonoPInvokeCallback] // 0x0000000180127A60-0x0000000180127AB0
		private static void GetBalanceIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4F060-0x0000000181B4F0C0
		public static void GetBalance(IAPurchaseListener listener) {} // 0x0000000181B4F150-0x0000000181B4F3B0
		// [MonoPInvokeCallback] // 0x0000000180127B90-0x0000000180127BE0
		private static void RequestSubscriptionIl2cppCallback(int errorCode, string message) {} // 0x0000000181B50CD0-0x0000000181B50D30
		public static void RequestSubscription(IAPurchaseListener listener, string pchPrice, string pchFreeTrialType, int nFreeTrialValue, string pchChargePeriodType, int nChargePeriodValue, int nNumberOfChargePeriod, string pchPlanId) {} // 0x0000000181B51280-0x0000000181B515D0
		// [MonoPInvokeCallback] // 0x0000000180127CB0-0x0000000180127D00
		private static void RequestSubscriptionWithPlanIDIl2cppCallback(int errorCode, string message) {} // 0x0000000181B50D30-0x0000000181B50D90
		public static void RequestSubscriptionWithPlanID(IAPurchaseListener listener, string pchPlanId) {} // 0x0000000181B50ED0-0x0000000181B51150
		// [MonoPInvokeCallback] // 0x0000000180127DC0-0x0000000180127E10
		private static void SubscribeIl2cppCallback(int errorCode, string message) {} // 0x0000000181B51E60-0x0000000181B51EC0
		public static void Subscribe(IAPurchaseListener listener, string pchSubscriptionId) {} // 0x0000000181B52000-0x0000000181B52280
		// [MonoPInvokeCallback] // 0x00000001801281D0-0x0000000180128220
		private static void QuerySubscriptionIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4FD30-0x0000000181B4FD90
		public static void QuerySubscription(IAPurchaseListener listener, string pchSubscriptionId) {} // 0x0000000181B501E0-0x0000000181B50460
		// [MonoPInvokeCallback] // 0x0000000180128370-0x00000001801283C0
		private static void QuerySubscriptionListIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4FD90-0x0000000181B4FDF0
		public static void QuerySubscriptionList(IAPurchaseListener listener) {} // 0x0000000181B4FE70-0x0000000181B500C0
		// [MonoPInvokeCallback] // 0x00000001801285D0-0x0000000180128620
		private static void CancelSubscriptionIl2cppCallback(int errorCode, string message) {} // 0x0000000181B4EC40-0x0000000181B4ECA0
		public static void CancelSubscription(IAPurchaseListener listener, string pchSubscriptionId) {} // 0x0000000181B4ED40-0x0000000181B4EFC0
	}
}
