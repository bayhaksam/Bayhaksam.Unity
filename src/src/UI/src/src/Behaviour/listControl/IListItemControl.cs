//-----------------------------------------------------------------------
// <copyright file="IListItemControl.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public interface IListItemControl
	{
		IListControl ListControl { get; set; }

		int Index { get; set; }

		object DataSource { get; set; }
	}
}
