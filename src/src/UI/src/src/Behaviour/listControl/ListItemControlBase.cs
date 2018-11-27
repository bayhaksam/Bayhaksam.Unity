//-----------------------------------------------------------------------
// <copyright file="ListItemControlBase.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;

	public abstract class ListItemControlBase : MonoBehaviour, IListItemControl
	{
		public IListControl ListControl { get; set; }

		public int Index { get; set; }

		public object DataSource { get; set; }
	}
}
