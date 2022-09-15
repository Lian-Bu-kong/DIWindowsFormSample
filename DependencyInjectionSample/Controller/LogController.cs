using DependencyInjectionSample.Repository;
using DependencyInjectionSample.Service;
using System;
using System.Linq;
using System.Text;

namespace DependencyInjectionSample.Controller
{
    public class LogController 
    {
        public Guid GUID { get; private set; } = Guid.NewGuid();

        public LogService LogService;
        public IScopedLogRepository ScopedLogRepository;
        public ITransientLogRepository TransientLogRepository;
        public ISingletonLogRepository SingletonLogRepository;

        public LogController(LogService logService
                    , IScopedLogRepository scopedLogRepository
                    , ITransientLogRepository transientLogRepository
                    , ISingletonLogRepository singletonLogRepository)
        {
            LogService = logService; 
            ScopedLogRepository = scopedLogRepository;
            TransientLogRepository = transientLogRepository;
            SingletonLogRepository = singletonLogRepository;
        }

        public string QueryLogCount()
        {
            var str = new StringBuilder();
            str.Append("Singleton Log Counts=" + SingletonLogRepository.QueryLogs().Count() + "\n");
            str.Append("Scoped Log Counts=" + ScopedLogRepository.QueryLogs().Count() + "\n");
            str.Append("Transient Log Counts=" + TransientLogRepository.QueryLogs().Count() + "\n");
            return str.ToString();
        }

        public string OperationID()
        {
            var str = new StringBuilder();
            str.Append("LogController 物件裡的SingletonLogRepository UUID=" + SingletonLogRepository.OperationId.ToString() + "\n");
            str.Append("LogController 物件裡的ScopedLogRepository UUID=" + ScopedLogRepository.OperationId.ToString() + "\n");
            str.Append("LogController 物件裡的TransientLogRepository UUID=" + TransientLogRepository.OperationId.ToString() + "\n");
            return str.ToString();
        }

        public void AddLog(string level, string message)
        {
            ScopedLogRepository.AddLog(level, message);
            TransientLogRepository.AddLog(level,message);
            SingletonLogRepository.AddLog(level, message);    
        }

        public string ServiceLevelOperationID()
        {
            return LogService.OperationID();
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
