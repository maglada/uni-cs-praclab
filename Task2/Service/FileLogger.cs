namespace Service
{
    public class FileLogger
    {
        private readonly string _filePath = "logPD21.txt";

        public void Subscribe(MessagePublisher publisher)
        {
            publisher.MessageSent += Log;
        }

        private void Log(string message)
        {
            File.AppendAllText(_filePath, $"[{DateTime.Now}] {message}\n");
        }
    }
}
