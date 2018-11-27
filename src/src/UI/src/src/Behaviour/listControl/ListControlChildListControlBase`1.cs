//-----------------------------------------------------------------------
// <copyright file="ListControlChildListControlBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;

	public abstract class ListControlChildListControlBase<T> : ListControlBase<T>
		where T : MonoBehaviour, IListControl, IListItemControl
	{
		#region Protected Methods
		protected override void OnAddedListItem(T listItem, object listItemTag)
		{
			listItem.RefreshList();
		}
		#endregion
	}
}
