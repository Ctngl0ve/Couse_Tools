using System.Text;

namespace Задание9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прошу по порядку вести данные о книге- \nВведите наименование: \nВведите автора (ФИО): \nВведите год выпуска: \nВведите количество страниц: ");
            string tire = new String('-', 40); //конструктор 
            try
            {
                string nameBook = Console.ReadLine() ?? "";  //было предупреждение "Разыменование вероятной пустой ссылки", после введение (?? "") все предупреждеиня исчезли, чиатется как "если значение ничего, то заменить на пустую строку
                Format(nameBook);
                nameBook = nameBook.Trim();  
                
                Console.WriteLine($"Ваше значение \"{nameBook}\""); //для проверки правильности вывода, не обязательна

                string nameAuthor = Console.ReadLine() ??"";
                Format(nameAuthor);
                nameAuthor = nameAuthor.Trim(); 
                //string[] nameAuthorArray = nameAuthor.Split(" ");

                //StringBuilder result = new StringBuilder();

                //if (nameAuthor != null) //почему тут он не обрабатывает исключение и вылeтает? 
                //{
                //    foreach (string s in nameAuthorArray)
                //    {
                //        result.Append(char.ToUpper(s[0]) + s.Substring(1) + " ");
                //    }
                //}
                //nameAuthor = result.ToString();

                Console.WriteLine($"Ваше значение \"{nameAuthor}\""); //для проверки правильности вывода, не обязательна

                int yearBook = Convert.ToInt32(Console.ReadLine());
                Argument(yearBook);
                Console.WriteLine($"Ваше значение \"{yearBook}\""); //для проверки правильности вывода, не обязательна

                int yearPages = Convert.ToInt32(Console.ReadLine());
                Argument(yearPages);

                Console.WriteLine($"Ваше значение \"{yearPages}\""); //для проверки правильности вывода, не обязательна


                Console.WriteLine(tire);
                var book1 = new Book(nameBook, nameAuthor, yearBook, yearPages);
                book1.GetInfo();

                Console.WriteLine(tire);

                var book2 = new Book("Преступление и Наказание", "Достаевский");
                book2.GetInfo();

                Console.WriteLine(tire);

                var book3 = new Book(year: 1823, pages: 73); //прописываем не переменную, а нейминг аргумента
                book3.GetInfo();                        //обращение к методу в классе через выбор объекта и точку

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)

            {
                Console.WriteLine("Введите значение");
            }


            static void Format(string ex)
            {
                if (ex == "") // NULL - отсутсвие значение в принципе, а "" - пустая строка имеющая 0 символов....тяжело...
                    throw new FormatException("Введите значение");
            }
            static void Argument(int ex)
            {
                if (ex < 0)
                    throw new ArgumentException("Введите допустимое значение");
            }


        }

    }


    class Book
    {
        private string _title;
        private string _author;

        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title = "По умолчанию", string author = "По умолчанию", int year = 0, int pages = 0) //Ввожу значение по умолчанию
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Информация о книге:\nНаименование книги: {_title}\nАвтор книги (ФИО): {_author}\nГод издания: {Year}\nКоличетсво страниц: {Pages} стр.");
        }
    }
}

