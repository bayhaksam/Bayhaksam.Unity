//-----------------------------------------------------------------------
// <copyright file="UDateTime.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity
{
	using Bayhaksam.Extensions;
	using System;
	using UnityEngine;

	/// <summary>
	/// Serializable <see cref="DateTime"/> type for Unity.
	/// </summary>
	[Serializable]
	public class UDateTime : ISerializationCallbackReceiver
	{
		#region Unity Fields
		[SerializeField]
		string value;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="UDateTime"/> class.
		/// </summary>
		public UDateTime()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UDateTime"/> class.
		/// </summary>
		/// <param name="value">The <see cref="DateTime"/> value.</param>
		public UDateTime(DateTime value)
		{
			this.Value = value;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the <see cref="DateTime"/> value.
		/// </summary>
		public DateTime Value { get; set; }
		#endregion

		#region ISerializationCallbackReceiver Methods
		/// <inheritdoc/>
		public void OnAfterDeserialize()
		{
			this.Value = DateTime.ParseExact(this.value, "yyyyMMddHHmmssfffffff", null);
		}

		/// <inheritdoc/>
		public void OnBeforeSerialize() => this.value = this.Value.ToLongTimeStampString();
		#endregion

		#region object Methods
		/// <inheritdoc/>
		public override string ToString() => this.Value.ToString();
		#endregion

		#region Method Overloads
		public static implicit operator DateTime(UDateTime value) => value.Value;

		public static implicit operator UDateTime(DateTime value) => new UDateTime(value);
		#endregion
	}
}
