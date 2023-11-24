using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.KarpenkoNA.Sprint5.Task4.V15.Lib;

namespace Tyuiu.KarpenkoNA.Sprint5.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Карпенко Н. А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Карпенко Никита Андреевич | АСОиУБ-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt (файл взять из         *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть вещественное значение.         *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле. Вычислить  *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх              *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V15.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
