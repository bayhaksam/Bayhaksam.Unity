//-----------------------------------------------------------------------
// <copyright file="LoadingCircle.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;

	public class LoadingCircle : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		bool isAutoStart = true;

		[SerializeField]
		bool isClockWise = true;

		[SerializeField]
		RectTransform progress;

		[SerializeField]
		float speed = 200f;
		#endregion

		#region Properties
		public bool IsAutoStart
		{
			get { return this.isAutoStart; }
			set { this.isAutoStart = value; }
		}

		public bool IsClockWise
		{
			get { return this.isClockWise; }
			set { this.isClockWise = value; }
		}

		public bool IsRunning { get; set; }

		public float Speed
		{
			get { return this.speed; }
			set { this.speed = value; }
		}

		public RectTransform Progress
		{
			get { return this.progress; }
			set { this.progress = value; }
		}
		#endregion

		#region Protected Properties
		protected Quaternion InitialProgressRotation { get; set; }
		#endregion

		#region Unity Methods
		protected virtual void Start()
		{
			this.InitialProgressRotation = this.Progress.rotation;
			this.IsRunning = this.IsAutoStart;
		}

		protected virtual void Update()
		{
			if (this.IsRunning)
			{
				this.Progress.Rotate(0f, 0f, (this.IsClockWise ? -1 : 1) * this.Speed * Time.deltaTime);
			}
		}
		#endregion

		#region Public Methods
		public void ResetValues()
		{
			this.Progress.rotation = this.InitialProgressRotation;
		}

		public void Run()
		{
			this.IsRunning = true;
		}

		public void Stop()
		{
			this.IsRunning = false;
		}
		#endregion
	}
}
