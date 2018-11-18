//-----------------------------------------------------------------------
// <copyright file="debug.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Logging.DevelopmentBuild
{
	using UnityEngine;
	using releaseDebug = Logging.debug;

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
			releaseDebug.Log(message);
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
			releaseDebug.Log(message, context);
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
			releaseDebug.LogError(message);
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
			releaseDebug.LogError(message, context);
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
			releaseDebug.LogErrorFormat(format, args);
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
			releaseDebug.LogErrorFormat(context, format, args);
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
			releaseDebug.LogException(exception);
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
			releaseDebug.LogException(exception, context);
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
			releaseDebug.LogFormat(format, args);
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
			releaseDebug.LogFormat(context, format, args);
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
			releaseDebug.LogWarning(message);
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
			releaseDebug.LogWarning(message, context);
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
			releaseDebug.LogWarningFormat(format, args);
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
			releaseDebug.LogWarningFormat(context, format, args);
		}
		#endregion
	}
}
