//-----------------------------------------------------------------------
// <copyright file="IPreviousLoadedSceneAsyncLoader.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.SceneManagement
{
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public interface IPreviousLoadedSceneAsyncLoader : IPreviousSceneLoader
	{
		AsyncOperation LoadAsync();

		AsyncOperation LoadAsync(LoadSceneMode mode);
	}
}
