//-----------------------------------------------------------------------
// <copyright file="SingletonMonoBehaviourBase`2.cs" company="Simsoft">
//      Copyright (c) Simsoft. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using System;
	using UnityEngine;

	public abstract class SingletonMonoBehaviourBase<TInstance, TConcrete> : MonoBehaviour
		where TInstance : MonoBehaviour
		where TConcrete : TInstance, new()
	{
		#region Protected Constructors
		protected SingletonMonoBehaviourBase()
		{
		}
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static TInstance Instance => LazyInstance.Value;
		#endregion

		#region Static Protected Properties
		/// <summary>
		/// Gets value for lazy initialization.
		/// </summary>
		protected static Lazy<TInstance> LazyInstance { get; private set; }
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			LazyInstance = new Lazy<TInstance>(() => this.gameObject.GetComponent<TConcrete>());
		}
		#endregion
	}
}
