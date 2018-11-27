//-----------------------------------------------------------------------
// <copyright file="PlayerPrefsPreviousLoadedSceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement.Behaviour
{
	using System;
	using UnityEngine.SceneManagement;

	public class PlayerPrefsPreviousLoadedSceneLoader
		: PlayerPrefsPreviousLoadedSceneLoaderBase, IPreviousLoadedSceneLoader
	{
		#region Static Fields
		/// <summary>
		/// Stores value for lazy initialization.
		/// </summary>
		static Lazy<PlayerPrefsPreviousLoadedSceneLoader> lazyInstance;
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static PlayerPrefsPreviousLoadedSceneLoader Instance => lazyInstance.Value;
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			lazyInstance = new Lazy<PlayerPrefsPreviousLoadedSceneLoader>(
				() => this.gameObject.GetComponent<PlayerPrefsPreviousLoadedSceneLoader>());
		}
		#endregion

		#region Public Methods
		public virtual void Load()
		{
			SceneManager.LoadScene(this.GetPreviousSceneIndex());
		}

		public virtual void Load(LoadSceneMode mode)
		{
			SceneManager.LoadScene(this.GetPreviousSceneIndex(), mode);
		}
		#endregion
	}
}
