﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumnizerLib;

namespace LogExpert.Classes
{
	public class LogExpertNlogWrapper : ILogExpertLogger
	{
		private static readonly NLog.ILogger _logger = NLog.LogManager.GetCurrentClassLogger();

		public void LogDebug(string msg)
		{
			_logger.Debug(msg);
		}

		public void LogError(string msg)
		{
			_logger.Error(msg);
		}

		public void LogInfo(string msg)
		{
			_logger.Error(msg);
		}

		public void LogWarn(string msg)
		{
			_logger.Warn(msg);
		}
	}
}

namespace LogExpert
{
	public static partial class Exten
	{
		public static void Info(this NLog.ILogger logger, string msg)
		{
		}

		public static void logWarn(this NLog.ILogger logger, string msg)
		{
		}

		public static void logWarn(this NLog.ILogger logger, Exception msg)
		{
		}

		public static void logError(this NLog.ILogger logger, string msg)
		{
		}

		public static void logError(this NLog.ILogger logger, Exception msg)
		{
		}

		public static void logDebug(this NLog.ILogger logger, string msg)
		{
		}
	}
}