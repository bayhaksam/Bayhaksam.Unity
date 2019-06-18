//-----------------------------------------------------------------------
// <copyright file="debug.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Logging
{
	using Bayhaksam.Extensions;
	using UnityEngine;

	/// <summary>
	///	Debug class for unity logs.
	/// </summary>
	public class debug
	{
		#region Properties
		public static bool IsContextInfoWillBePrinted { get; set; }
		#endregion

		#region Public Methods
		/// <summary>
		///		<para>Logs message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		public static void Log(object message)
		{
			Debug.Log(message.ToString().AppendNewLineEnd());
		}

		/// <summary>
		///		<para>Logs message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		/// <param name="context">Context</param>
		public static void Log(object message, Object context)
		{
			Debug.Log(PrintMessage(message.ToString(), context), context);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		public static void LogError(object message)
		{
			Debug.LogError(message.ToString().AppendNewLineEnd());
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		/// <param name="context">Context</param>
		public static void LogError(object message, Object context)
		{
			Debug.LogError(PrintMessage(message.ToString(), context), context);
		}

		/// <summary>
		///		<para>Logs a formatted error message to the Unity console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogErrorFormat(string format, params object[] args)
		{
			Debug.LogError(string.Format(format, args).AppendNewLineEnd());
		}

		/// <summary>
		///		<para>Logs a formatted error message to the Unity console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			Debug.LogError(PrintMessage(string.Format(format, args), context), context);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="exception">Exception</param>
		public static void LogException(System.Exception exception)
		{
			Debug.LogException(exception);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="exception">Exception</param>
		/// <param name="context">Context</param>
		public static void LogException(System.Exception exception, Object context)
		{
			Debug.LogException(exception, context);
		}

		/// <summary>
		///		<para>Logs a formatted message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogFormat(string format, params object[] args)
		{
			Debug.Log(string.Format(format, args).AppendNewLineEnd());
		}

		/// <summary>
		///		<para>Logs a formatted message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogFormat(Object context, string format, params object[] args)
		{
			Debug.Log(PrintMessage(string.Format(format, args), context), context);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs a warning message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		public static void LogWarning(object message)
		{
			Debug.LogWarning(message);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs a warning message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		/// <param name="context">Context</param>
		public static void LogWarning(object message, Object context)
		{
			Debug.LogWarning(PrintMessage(message.ToString(), context), context);
		}

		/// <summary>
		///		<para>Logs a formatted warning message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogWarningFormat(string format, params object[] args)
		{
			Debug.LogWarning(string.Format(format, args).AppendNewLineEnd());
		}

		/// <summary>
		///		<para>Logs a formatted warning message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			Debug.LogWarning(PrintMessage(string.Format(format, args), context), context);
		}
		#endregion

		#region Methods
		static string PrintMessage(string message, Object context)
		{
			return !IsContextInfoWillBePrinted
				? message.AppendNewLineEnd()
				: message.AppendNewLineEnd().AppendNewLineEnd() + "ContextName: " + context.name.AppendNewLineEnd();
		}
		#endregion
	}
}
