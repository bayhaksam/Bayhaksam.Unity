//-----------------------------------------------------------------------
// <copyright file="SetActiveToggler.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Behaviour
{
	using UnityEngine;

	public class SetActiveToggler : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		GameObject go;

		[SerializeField]
		bool isReversed;
		#endregion

		#region Properties
		public bool IsReversed
		{
			get { return this.isReversed; }
			set { this.isReversed = value; }
		}

		public GameObject GameObject
		{
			get
			{
				if (this.go != null)
				{
					return this.go;
				}

				return this.go = this.gameObject;
			}
			set
			{
				this.go = value;
			}
		}
		#endregion

		#region Public Methods
		public void Execute(bool value)
		{
			this.GameObject.SetActive(!this.IsReversed ? value : !value);
		}
		#endregion
	}
}
