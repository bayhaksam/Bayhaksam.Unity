//-----------------------------------------------------------------------
// <copyright file="AnimationEventBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Animation.Events.Behaviour
{
	using UnityEngine;

	public abstract class AnimationEventBase<T> : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		T target;
		#endregion

		#region Properties
		public virtual T Target
		{
			get
			{
				return this.target != null ? this.target : this.GetComponent<T>();
			}

			set
			{
				this.target = value;
			}
		}
		#endregion
	}
}
