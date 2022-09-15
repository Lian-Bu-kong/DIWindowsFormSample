namespace DependencyInjectionSample.Repository
{
    public class LogModel
    {
        /// <summary>
        /// Log level : Debug, Error, Alarm, Info
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Log content
        /// </summary>
        public string Content { get; set; }

        public LogModel(string level, string content)
        {
            Level = level;
            Content = content;
        }
    } 
}
