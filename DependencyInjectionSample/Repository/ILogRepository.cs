using System;
using System.Collections.Generic;

namespace DependencyInjectionSample.Repository
{
    public interface ILogRepository
    {
        // DI Demo 使用，辨別注入方法Id變化
        Guid OperationId { get; }

        List<LogModel> QueryLogs();

        void AddLog(string level, string content);

    }
}
