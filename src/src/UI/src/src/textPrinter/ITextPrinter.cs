//-----------------------------------------------------------------------
// <copyright file="ITextPrinter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI
{
	using UnityEngine.UI;

	public interface ITextPrinter
	{
		#region Properties
		Text Text { get; set; }
		#endregion

		#region Methods
		void Execute();
		#endregion
	}
}
