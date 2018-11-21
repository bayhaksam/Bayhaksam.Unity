//-----------------------------------------------------------------------
// <copyright file="OnDestroyBehaviour.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class OnDestroyBehaviour : MonoBehaviour
	{
		#region Unity Events
		public UnityEvent OnDestroyInvoked;
		#endregion

		#region Unity Methods
		protected virtual void OnDestroy()
		{
			this.OnDestroyInvoked.Invoke();
		}
		#endregion
	}
}
