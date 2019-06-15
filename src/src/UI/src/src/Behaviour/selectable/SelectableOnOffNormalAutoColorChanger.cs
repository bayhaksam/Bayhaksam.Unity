//-----------------------------------------------------------------------
// <copyright file="SelectableOnOffNormalAutoColorChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public class SelectableOnOffNormalAutoColorChanger : SelectableOnOffAutoColorChanger
	{
		#region Public Methods
		#region Event Handlers
		protected override void OnColorChanged(bool isOn)
		{
			var colors = this.Toggle.colors;
			if (isOn)
			{
				colors.normalColor = this.OnColor;
			}
			else
			{
				colors.normalColor = this.OffColor;
			}

			this.Toggle.colors = colors;
		}
		#endregion
		#endregion
	}
}
