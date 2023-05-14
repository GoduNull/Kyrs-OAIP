using System;
using System.IO;
using System.Text;

namespace searchpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text;
            string Patt;
            bool rezult = false;
            string files = "content.txt";
            Console.WriteLine("ВВедите текст");
            Text = Console.ReadLine();
            Console.WriteLine("ВВедите подстроку");
            Patt = Console.ReadLine();
            //Алгоритм поиска подстроки
            for (int i = 0; i < Text.Length - Patt.Length + 1; i++)
            {
                int j = 0;
                while (j < Patt.Length && Text[i + j] == Patt[j])
                {
                    j++;
                }
                if (j == Patt.Length)
                {
                    //Алгоритм записи данных поиска
                    rezult=true;
                    File.AppendAllTextAsync(files, $"\nВ тексте {Text} искали подстроку {Patt}", Encoding.Unicode);
                    Console.WriteLine("Подстрока входит в строку с позиции: " + i);
                }
            }
            if(rezult==false)
            {
                Console.WriteLine("Нет совпадений");
            }
            //Алгоритм чтения данных поиска
            string Textfile = File.ReadAllText(files);
            Console.WriteLine(Textfile);
            Console.ReadKey();
        }
    }
}
