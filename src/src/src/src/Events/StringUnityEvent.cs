﻿//-----------------------------------------------------------------------
// <copyright file="StringUnityEvent.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Events
{
	using System;
	using UnityEngine.Events;

	[Serializable]
	public class StringUnityEvent : UnityEvent<string>
	{
	}
}
