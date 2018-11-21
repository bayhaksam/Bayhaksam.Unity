﻿//-----------------------------------------------------------------------
// <copyright file="OnAwakeBehaviour.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;

	public class OnAwakeBehaviour : MonoBehaviour
	{
		#region Unity Events
		public UnityEvent OnAwakeInvoked;
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			this.OnAwakeInvoked.Invoke();
		}
		#endregion
	}
}
