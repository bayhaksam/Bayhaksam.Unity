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
		GameObject target;

		[SerializeField]
		bool isReversed;
		#endregion

		#region Properties
		public bool IsReversed
		{
			get { return this.isReversed; }
			set { this.isReversed = value; }
		}

		public GameObject Target
		{
			get
			{
				if (this.target != null)
				{
					return this.target;
				}

				return this.target = this.gameObject;
			}
			set
			{
				this.target = value;
			}
		}
		#endregion

		#region Public Methods
		public void Execute(bool value)
		{
			this.Target.SetActive(!this.IsReversed ? value : !value);
		}
		#endregion
	}
}
