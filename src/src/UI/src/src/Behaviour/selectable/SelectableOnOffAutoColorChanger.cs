//-----------------------------------------------------------------------
// <copyright file="SelectableOnOffAutoColorChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;
	using UnityEngine.UI;

	public abstract class SelectableOnOffAutoColorChanger : MonoBehaviour, ISelectableOnOffAutoColorChanger
	{
		#region Unity Fields
		[Header("Target")]
		[SerializeField]
		Toggle toggle;

		[Header("Colors")]
		[SerializeField]
		Color onColor;

		[SerializeField]
		Color offColor;
		#endregion

		#region Properties
		public virtual Color OffColor { get => this.offColor; set => this.offColor = value; }

		public virtual Color OnColor { get => this.onColor; set => this.onColor = value; }

		public virtual Toggle Toggle
		{
			get => this.toggle != null ? this.toggle : (this.toggle = this.GetComponent<Toggle>());
			set => this.toggle = value;
		}
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			this.OnColorChanged(this.Toggle.isOn);
			this.Toggle.onValueChanged.AddListener(this.OnColorChanged);
		}
		#endregion

		#region Public Methods
		#region Abstract Event Handlers
		protected abstract void OnColorChanged(bool isOn);
		#endregion
		#endregion
	}
}
