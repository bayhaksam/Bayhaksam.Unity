//-----------------------------------------------------------------------
// <copyright file="GeneralUI.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using Bayhaksam.Unity.SceneManagement.Behaviour;
	using UnityEngine;

	public class GeneralUI : MonoBehaviour
	{
		#region Public Methods
		public void LoadPreviousScene()
		{
			PlayerPrefsPreviousLoadedSceneLoader.Instance.Load();
		}

		public AsyncOperation LoadPreviousSceneAsync()
		{
			return PlayerPrefsPreviousLoadedAsyncSceneLoader.Instance.LoadAsync();
		}
		#endregion
	}
}
