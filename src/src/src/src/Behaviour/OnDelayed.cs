//-----------------------------------------------------------------------
// <copyright file="OnDelayed.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using Bayhaksam.Unity.Events;
	using UnityEngine;
	using UnityEngine.Events;

	public class OnDelayed : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		float seconds = 1.0f;

		[SerializeField]
		bool invokeOnAwake;

		[SerializeField]
		bool invokeOnStart = true;

		[SerializeField]
		bool isInvokeNotSeconds = true;

		[SerializeField]
		UnityEvent onDelayedInvoked;

		[SerializeField]
		FloatUnityEvent onTick;
		#endregion

		#region Fields
		[SerializeField]
		float currentSeconds;
		#endregion

		#region Unity Events
		public FloatUnityEvent OnTick { get => this.onTick; set => this.onTick = value; }

		public UnityEvent OnDelayedInvoked { get => this.onDelayedInvoked; set => this.onDelayedInvoked = value; }
		#endregion

		#region Properties
		public bool IsInvokeNotSeconds
		{
			get => this.isInvokeNotSeconds;
			set => this.isInvokeNotSeconds = value;
		}

		public bool IsRunning { get; set; }

		public float Seconds { get => this.seconds; set => this.seconds = value; }
		#endregion

		#region Unity Methods
		/// <inheritdoc/>
		protected virtual void Awake()
		{
			if (this.invokeOnAwake)
			{
				this.Execute();
			}
		}

		/// <inheritdoc/>
		protected virtual void Start()
		{
			if (this.invokeOnStart)
			{
				this.Execute();
			}
		}

		/// <inheritdoc/>
		protected virtual void Update()
		{
			if (this.IsRunning && this.currentSeconds > 0)
			{
				this.currentSeconds -= Time.deltaTime;
				if (this.currentSeconds < 0)
				{
					this.currentSeconds = 0;
					this.Cancel();
					this.OnDelayedInvoked.Invoke();
				}

				this.OnTick.Invoke(this.currentSeconds);
			}
		}
		#endregion

		#region Public Methods
		public void Cancel() => this.IsRunning = false;

		public void Execute()
		{
			if (this.Seconds > 0)
			{
				this.currentSeconds = this.Seconds;
				this.IsRunning = true;

				return;
			}

			if (this.IsInvokeNotSeconds)
			{
				this.OnDelayedInvoked.Invoke();
				this.OnTick.Invoke(0);
			}
		}

		public void ResetValues()
		{
			this.IsRunning = false;
			this.currentSeconds = this.Seconds;
		}

		public void Restart()
		{
			this.ResetValues();
			this.IsRunning = true;
		}
		#endregion
	}
}
