//-----------------------------------------------------------------------
// <copyright file="SingletonCustomAssetBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.CustomAsset
{
	using System;
	using System.Linq;
	using UnityEngine;

	public abstract class SingletonCustomAssetBase<T> : ScriptableObject where T : SingletonCustomAssetBase<T>
	{
		#region Protected Constructors
		protected SingletonCustomAssetBase()
		{
		}
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static T Instance => LazyInstance.Value;
		#endregion

		#region Static Protected Properties
		/// <summary>
		/// Gets value for lazy initialization.
		/// </summary>
		protected static Lazy<T> LazyInstance { get; private set; }
			= new Lazy<T>(() => Resources.FindObjectsOfTypeAll<T>().FirstOrDefault());
		#endregion
	}
}
