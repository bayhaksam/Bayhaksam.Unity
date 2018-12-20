//-----------------------------------------------------------------------
// <copyright file="UnityEventHandler.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Events.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class UnityEventHandler : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		UnityEvent onInvoked;
		#endregion

		#region Unity Events
		public UnityEvent OnInvoked
		{
			get => this.onInvoked;
			set => this.onInvoked = value;
		}
		#endregion

		#region Public Methods
		public virtual void Execute()
		{
			this.OnInvoked.Invoke();
		}
		#endregion
	}
}
