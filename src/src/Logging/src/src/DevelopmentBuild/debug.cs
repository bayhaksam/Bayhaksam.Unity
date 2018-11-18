//-----------------------------------------------------------------------
// <copyright file="debug.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Logging.DevelopmentBuild
{
	using UnityEngine;

	/// <summary>
	///	Debug class to log only for development builds.
	/// </summary>
	public class debug
	{
		#region Fields
		/// <summary>
		///		<see href="http://unity3d.com/">
		///			Unity3D</see>
		///		editor directive
		///		<seealso href="http://docs.unity3d.com/Manual/PlatformDependentCompilation.html"/>
		/// </summary>
		const string UnityEditor = "UNITY_EDITOR";

		/// <summary>
		///		<see href="http://unity3d.com/">
		///			Unity3D</see>
		///		' s development build directive
		///		<seealso href="http://docs.unity3d.com/Manual/PlatformDependentCompilation.html"/>
		/// </summary>
		const string DevelopmentBuild = "DEVELOPMENT_BUILD";
		#endregion

		#region Public Static Methods
		/// <summary>
		///		<para>Logs message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void Log(object message)
		{
			Debug.Log(message);
		}

		/// <summary>
		///		<para>Logs message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		/// <param name="context">Context</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void Log(object message, Object context)
		{
			Debug.Log(message, context);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogError(object message)
		{
			Debug.LogError(message);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		/// <param name="context">Context</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogError(object message, Object context)
		{
			Debug.LogError(message, context);
		}

		/// <summary>
		///		<para>Logs a formatted error message to the Unity console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogErrorFormat(string format, params object[] args)
		{
			Debug.LogErrorFormat(format, args);
		}

		/// <summary>
		///		<para>Logs a formatted error message to the Unity console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			Debug.LogErrorFormat(context, format, args);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs an error message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="exception">Exception</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
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
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
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
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogFormat(string format, params object[] args)
		{
			Debug.LogFormat(format, args);
		}

		/// <summary>
		///		<para>Logs a formatted message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogFormat(Object context, string format, params object[] args)
		{
			Debug.LogFormat(context, format, args);
		}

		/// <summary>
		///		<para>A variant of Debug.Log that logs a warning message to the console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="message">Message</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
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
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogWarning(object message, Object context)
		{
			Debug.LogWarning(message, context);
		}

		/// <summary>
		///		<para>Logs a formatted warning message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogWarningFormat(string format, params object[] args)
		{
			Debug.LogWarningFormat(format, args);
		}

		/// <summary>
		///		<para>Logs a formatted warning message to the Unity Console.</para>
		///		<para>System.Diagnostics.Conditional:
		///			<b>UNITY_EDITOR || DEVELOPMENT_BUILD</b></para>
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="format">Format</param>
		/// <param name="args">Arguments</param>
		[System.Diagnostics.Conditional(UnityEditor),
			System.Diagnostics.Conditional(DevelopmentBuild)]
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			Debug.LogWarningFormat(context, format, args);
		}
		#endregion
	}
}
