//-----------------------------------------------------------------------
// <copyright file="ITextPrinter`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI
{
	using UnityEngine.UI;

	public interface ITextPrinter<in T>
	{
		#region Properties
		Text Text { get; set; }
		#endregion

		#region Methods
		void Execute(T value);
		#endregion
	}
}
