//-----------------------------------------------------------------------
// <copyright file="IntTextPrinter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public class IntTextPrinter : TextPrinterBase<int>
	{
		#region Public Methods
		/// <inheritdoc/>
		public override void Execute(int value)
		{
			this.Text.text = value.ToString();
		}
		#endregion
	}
}
