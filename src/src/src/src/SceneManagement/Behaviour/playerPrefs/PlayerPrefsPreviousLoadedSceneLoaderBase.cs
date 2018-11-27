//-----------------------------------------------------------------------
// <copyright file="PlayerPrefsPreviousLoadedSceneLoaderBase.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement.Behaviour
{
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public abstract class PlayerPrefsPreviousLoadedSceneLoaderBase : MonoBehaviour, IPreviousSceneLoader
	{
		#region Public Constant Fields
		public const string PreviousSceneKey = "PreviousScene";
		#endregion

		#region Unity Methods
		protected virtual void Start()
		{
			SceneManager.sceneUnloaded += this.OnSceneUnloaded;
		}
		#endregion

		#region Public Methods
		public virtual int GetPreviousSceneIndex()
		{
			var sceneIndex = PlayerPrefs.GetInt(PreviousSceneKey, -1);
			if (sceneIndex != -1)
			{
				return sceneIndex;
			}

			sceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
			if (sceneIndex < 0)
			{
				sceneIndex = 0;
			}

			return sceneIndex;
		}
		#endregion

		#region Protected Methods
		protected virtual void Save(int sceneIndex)
		{
			PlayerPrefs.SetInt(PreviousSceneKey, sceneIndex);
			PlayerPrefs.Save();
		}
		#endregion

		#region Methods
		void OnSceneUnloaded(Scene scene)
		{
			this.Save(scene.buildIndex);
		}
		#endregion
	}
}
