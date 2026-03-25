using System;
using System.IO;
using Service;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Користувач вводить текст у консоль 4 рази і після кожного введеного рядка цей текст
  логується у файл logPD2X.txt.
  Потрібно:
  ● Створити клас MessagePublisher з:
  ○ event для повідомлення про відправку меседжа
  ○ метод Send(string message), який викликає event
  ● Створити клас FileLogger який:
  ○ підписується на event
  ○ при спрацюванні event записує повідомлення у файл logPD2X.txt
  ■ Формат запису: [час] повідомлення*/

            var service = new Module1Service();

            File.WriteAllText("resultPD21.txt", "");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter a message: ");
                string message = Console.ReadLine();
                service.Send(message);
            }

            Console.WriteLine("Done! Results written to resultPD21.txt");
            Console.WriteLine(File.ReadAllText("resultPD21.txt"));
        }
    }
}
