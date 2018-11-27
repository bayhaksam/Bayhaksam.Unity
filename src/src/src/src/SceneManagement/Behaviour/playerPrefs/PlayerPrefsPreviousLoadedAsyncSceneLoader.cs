//-----------------------------------------------------------------------
// <copyright file="PlayerPrefsPreviousLoadedAsyncSceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement.Behaviour
{
	using System;
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class PlayerPrefsPreviousLoadedAsyncSceneLoader
		: PlayerPrefsPreviousLoadedSceneLoaderBase, IPreviousLoadedSceneAsyncLoader
	{
		#region Static Fields
		/// <summary>
		/// Stores value for lazy initialization.
		/// </summary>
		static Lazy<PlayerPrefsPreviousLoadedAsyncSceneLoader> lazyInstance;
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static PlayerPrefsPreviousLoadedAsyncSceneLoader Instance => lazyInstance.Value;
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			lazyInstance = new Lazy<PlayerPrefsPreviousLoadedAsyncSceneLoader>(
				() => this.gameObject.GetComponent<PlayerPrefsPreviousLoadedAsyncSceneLoader>());
		}
		#endregion

		#region Public Methods
		public virtual AsyncOperation LoadAsync()
		{
			return SceneManager.LoadSceneAsync(this.GetPreviousSceneIndex());
		}

		public virtual AsyncOperation LoadAsync(LoadSceneMode mode)
		{
			return SceneManager.LoadSceneAsync(this.GetPreviousSceneIndex(), mode);
		}
		#endregion
	}
}
