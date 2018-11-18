//-----------------------------------------------------------------------
// <copyright file="UnityDebugTraceListener.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Log
{
	using System;
	using UnityEngine;

	/// <summary>
	/// It is a
	///		<see href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.tracelistener">
	///			System.Diagnostics.TraceListener</see>
	///		for <see href="http://unity3d.com/">
	///			Unity3D</see>.
	/// It will put your log to
	///		<see href="http://unity3d.com/">
	///			Unity3D</see>
	///		console when you call
	///		<see cref="System.Diagnostics.Trace.Write(string)"/>
	///		/
	///		<see cref="System.Diagnostics.Trace.WriteLine(string)"/>
	///		or
	///		<see cref="System.Diagnostics.Debug.Write(string)"/>
	///		/
	///		<see cref="System.Diagnostics.Debug.WriteLine(string)"/>.
	/// </summary>
	/// <example>The following is an example of initializing a
	///		<c>UnityDebugTraceListener</c>.
	///		<code>
	///			#if TRACE || DEBUG
	///					System.Diagnostics.Trace.Listeners.Add(Bayhaksam.Unity.Log.UnityDebugTraceListener.Instance);
	///			#endif
	///		</code>
	///	</example>
	public class UnityDebugTraceListener : System.Diagnostics.TraceListener
	{
		#region Static Fields
		/// <summary>
		/// Stores value for lazy initialization.
		/// </summary>
		static readonly Lazy<UnityDebugTraceListener> lazyInstance
			= new Lazy<UnityDebugTraceListener>(() => new UnityDebugTraceListener());
		#endregion

		#region Constructors
		/// <summary>
		/// Prevents a default instance of the <see cref="UnityDebugTraceListener"/> class from being created.
		/// </summary>
		private UnityDebugTraceListener()
		{
		}
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static UnityDebugTraceListener Instance => lazyInstance.Value;
		#endregion

		#region Public Methods
		/// <summary>
		/// Don' t call directly. Called after
		///		<see cref="System.Diagnostics.Trace.Write(string)"/>
		///		or
		///		<see cref="System.Diagnostics.Debug.Write(string)"/>
		///		method.
		/// </summary>
		/// <param name="message">Message</param>
		public override void Write(string message)
		{
			Debug.Log(string.Format(message));
		}

		/// <summary>
		/// Don' t call directly. Called after
		///		<see cref="System.Diagnostics.Trace.WriteLine(string)"/>
		///		or
		///		<see cref="System.Diagnostics.Debug.WriteLine(string)"/>
		///		method.
		/// </summary>
		/// <param name="message">Message</param>
		public override void WriteLine(string message)
		{
			Debug.Log(string.Format(message));
		}
		#endregion
	}
}
