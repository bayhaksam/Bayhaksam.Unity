//-----------------------------------------------------------------------
// <copyright file="ContinuousInternetReachabilityChecker.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Net.Behaviour
{
	using UnityEngine;

	public class ContinuousInternetReachabilityChecker : InternetReachabilityChecker
	{
		#region Fields
		NetworkReachability status;
		#endregion

		#region Unity Methods
		protected virtual void Start()
		{
			this.Execute();
		}

		protected virtual void Update()
		{
			if (this.status != Application.internetReachability)
			{
				this.Execute();
			}
		}
		#endregion

		#region Methods
		public override void Execute()
		{
			this.status = Application.internetReachability;
			base.Execute();
		}
		#endregion
	}
}
