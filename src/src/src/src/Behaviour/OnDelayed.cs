//-----------------------------------------------------------------------
// <copyright file="OnDelayed.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using System.Collections;
	using UnityEngine;
	using UnityEngine.Events;

	public class OnDelayed : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		float seconds = 1.0f;

		[SerializeField]
		bool invokeOnStart = true;

		[SerializeField]
		UnityEvent onDelayedInvoked;
		#endregion

		#region Unity Events
		public UnityEvent OnDelayedInvoked
		{
			get => this.onDelayedInvoked;
			set => this.onDelayedInvoked = value;
		}
		#endregion

		#region Properties
		public bool IsCancelled { get; set; }

		public float Seconds { get => this.seconds; set => this.seconds = value; }
		#endregion

		#region Unity Methods
		/// <inheritdoc/>
		protected virtual void Start()
		{
			if (this.invokeOnStart)
			{
				this.StartCoroutine(this.OnExecute());
			}
		}
		#endregion

		#region Public Methods
		public void Cancel()
		{
			this.IsCancelled = true;
			this.StopCoroutine(this.OnExecute());
		}

		public void Execute()
		{
			this.IsCancelled = false;
			this.StartCoroutine(this.OnExecute());
		}
		#endregion

		#region Methods
		protected virtual IEnumerator OnExecute()
		{
			yield return new WaitForSeconds(this.Seconds);

			if (!this.IsCancelled)
			{
				this.OnDelayedInvoked.Invoke();
			}
		}
		#endregion
	}
}
