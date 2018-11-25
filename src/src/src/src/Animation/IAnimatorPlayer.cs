//-----------------------------------------------------------------------
// <copyright file="IAnimatorPlayer.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Animation
{
	using UnityEngine;

	public interface IAnimatorPlayer
	{
		#region Properties
		Animator Animator { get; set; }
		#endregion

		#region Methods
		void Play(string stateName);

		void Play(string stateName, int layer);

		void Play(string stateName, int layer, float normalizedTime);

		void PlayInFixedTime(string stateName);

		void PlayInFixedTime(string stateName, int layer);

		void PlayInFixedTime(string stateName, int layer, float fixedTime);
		#endregion
	}
}
