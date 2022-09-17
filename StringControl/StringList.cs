using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringControl
{
    internal class StringList
    {
        public string?[] strings = new string[100];

        public StringList()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Input String: ");
                strings[i] = Console.ReadLine();
            }
        }

        // Рандомная генерация строк
        public StringList(string rand)
        {
            if (rand == "random")
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    strings[i] = AutoGeneration.Generation();
                }
            }
        }

        public int Insert(string str)
        {
            string?[] newStrings = new string[strings.Length + 1];

            for (int i = 0; i < strings.Length; i++)
                newStrings[i] = strings[i];

            newStrings[newStrings.Length - 1] = str;
            strings = newStrings;
            return strings.Length;
        }

        public void Delete(int index)
        {
            try
            {
                strings[index] = null;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

                // Цикличный ввод index (до отсутствия ошибок)
                while (int.TryParse(Console.ReadLine(), out index) == false)
                {
                    Console.WriteLine("Incorrect symbol. Input index again: ");
                    if (int.TryParse(Console.ReadLine(), out index))
                        break;
                }
                Delete(index);
            }
        }

        public void Update(int index, string str)
        {
            try
            {
                strings[index] = str;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                // Цикличный ввод index (до отсутствия ошибок)
                while (int.TryParse(Console.ReadLine(), out index) == false)
                {
                    Console.WriteLine("Incorrect symbol. Input index again: ");
                    if (int.TryParse(Console.ReadLine(), out index))
                        break;
                }
                Update(index, str);
            }
        }

        public string GetAt(int index)
        {
            try
            {
                return strings[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                // Цикличный ввод index (до отсутствия ошибок)
                while (int.TryParse(Console.ReadLine(), out index) == false)
                {
                    Console.WriteLine("Incorrect symbol. Input index again: ");
                    if (int.TryParse(Console.ReadLine(), out index))
                        break;
                }
                return strings[index];
            } 
        }
    }
}
