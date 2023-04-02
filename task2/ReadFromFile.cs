using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class ReadFromFile
    {
        public static int[] ReadFromFile1(string filename) 
        {
            int[] numbers; // массив чисел
            using (StreamReader reader = new(filename))
            {
                // Создаем список для хранения чисел
                var numberList = new List<int>();

                // Считываем содержимое файла построчно
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Преобразуем строку с числом в числовой тип данных и добавляем в список
                    int number = int.Parse(line);
                    numberList.Add(number);
                }

                // Преобразуем список в массив
                return numbers = numberList.ToArray();
            }
        }
    }
}
