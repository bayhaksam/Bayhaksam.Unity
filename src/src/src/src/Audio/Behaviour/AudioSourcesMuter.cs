//-----------------------------------------------------------------------
// <copyright file="AudioSourcesMuter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Audio.Behaviour
{
	using UnityEngine;

	public class AudioSourcesMuter : MonoBehaviour, IMuter
	{
		/// <inheritdoc/>
		public virtual void Mute()
		{
			this.Mute(true);
		}

		/// <inheritdoc/>
		public virtual void Mute(bool value)
		{
			foreach (var obj in Resources.FindObjectsOfTypeAll<AudioSource>())
			{
				obj.mute = value;
			}
		}

		/// <inheritdoc/>
		public virtual void UnMute()
		{
			this.Mute(false);
		}
	}
}
