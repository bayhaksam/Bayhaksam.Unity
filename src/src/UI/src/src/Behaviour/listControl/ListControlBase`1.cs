//-----------------------------------------------------------------------
// <copyright file="ListControlBase`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using System.Collections.Generic;
	using UnityEngine;

	public abstract class ListControlBase<T> : MonoBehaviour, IListControl where T : MonoBehaviour, IListItemControl
	{
		#region Fields
		#region Unity Fields
		[Header("List")]
		[SerializeField]
		GameObject listItemTemplate;

		[SerializeField]
		Transform content;
		#endregion
		#endregion

		#region Properties
		#region IListControl Properties
		public object DataSource { get; set; }
		#endregion

		public List<T> List { get; } = new List<T>();
		#endregion

		#region Protected Properties
		protected GameObject ListItemTemplate
		{
			get { return this.listItemTemplate; }
			set { this.listItemTemplate = value; }
		}

		protected Transform Content
		{
			get
			{
				return this.content != null ? this.content : this.transform;
			}

			set
			{
				this.content = value;
			}
		}
		#endregion

		#region Indexers
		public T this[int index]
		{
			get { return this.List[index]; }
			set { this.List[index] = value; }
		}
		#endregion

		#region IListControl Methods
		public virtual void ClearList()
		{
			foreach (var item in this.List)
			{
				Destroy(item.gameObject);
			}

			this.List.Clear();
		}

		public virtual void RefreshList()
		{
			this.ClearList();
			this.OnRefreshingList();
		}
		#endregion

		#region Protected Methods
		protected abstract void OnRefreshingList();

		protected virtual void OnAddedListItem(T listItem, object listItemTag)
		{
		}

		protected virtual void OnAddingListItem(T listItem, object listItemTag)
		{
		}

		protected virtual GameObject OnAddingNewListItemAt(int index, object listItemTag)
		{
			var listItemGo = Instantiate(this.ListItemTemplate);
			listItemGo.SetActive(true);
			listItemGo.transform.SetParent(this.Content, false);

			var listItem = listItemGo.GetComponent<T>();
			listItem.ListControl = this;
			listItem.Index = index;
			this.OnAddingListItem(listItem, listItemTag);
			this.List.Add(listItem);
			this.OnAddedListItem(listItem, listItemTag);

			return listItemGo;
		}
		#endregion
	}
}
