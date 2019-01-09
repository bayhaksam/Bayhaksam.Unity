//-----------------------------------------------------------------------
// <copyright file="IMuter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Audio
{
	public interface IMuter
	{
		void Mute();

		void Mute(bool value);

		void UnMute();
	}
}
