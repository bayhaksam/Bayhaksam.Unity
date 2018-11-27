//-----------------------------------------------------------------------
// <copyright file="SceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement.Behaviour
{
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class SceneLoader : MonoBehaviour, ISceneLoader
	{
		public virtual void Load(int sceneBuildIndex)
		{
			SceneManager.LoadScene(sceneBuildIndex);
		}

		public virtual void Load(int sceneBuildIndex, LoadSceneMode mode)
		{
			SceneManager.LoadScene(sceneBuildIndex, mode);
		}

		public virtual void Load(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}

		public virtual void Load(string sceneName, LoadSceneMode mode)
		{
			SceneManager.LoadScene(sceneName, mode);
		}
	}
}
