//-----------------------------------------------------------------------
// <copyright file="TextPrinterBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;
	using UnityEngine.UI;

	public abstract class TextPrinterBase<T> : MonoBehaviour, ITextPrinter<T>
	{
		#region Unity Fields
		[SerializeField]
		Text text;
		#endregion

		#region Properties
		public virtual Text Text
		{
			get { return this.text; }
			set { this.text = value; }
		}
		#endregion

		#region Public Methods
		public abstract void Execute(T value);
		#endregion
	}
}
