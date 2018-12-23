//-----------------------------------------------------------------------
// <copyright file="Timer.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class Timer : MonoBehaviour
	{
		#region Fields
		#region Unity Fields
		[SerializeField]
		bool isCountDown;

		[SerializeField]
		float tick = 1.0f;

		[SerializeField]
		UnityEvent onFinished;

		[SerializeField]
		UnityEvent onReset;

		[SerializeField]
		UnityEvent onTick;
		#endregion

		float currentTick = 1.0f;
		#endregion

		#region Unity Events
		public UnityEvent OnFinished
		{
			get { return this.onFinished; }
			set { this.onFinished = value; }
		}

		public UnityEvent OnReset
		{
			get { return this.onReset; }
			set { this.onReset = value; }
		}

		public UnityEvent OnTick
		{
			get { return this.onTick; }
			set { this.onTick = value; }
		}
		#endregion

		#region Properties
		public bool IsCountdown
		{
			get { return this.isCountDown; }
			set { this.isCountDown = value; }
		}

		public bool IsRunning { get; private set; }

		public float CurrentTime { get; private set; }

		public float Time { get; set; }
		#endregion

		#region Unity Methods
		protected virtual void Update()
		{
			if (this.IsRunning)
			{
				this.currentTick -= UnityEngine.Time.deltaTime;

				if (this.currentTick <= 0.0f)
				{
					this.OnTimerTick();
				}
			}
		}
		#endregion

		#region Public Methods
		public virtual void ResetValues()
		{
			this.currentTick = this.tick;
			this.CurrentTime = !this.IsCountdown ? 0 : this.Time;
			this.OnReset.Invoke();
		}

		public virtual void Restart()
		{
			this.ResetValues();
			this.Run();
		}

		public virtual void Run()
		{
			this.IsRunning = true;
		}

		public virtual void Stop()
		{
			this.IsRunning = false;
		}
		#endregion

		#region Protected Methods
		protected virtual void OnTimerTick()
		{
			if (!this.IsCountdown)
			{
				this.OnForwardTick();

				return;
			}

			this.OnBackwardTick();
		}
		#endregion

		#region Methods
		void OnBackwardTick()
		{
			this.CurrentTime -= this.tick;
			this.OnTick.Invoke();

			if (this.CurrentTime > 0)
			{
				this.currentTick = this.tick;

				return;
			}

			// On timer end
			this.Stop();
			this.OnFinished.Invoke();
		}

		void OnForwardTick()
		{
			this.CurrentTime += this.tick;
			this.OnTick.Invoke();

			if (this.CurrentTime < this.Time)
			{
				this.currentTick = this.tick;

				return;
			}

			// On timer end
			this.Stop();
			this.OnFinished.Invoke();
		}
		#endregion
	}
}
