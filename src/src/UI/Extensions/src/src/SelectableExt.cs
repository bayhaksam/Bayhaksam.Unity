//-----------------------------------------------------------------------
// <copyright file="SelectableExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Extensions
{
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// Extension class for <see cref="Selectable"/>.
	/// </summary>
	public static class SelectableExt
	{
		public static void InverseInteractable(this Selectable source)
		{
			source.interactable = !source.interactable;
		}

		public static void InverseInteractable(this Selectable source, bool value)
		{
			source.interactable = !value;
		}

		public static void SetColors(
			this Selectable source,
			Color disabledColor,
			Color highlightedColor,
			Color normalColor,
			Color pressedColor)
		{
			var colors = source.colors;
			colors.disabledColor = disabledColor;
			colors.highlightedColor = highlightedColor;
			colors.normalColor = normalColor;
			colors.pressedColor = pressedColor;
			source.colors = colors;
		}

		public static void SetDisabledColor(this Selectable source, Color color)
		{
			var colors = source.colors;
			colors.disabledColor = color;
			source.colors = colors;
		}

		public static void SetHighlightedColor(this Selectable source, Color color)
		{
			var colors = source.colors;
			colors.highlightedColor = color;
			source.colors = colors;
		}

		public static void SetNormalColor(this Selectable source, Color color)
		{
			var colors = source.colors;
			colors.normalColor = color;
			source.colors = colors;
		}

		public static void SetPressedColor(this Selectable source, Color color)
		{
			var colors = source.colors;
			colors.pressedColor = color;
			source.colors = colors;
		}
	}
}
