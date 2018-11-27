//-----------------------------------------------------------------------
// <copyright file="ISceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement
{
	using UnityEngine.SceneManagement;

	public interface ISceneLoader
	{
		void Load(int sceneBuildIndex);

		void Load(int sceneBuildIndex, LoadSceneMode mode);

		void Load(string sceneName);

		void Load(string sceneName, LoadSceneMode mode);
	}
}
