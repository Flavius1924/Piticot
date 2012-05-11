using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
using System.IO;

namespace PiticotBusiness.Classes
{
    internal class LoggerClass
    {
        #region Singleton
        private static LoggerClass logger = null;

        private LoggerClass()
        {
            XmlConfigurator.Configure(new FileInfo("config.xml"));
        }

        public static LoggerClass GetInstance()
        {
            if (logger == null) logger = new LoggerClass();
            return logger;
        }

        #endregion

        public void WriteToLog(Object message, Type type, LoggerEnum logger)
        {
            switch (logger)
            {
                case LoggerEnum.Info:
                    LogManager.GetLogger(type).Info(message);
                    break;
                case LoggerEnum.Debug:
                    LogManager.GetLogger(type).Debug(message);
                    break;
                case LoggerEnum.Error:
                    LogManager.GetLogger(type).Error(message);
                    break;
                default:
                    break;
            }
        }
    }
}
