using System;
using NLog;

namespace Data
{
    public static class StaticNLog
    {
        private static Logger logger;

        static StaticNLog()
        {
            logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();            
        }
        
        public static void GerarLogInfo(string log)
        {
            try
            {
                logger.Debug(log);                        
            }
            catch (Exception exception)
            {                        
                logger.Error(exception, "ALGUMA EXCEÇÃO ACONTECEU E NÃO FOI POSSIVEL GERAR LOG.");
                throw;
            }
        }

        public static void GerarLogSucesso(string log)
        {
            logger.Info(log);
        }
    }
}