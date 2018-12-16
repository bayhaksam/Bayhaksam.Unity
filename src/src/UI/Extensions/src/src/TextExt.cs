//-----------------------------------------------------------------------
// <copyright file="TextExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Extensions
{
	using UnityEngine.UI;

	/// <summary>
	/// Extensions for <see cref="Text"/> class.
	/// </summary>
	public static class TextExt
	{
		public static void SetText(this Text source, object value)
		{
			source.text = value.ToString();
		}
	}
}
