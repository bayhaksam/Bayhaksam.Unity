//-----------------------------------------------------------------------
// <copyright file="ISelectableOnOffAutoColorChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;
	using UnityEngine.UI;

	public interface ISelectableOnOffAutoColorChanger
	{
		Color OffColor { get; set; }

		Color OnColor { get; set; }

		Toggle Toggle { get; set; }
	}
}
