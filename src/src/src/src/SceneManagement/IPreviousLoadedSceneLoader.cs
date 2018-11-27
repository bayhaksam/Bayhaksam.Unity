//-----------------------------------------------------------------------
// <copyright file="IPreviousLoadedSceneLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement
{
	using UnityEngine.SceneManagement;

	public interface IPreviousLoadedSceneLoader : IPreviousSceneLoader
	{
		void Load();

		void Load(LoadSceneMode mode);
	}
}
