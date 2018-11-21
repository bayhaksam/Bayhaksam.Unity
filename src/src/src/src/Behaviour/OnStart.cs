//-----------------------------------------------------------------------
// <copyright file="OnStart.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class OnStart : MonoBehaviour
	{
		#region Unity Events
		public UnityEvent OnStartInvoked;
		#endregion

		#region Unity Methods
		protected virtual void Start()
		{
			this.OnStartInvoked.Invoke();
		}
		#endregion
	}
}
