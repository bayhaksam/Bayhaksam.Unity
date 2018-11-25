//-----------------------------------------------------------------------
// <copyright file="InternetReachabilityCheckerBase.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Net.Behaviour
{
	using Bayhaksam.Unity.Events;
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class InternetReachabilityCheckerBase : MonoBehaviour, IInternetReachabilityChecker
	{
		#region Unity Fields
		[SerializeField]
		bool allowCarrierDataNetwork = true;

		[SerializeField]
		bool allowLocalAreaNetwork = true;

		[SerializeField]
		UnityEvent onInternetAvailable;

		[SerializeField]
		StringUnityEvent onInternetIsNotAvailable;
		#endregion

		#region IInternetChecker Unity Events
		public UnityEvent OnInternetAvailable
		{
			get { return this.onInternetAvailable; }
			set { this.onInternetAvailable = value; }
		}

		public StringUnityEvent OnInternetIsNotAvailable
		{
			get { return this.onInternetIsNotAvailable; }
			set { this.onInternetIsNotAvailable = value; }
		}
		#endregion

		#region IInternetChecker Properties
		public bool AllowCarrierDataNetwork
		{
			get { return this.allowCarrierDataNetwork; }
			set { this.allowCarrierDataNetwork = value; }
		}

		public bool AllowLocalAreaNetwork
		{
			get { return this.allowLocalAreaNetwork; }
			set { this.allowLocalAreaNetwork = value; }
		}

		public virtual string CheckYourInternetConnectionLabel { get; set; } = "Check your internet connection.";
		#endregion

		#region IInternetChecker Abstract Methods
		public abstract void Execute();
		#endregion

		#region Protected Methods
		protected virtual bool GetIsInternetAvailable()
		{
			switch (Application.internetReachability)
			{
				case NetworkReachability.NotReachable:
					{
						return false;
					}
				case NetworkReachability.ReachableViaCarrierDataNetwork:
					{
						if (this.AllowCarrierDataNetwork)
						{
							return true;
						}

						return false;
					}
				case NetworkReachability.ReachableViaLocalAreaNetwork:
					{
						if (this.AllowLocalAreaNetwork)
						{
							return true;
						}

						return false;
					}
				default:
					{
						return false;
					}
			}
		}
		#endregion
	}
}
