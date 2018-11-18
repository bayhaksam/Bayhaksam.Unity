//-----------------------------------------------------------------------
// <copyright file="ObjectExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Extensions
{
	using UnityEngine;

	/// <summary>
	///		<see cref="Object"/>' s extension class
	/// </summary>
	public static class ObjectExt
	{
		/// <summary>
		///		<para>Logs message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="message">Message</param>
		public static void Log(this Object source, object message)
		{
			Debug.Log(message, source);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="message">Message</param>
		public static void LogError(this Object source, object message)
		{
			Debug.LogError(message, source);
		}

		/// <summary>
		///		<para>Logs a formatted error message to the Unity console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogErrorFormat(this Object source, string format, params object[] args)
		{
			Debug.LogErrorFormat(source, format, args);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="exception">Exception</param>
		public static void LogException(this Object source, System.Exception exception)
		{
			Debug.LogException(exception, source);
		}

		/// <summary>
		///		<para>Logs a formatted message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogFormat(this Object source, string format, params object[] args)
		{
			Debug.LogFormat(source, format, args);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs a warning message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="message">Message</param>
		public static void LogWarning(this Object source, object message)
		{
			Debug.LogWarning(message, source);
		}

		/// <summary>
		///		<para>Logs a formatted warning message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="source">The source</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogWarningFormat(this Object source, string format, params object[] args)
		{
			Debug.LogWarningFormat(source, format, args);
		}
	}
}
