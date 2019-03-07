//-----------------------------------------------------------------------
// <copyright file="SelectableExtensions.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour.Extensions
{
	using Bayhaksam.Unity.UI.Extensions;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// Extension behaviour class for <see cref="Selectable"/>.
	/// </summary>
	public class SelectableExtensions : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		Selectable target;
		#endregion

		#region Properties
		public Selectable Target
		{
			get { return this.target; }
			set { this.target = value; }
		}
		#endregion

		#region Unity Methods
		protected virtual void Start()
		{
			this.Target = this.Target != null ? this.Target : this.gameObject.GetComponent<Selectable>();
		}
		#endregion

		#region Public Methods
		public void InverseInteractable() => this.Target.InverseInteractable();

		public void InverseInteractable(bool value) => this.Target.InverseInteractable(value);

		public void InverseInteractable(Selectable target, bool value) => target.InverseInteractable(value);
		#endregion
	}
}
