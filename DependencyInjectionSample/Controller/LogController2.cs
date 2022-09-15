using DependencyInjectionSample.Repository;

namespace DependencyInjectionSample.Controller
{
    // 模擬第二次注入
    public class LogController2 
    {
        private IScopedLogRepository ScopedLogRepository;
        private ITransientLogRepository TransientLogRepository;
        private ISingletonLogRepository SingletonLogRepository;

        public LogController2(IScopedLogRepository scopedLogRepository,
                    ITransientLogRepository transientLogRepository,
                    ISingletonLogRepository singletonLogRepository)
        {
            ScopedLogRepository = scopedLogRepository;
            TransientLogRepository = transientLogRepository;
            SingletonLogRepository = singletonLogRepository;
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
