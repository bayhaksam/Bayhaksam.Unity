//-----------------------------------------------------------------------
// <copyright file="OnDelayedStart.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using System.Collections;
	using UnityEngine;
	using UnityEngine.Events;

	public class OnDelayedStart : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		float seconds = 1.0f;

		[SerializeField]
		UnityEvent onDelayedStartInvoked;
		#endregion

		#region Unity Events
		public UnityEvent OnDelayedStartInvoked
		{
			get => this.onDelayedStartInvoked;
			set => this.onDelayedStartInvoked = value;
		}
		#endregion

		#region Properties
		public float Seconds { get => this.seconds; set => this.seconds = value; }
		#endregion

		#region Unity Methods
		/// <inheritdoc/>
		protected virtual IEnumerator Start()
		{
			yield return new WaitForSeconds(this.Seconds);

			this.OnDelayedStartInvoked.Invoke();
		}
		#endregion
	}
}
