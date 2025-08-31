namespace Задание6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение (слова, разделенные собой пробелом), Прошу не использовать знаки препинания: ");
            string pol = Console.ReadLine();
            int dlina = 0;
            string stroka = " ";
            for (int i = 0; i < pol.Length; i++) // цикл для каждого и (когда меньше длины переменной, которую ввел пользователь) выполняется очистка от спецзнаков
            {
                pol = pol.Replace(",", "");
                pol = pol.Replace(".", "");
                pol = pol.Replace("?", "");
                pol = pol.Replace("!", "");
                pol = pol.Replace("\"", "");
                pol = pol.Replace("$", "");
                pol = pol.Replace("^", "");
                pol = pol.Replace("&", "");
                pol = pol.Replace("(", "");
                pol = pol.Replace(")", "");
                pol = pol.Replace("-", "");
                pol = pol.Replace("_", "");
            }
            for (int i = 0; i < pol.Length; i++) // замена пробелов двойных на одинарный, хотя эту часть можно было добавить в верхний цикл
            {
                pol = pol.Replace("  ", " ");
            }
            pol = pol.Trim(); // удаление начального и конечного пробела
            //Console.WriteLine($"Ваше предложение: {pol}");
            string[] massiv = pol.Split(' '); //деление строки со словами на массив слов 
            foreach (string s in massiv) // проходит каждую строку в массиве 
            {
                if (s.Length > dlina) // если длина строки в массиве больше длины (длина = 0), то
                {
                    dlina = s.Length; // длина = длина строки в массиве 
                    stroka = s; //а это строка будет записана в переменную
                }
            }
            Console.WriteLine($"Самое длинное слово: {stroka} \nЕго длина: {dlina}");
            Console.ReadKey();
        }
    }
}
