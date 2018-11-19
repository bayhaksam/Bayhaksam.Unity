//-----------------------------------------------------------------------
// <copyright file="SingletonMonoBehaviourBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;

	public abstract class SingletonMonoBehaviourBase<T> : SingletonMonoBehaviourBase<T, T>
		where T : MonoBehaviour, new()
	{
		#region Protected Constructors
		protected SingletonMonoBehaviourBase() : base()
		{
		}
		#endregion
	}
}
