//-----------------------------------------------------------------------
// <copyright file="OnEnableBehaviour.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class OnEnableBehaviour : MonoBehaviour
	{
		#region Unity Events
		public UnityEvent OnEnableInvoked;
		#endregion

		#region Unity Methods
		protected virtual void OnEnable()
		{
			this.OnEnableInvoked.Invoke();
		}
		#endregion
	}
}
