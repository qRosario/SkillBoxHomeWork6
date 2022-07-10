using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SkillBoxHomeWork6
{
    internal class Program
    {

        static void TextWriter()
        {
            string[] workers = new string[7];

            int count = File.ReadAllLines("d:\\Workers.txt").Length;
            workers[0] = Convert.ToString(count + 1);
            workers[1] = DateTime.Now.ToString("g");
            Console.Write("Введите Ф.И.О сотрудника\n");
            workers[2] = Console.ReadLine();
            Console.Write("Введитие возраст сотрудника\n");
            workers[3] = Console.ReadLine();
            Console.Write("Введите рост сотрудника\n");
            workers[4] = Console.ReadLine();
            Console.Write("Введите дату рождения\n");
            workers[5] = Console.ReadLine();
            Console.Write("Укажите место рождения сотрудника\n");
            workers[6] = Console.ReadLine(); 

            using (StreamWriter writer = new StreamWriter("d:\\Workers.txt", true))
            {     
                writer.WriteLine(string.Join("#", workers));
                writer.Close();
            }

        }
        static void TextReader()
        {
            string oldText = File.ReadAllText("d:\\Workers.txt");
            string[] word = oldText.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var result in word)
            {
                Console.Write(result + " ");
            }

        }
        static void Main(string[] args)
        {
            using (FileStream file = new FileStream("d:\\Workers.txt", FileMode.Append, FileAccess.Write))
                file.Close();
            Console.WriteLine("Введите цифру 1 для вывода данных на экран");
            Console.WriteLine("Введите цифру 2 для добавления данных в файл");
            int result = int.Parse(Console.ReadLine());

            if(result == 1)
            {
                TextReader();
            }
            else if (result == 2)
            {
                TextWriter();
            }
        }
    }
}
