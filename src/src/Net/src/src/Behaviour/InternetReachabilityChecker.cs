//-----------------------------------------------------------------------
// <copyright file="InternetReachabilityChecker.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Net.Behaviour
{
	public class InternetReachabilityChecker : InternetReachabilityCheckerBase
	{
		#region Public Methods
		public override void Execute()
		{
			if (this.GetIsInternetAvailable())
			{
				this.OnInternetAvailable.Invoke();

				return;
			}

			this.OnInternetIsNotAvailable.Invoke(this.CheckYourInternetConnectionLabel);
		}
		#endregion
	}
}
