using DependencyInjectionSample.Repository;
using System.Linq;
using System.Text;

namespace DependencyInjectionSample.Service
{
    public class LogService
    {

        public IScopedLogRepository ScopedLogRepository;
        public ITransientLogRepository TransientLogRepository;
        public ISingletonLogRepository SingletonLogRepository;


        public LogService(IScopedLogRepository scopedLogRepository,
                    ITransientLogRepository transientLogRepository,
                    ISingletonLogRepository singletonLogRepository)
        {
            ScopedLogRepository = scopedLogRepository;
            TransientLogRepository = transientLogRepository;
            SingletonLogRepository = singletonLogRepository;
        }

        public void AddLog(string level, string message)
        {
            ScopedLogRepository.AddLog(level, message);
            TransientLogRepository.AddLog(level, message);
            SingletonLogRepository.AddLog(level, message);
        }


        public string OperationID()
        {
            var str = new StringBuilder();
            str.Append("LogService裡的SingletonLogRepository UUID=" + SingletonLogRepository.OperationId.ToString() + "\n");
            str.Append("LogService裡的ScopedLogRepository UUID=" + ScopedLogRepository.OperationId.ToString() + "\n");
            str.Append("LogService裡的TransientLogRepository UUID=" + TransientLogRepository.OperationId.ToString() + "\n");
            return str.ToString();
        }

        public string QueryLogCount()
        {
            var str = new StringBuilder();
            str.Append("Singleton Log Counts=" + SingletonLogRepository.QueryLogs().Count() + "\n");
            str.Append("Scoped Log Counts=" + ScopedLogRepository.QueryLogs().Count() + "\n");
            str.Append("Transient Log Counts=" + TransientLogRepository.QueryLogs().Count() + "\n");
            return str.ToString();
        }

        public string OperationId(string type)
        {
            if (type == "Singleton")
                return SingletonLogRepository.OperationId.ToString();

            if (type == "Scoped")
                return ScopedLogRepository.OperationId.ToString();

            return TransientLogRepository.OperationId.ToString();
        }
    }
}
