//-----------------------------------------------------------------------
// <copyright file="IListControl.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	public interface IListControl
	{
		#region Properties
		object DataSource { get; set; }
		#endregion

		#region Methods
		void ClearList();

		void RefreshList();
		#endregion
	}
}
