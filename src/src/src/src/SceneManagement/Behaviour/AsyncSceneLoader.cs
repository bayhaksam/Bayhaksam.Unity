//-----------------------------------------------------------------------
// <copyright file="AsyncSceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement.Behaviour
{
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class AsyncSceneLoader : MonoBehaviour, ISceneLoader
	{
		public virtual void Load(int sceneBuildIndex)
		{
			SceneManager.LoadSceneAsync(sceneBuildIndex);
		}

		public virtual void Load(int sceneBuildIndex, LoadSceneMode mode)
		{
			SceneManager.LoadSceneAsync(sceneBuildIndex, mode);
		}

		public virtual void Load(string sceneName)
		{
			SceneManager.LoadSceneAsync(sceneName);
		}

		public virtual void Load(string sceneName, LoadSceneMode mode)
		{
			SceneManager.LoadSceneAsync(sceneName, mode);
		}
	}
}
