//-----------------------------------------------------------------------
// <copyright file="AnimatorPlayer.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Animation.Behaviour
{
	using UnityEngine;

	public class AnimatorPlayer : MonoBehaviour, IAnimatorPlayer
	{
		#region Unity Fields
		[SerializeField]
		Animator animator;
		#endregion

		#region IAnimatorPlayer Properties
		public virtual Animator Animator
		{
			get
			{
				return this.animator != null ? this.animator : (this.animator = this.GetComponent<Animator>());
			}

			set
			{
				this.animator = value;
			}
		}
		#endregion

		#region IAnimatorPlayer Methods
		public virtual void Play(string stateName)
		{
			this.Animator.Play(stateName);
		}

		public virtual void Play(string stateName, int layer)
		{
			this.Animator.Play(stateName, layer);
		}

		public virtual void Play(string stateName, int layer, float normalizedTime)
		{
			this.Animator.Play(stateName, layer, normalizedTime);
		}

		public virtual void PlayInFixedTime(string stateName)
		{
			this.Animator.Play(stateName);
		}

		public virtual void PlayInFixedTime(string stateName, int layer)
		{
			this.Animator.Play(stateName, layer);
		}

		public virtual void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			this.Animator.Play(stateName, layer, fixedTime);
		}
		#endregion
	}
}
