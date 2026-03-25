using Service;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new MessagePublisher();
            var logger = new FileLogger();

            logger.Subscribe(publisher);

            File.WriteAllText("logPD21.txt", "");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter a message: ");
                string message = Console.ReadLine()!;
                publisher.Send(message);
            }

            Console.WriteLine("Done! Results written to logPD21.txt");
            Console.WriteLine(File.ReadAllText("logPD21.txt"));
        }
    }
}
