//-----------------------------------------------------------------------
// <copyright file="ApplicationVersionPrinter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;

	/// <summary>
	/// Application version printer
	/// </summary>
	public class ApplicationVersionPrinter : TextPrinterBase
	{
		#region Public Methods
		/// <inheritdoc/>
		public override void Execute() => this.Text.text = "v" + Application.version;
		#endregion
	}
}
