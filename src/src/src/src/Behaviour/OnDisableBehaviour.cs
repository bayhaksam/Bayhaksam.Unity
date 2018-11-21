//-----------------------------------------------------------------------
// <copyright file="OnDisableBehaviour.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class OnDisableBehaviour : MonoBehaviour
	{
		#region Unity Events
		public UnityEvent OnDisableInvoked;
		#endregion

		#region Unity Methods
		protected virtual void OnDisable()
		{
			this.OnDisableInvoked.Invoke();
		}
		#endregion
	}
}
