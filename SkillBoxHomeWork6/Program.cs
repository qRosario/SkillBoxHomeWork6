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
            workers[0] = Convert.ToString(count);
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
            
            string line = File.ReadAllText("d:\\Workers.txt");
            char[] charToTrim = {'#'};
            string result = line.Trim(charToTrim);
            Console.Write(result);
  
        }
        static void Main(string[] args)
        {
            TextReader();
        }
    }
}
