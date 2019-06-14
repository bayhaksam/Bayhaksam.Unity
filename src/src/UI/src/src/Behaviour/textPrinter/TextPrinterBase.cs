//-----------------------------------------------------------------------
// <copyright file="TextPrinterBase.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;
	using UnityEngine.UI;

	public abstract class TextPrinterBase : MonoBehaviour, ITextPrinter
	{
		#region Unity Fields
		[SerializeField]
		Text text;
		#endregion

		#region Properties
		/// <inheritdoc/>
		public virtual Text Text
		{
			get { return this.text; }
			set { this.text = value; }
		}
		#endregion

		#region Public Methods
		/// <inheritdoc/>
		public abstract void Execute();
		#endregion
	}
}
