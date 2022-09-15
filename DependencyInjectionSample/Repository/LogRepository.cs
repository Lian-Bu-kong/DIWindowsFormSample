using System;
using System.Collections.Generic;

namespace DependencyInjectionSample.Repository
{
    public class LogRepository : ISingletonLogRepository
                                ,IScopedLogRepository
                                ,ITransientLogRepository
    {
        // DI 測試觀察物件是否為新物件判定ID
        public Guid OperationId { get; private set; } = Guid.NewGuid();

        // 測試假資料
        public List<LogModel> LogModels { get; private set; } = new List<LogModel>();

        public LogRepository()
        {
            LogModels.Add(new LogModel("Info", "Test log record A"));
            LogModels.Add(new LogModel("Info", "Test log record B"));
        }

        public void AddLog(string level, string content)
        {
            var log = new LogModel(level, content);
            LogModels.Add(log);
        }

        public List<LogModel> QueryLogs()
        {
            return LogModels;
        }


    }
}
