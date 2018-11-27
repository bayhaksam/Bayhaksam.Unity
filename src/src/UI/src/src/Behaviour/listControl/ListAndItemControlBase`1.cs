//-----------------------------------------------------------------------
// <copyright file="ListAndItemControlBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;

	public abstract class ListAndItemControlBase<T> : ListControlBase<T>, IListItemControl
		where T : MonoBehaviour, IListItemControl
	{
		#region IListItemControl Properties
		public IListControl ListControl { get; set; }

		public int Index { get; set; }

		object IListItemControl.DataSource { get; set; }
		#endregion
	}
}
