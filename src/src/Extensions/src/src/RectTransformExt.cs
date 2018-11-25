//-----------------------------------------------------------------------
// <copyright file="RectTransformExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Extensions
{
	using UnityEngine;

	/// <summary>
	/// <see cref="RectTransform"/>' s extension class
	/// </summary>
	public static class RectTransformExt
	{
		public static void SetRectTransform(this RectTransform source, RectTransform transform)
		{
			source.sizeDelta = transform.sizeDelta;
			source.localScale = transform.localScale;
			source.localPosition = transform.localPosition;
			source.anchoredPosition = transform.anchoredPosition;
			source.anchorMin = transform.anchorMin;
			source.anchorMax = transform.anchorMax;
			source.eulerAngles = transform.eulerAngles;
			source.offsetMin = transform.offsetMin;
			source.offsetMax = transform.offsetMax;
			source.pivot = transform.pivot;
		}
	}
}
