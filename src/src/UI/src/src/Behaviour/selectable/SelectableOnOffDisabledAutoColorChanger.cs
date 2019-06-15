//-----------------------------------------------------------------------
// <copyright file="SelectableOnOffDisabledAutoColorChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public class SelectableOnOffDisabledAutoColorChanger : SelectableOnOffAutoColorChanger
	{
		#region Public Methods
		#region Event Handlers
		protected override void OnColorChanged(bool isOn)
		{
			var colors = this.Toggle.colors;
			if (isOn)
			{
				colors.disabledColor = this.OnColor;
			}
			else
			{
				colors.disabledColor = this.OffColor;
			}

			this.Toggle.colors = colors;
		}
		#endregion
		#endregion
	}
}
