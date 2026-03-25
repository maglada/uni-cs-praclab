using System.IO;
using System.Linq;
using Interface;

namespace Service
{
    public class Module1Service : IModule1
    {
        private readonly string _filePath = "logPD21.txt";

        public event Action MessageSent;

        public void Send(string message)
        {
            MessageSent?.Invoke();
            File.AppendAllText(_filePath, $"[{DateTime.Now}] {message}\n");
        }
    }
}
