using Lesson_7.BLL;

namespace Lesson_7_Homework.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string phoneBookLocation = @"C:\Users\mlesy\temp\Lv-724\Lesia_Maiatsaka\Lesson_7\Lesson_7_Homework.CLI\Phones.txt";
            const string copyPath = @"C:\Users\mlesy\temp\Lv-724\Lesia_Maiatsaka\Lesson_7\Lesson_7_Homework.CLI\Phones2.txt";

            var phoneBook = new TextPhoneBook(new StreamReader(phoneBookLocation), new StreamWriter(copyPath));
            phoneBook.CreatePhoneBookEntries(await phoneBook.ReadFromPhoneBookAsync());
            await phoneBook.CopyPhoneBookAsynk();

            Console.WriteLine("name: ");
            var userInput = Console.ReadLine();

            foreach (var item in phoneBook.Entries.Where(e => e.Key.Contains(userInput, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"{item.Key} has number +3{item.Value}");
            }

            Console.ReadKey();
        }
        
    }
}