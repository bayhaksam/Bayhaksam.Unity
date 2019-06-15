//-----------------------------------------------------------------------
// <copyright file="SelectableOnOffPressedAutoColorChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public class SelectableOnOffPressedAutoColorChanger : SelectableOnOffAutoColorChanger
	{
		#region Public Methods
		#region Event Handlers
		protected override void OnColorChanged(bool isOn)
		{
			var colors = this.Toggle.colors;
			if (isOn)
			{
				colors.pressedColor = this.OnColor;
			}
			else
			{
				colors.pressedColor = this.OffColor;
			}

			this.Toggle.colors = colors;
		}
		#endregion
		#endregion
	}
}
