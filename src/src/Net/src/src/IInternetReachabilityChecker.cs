//-----------------------------------------------------------------------
// <copyright file="IInternetReachabilityChecker.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Net
{
	using Bayhaksam.Unity.Events;
	using UnityEngine.Events;

	public interface IInternetReachabilityChecker
	{
		#region Properties
		bool AllowCarrierDataNetwork { get; set; }

		bool AllowLocalAreaNetwork { get; set; }

		string CheckYourInternetConnectionLabel { get; set; }
		#endregion

		#region Unity Events
		UnityEvent OnInternetAvailable { get; set; }

		StringUnityEvent OnInternetIsNotAvailable { get; set; }
		#endregion

		#region Methods
		void Execute();
		#endregion
	}
}
