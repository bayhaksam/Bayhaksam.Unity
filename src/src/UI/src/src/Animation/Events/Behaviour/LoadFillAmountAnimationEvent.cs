//-----------------------------------------------------------------------
// <copyright file="LoadFillAmountAnimationEvent.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Animation.Events.Behaviour
{
	using Bayhaksam.Unity.Animation.Events.Behaviour;
	using UnityEngine;
	using UnityEngine.UI;

	public class LoadFillAmountAnimationEvent : AnimationEventBase<Image>
	{
		#region Fields
		bool isRunning;

		float passedTime;
		#endregion

		#region Properties
		public float SavedFillAmount { get; set; }
		#endregion

		#region Unity Methods
		protected virtual void Update()
		{
			if (this.isRunning)
			{
				this.passedTime += Time.deltaTime;
				if (this.passedTime >= 1)
				{
					this.passedTime = 1;
				}

				this.Target.fillAmount = this.passedTime;
				if (this.passedTime >= this.SavedFillAmount)
				{
					this.isRunning = false;
				}
			}
		}
		#endregion

		#region Animation Events
		public void StartFillAmount()
		{
			if (this.Target.fillAmount != 0)
			{
				this.isRunning = true;
				this.passedTime = 0;
				this.SavedFillAmount = this.Target.fillAmount;
				this.Target.fillAmount = 0;
			}
		}

		public void StopFillAmount()
		{
			this.Target.fillAmount = this.SavedFillAmount;
			this.isRunning = false;
		}
		#endregion
	}
}
