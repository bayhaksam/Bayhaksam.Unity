//-----------------------------------------------------------------------
// <copyright file="ResourcesUtil.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Utils
{
	using System.Linq;
	using UnityEngine;

	/// <summary>
	/// Utility class for <see cref="Resources"/>.
	/// </summary>
	public class ResourcesUtil
	{
		#region Public Methods
		public static Object FindObjectOfType(System.Type type)
			=> Resources.FindObjectsOfTypeAll(type).FirstOrDefault();

		public static T FindObjectOfType<T>() where T : Object => Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
		#endregion
	}
}
