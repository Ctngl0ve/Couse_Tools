using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Задание12_1
{
    //Тяжко все вспоминать спустя 2 недели
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1000", "Чичивичный.том1", 1389,"Вольдемар"),
                new Book<string, int>("F-1234", "Чичивичный.том4", 2050, "Вольдемар")
            };

            Book<int, string>[] books2 = new Book<int, string>[]
            {
               new Book<int, string> (10, "Кекерев.том1", "1911-1955", "Уганда"),
               new Book<int, string> (42, "Кекерев.том5", "1970-2000", "Уганда")
            };

            Book<string, int> book1 = FindBook<string, int>(books1, "F-1234");
            Console.WriteLine(book1?.ToString() ?? "Не найдено");

            Book<int, string> book2 = FindBook<int, string>(books2, 42);
            Console.WriteLine(book2?.ToString() ?? "Не найдено");



            PaperElements[] element = new PaperElements[]
            {
                new Book<string, int>("F-1000", "Чичивичный.том1", 1389,"Вольдемар"),
                new Notebook<int> ("Тетрадь", "Юлиан", 24, 001)
            };
            foreach (PaperElements paperElements in element)
            {
                paperElements.Type();
            }
            Console.ReadKey();

        }
        static Book<T, U> FindBook<T, U>(Book<T, U>[] book, T code)
        {
            foreach (Book<T, U> books in book)
            {
                if (books.Code.Equals(code))
                {
                    return books;
                }
            }
            return null;
        }
    }
    interface PaperElements //Ради интереса и для практики
    {
        public void Type();
    }
    class Book<T, U> : PaperElements
    {
        private U _publicationYear;
        public string Name = "Book";

        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear
        {
            get
            {
                return _publicationYear;
            }
            set
            {
                if (typeof(U) == typeof(int))
                {
                    int year = Convert.ToInt32(value);
                    if (year < 0 || year > DateTime.Now.Year)
                    {
                        year = DateTime.Now.Year;
                        _publicationYear = (U)Convert.ChangeType(year, typeof(U));
                        //В данном случае я не понимаю в чем может быть проблема, то есть переводим, проверяем, если нет
                        //то записываем год на дворе, если да, то переводим имеющийся - строка 74
                        //(хотя думаю может как раз тут вопрос), но опять же все работает через _publicationYear, а для элементов не int строка 78

                    }
                    _publicationYear = (U)Convert.ChangeType(year, typeof(U));
                }
                _publicationYear = value;
            }
        }
        public string Author { get; set; }
        public int Page { get; set; }


        public Book(T code, string title, U publicationYear, string author) //string title, string author, string page, T1 code
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
            Page = 60;
        }
        public override string ToString()
        {
            return $"({Code} ({typeof(T)}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U)}))";
        }
        public void Type()
        {
            Console.WriteLine($"Количество страниц: {Page}\nИмя: {Name}\nАвтор: {Author}\nНаименование: {Title}\nКод: {Code} ({typeof(T)})");
        }
    }
    class Notebook<T1> : PaperElements

    {
        public string Name = "Notebook";
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }

        public T1 Code { get; set; }

        public Notebook(string title, string author, int page, T1 code)
        {
            Title = title;
            Author = author;
            Page = page;
            Code = code;
        }

        public void Type()
        {
            Console.WriteLine($"Количество страниц: {Page}\nИмя: {Name}\nАвтор: {Author}\nНаименование: {Title}\nКод: {Code} ({typeof(T1)})");
        }

    }
}



