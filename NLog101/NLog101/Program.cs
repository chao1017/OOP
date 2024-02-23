using NLog;

namespace NLog101
{
    internal class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // HACK: NLog.config file should be copied to the output directory
        static void Main(string[] args)
        {
            try
            {
                logger.Debug("Debug message");
                logger.Info("Info message");
                logger.Warn("Warning message");
                logger.Error("Error message");
                logger.Fatal("Fatal error message");
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
