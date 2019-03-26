//-----------------------------------------------------------------------
// <copyright file="UDateTimePropertyDrawer.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Editor.CustomEditor
{
	using UnityEditor;
	using UnityEngine;

	/// <summary>
	/// Custom <see cref="PropertyDrawer"/> for <see cref="UDateTime"/>.
	/// </summary>
	[CustomPropertyDrawer(typeof(UDateTime))]
	public class UDateTimePropertyDrawer : PropertyDrawer
	{
		#region PropertyDrawer Methods
		/// <inheritdoc/>
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginProperty(position, label, property);
			{
				EditorGUI.PropertyField(position, property.FindPropertyRelative("value"), label);
			}
			EditorGUI.EndProperty();
		}
		#endregion
	}
}
