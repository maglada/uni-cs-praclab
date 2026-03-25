using System.IO;
using System.Linq;
using Interface;

namespace Service
{
    public class Module1Service : IModule1
    {
        private readonly string _filePath = "textPD21.txt";
        private readonly string _resultPath = "resultPD21.txt";

        public delegate void TextOperation(string text);

        public void Uppercase(string text)
        {
            File.AppendAllText(_resultPath, "UPPERCASE:\n" + text.ToUpper() + "\n\n");
        }

        public void WordCount(string text)
        {
            int count = text.Split(
                new char[] { ' ', '\n' },
                System.StringSplitOptions.RemoveEmptyEntries
            ).Length;

            File.AppendAllText(_resultPath, "WORD COUNT:\n" + count.ToString() + "\n\n");
        }

        public void SymbolCount(string text)
        {
            File.AppendAllText(_resultPath, "SYMBOL COUNT:\n" + text.Length.ToString() + "\n\n");
        }

        public void ProcessFile(TextOperation operation)
        {
            string text = File.ReadAllText(_filePath);
            operation(text);
        }
    }
}
