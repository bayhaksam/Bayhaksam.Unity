//-----------------------------------------------------------------------
// <copyright file="DontDestroyObject.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;

	/// <summary>
	/// Makes the object not be destroyed automatically when loading a new scene.
	/// </summary>
	public class DontDestroyObject : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		bool isDontDestroy = true;
		#endregion

		#region Protected Properties
		/// <summary>
		/// Gets or sets a value indicating whether the object will be destroyed.
		/// </summary>
		protected bool IsDontDestroy { get => this.isDontDestroy; set => this.isDontDestroy = value; }
		#endregion

		#region Unity Methods
		/// <inheritdoc/>
		protected virtual void Awake()
		{
			if (this.IsDontDestroy)
			{
				DontDestroyOnLoad(this.gameObject);
			}
		}
		#endregion
	}
}
