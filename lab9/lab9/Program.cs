using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader1 = new ReaderPro("вип", 1, "Семенов", "Игорь", "Евгеньевич", "муж", "79835000000");
            Book Book = new Book(1, "Пушкин", "Руслан и Людмила", "Поэма");
            Exemplar exemplar1 = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position1 = new Position(1, "Библиотекарь");
            Employee employee = new Employee(1, position1, "Петрова", "Людмила", "Сергеевна", "345678892000", 4, "Киров", "Попова", "6");
            Delivery delivery1 = new Delivery(1, employee, reader1, exemplar1);


            IReader reader2 = new ReaderSimple("обычный", 2, "Крючкова", "Антонина", "Александровна", "жен", "79835000000");
            Book Book2 = new Book(1, "Лермонтов", "Мцыри", "Поэма");
            Exemplar exemplar2 = new Exemplar(2, Book, DateTime.Now, "Exmo");
            Position position2 = new Position(1, "Библиотекарь");
            Delivery delivery2 = new Delivery(2, employee, reader2, exemplar2);

            IReader reader3 = new ReaderPro("вип", 3, "Капустин", "Константин", "Евгеньевич", "муж", "75683500000");
            Book Book3 = new Book(1, "Толстой", "Война и мир", "Роман");
            Exemplar exemplar3 = new Exemplar(3, Book, DateTime.Now, "Exmo");
            Position position3 = new Position(1, "Библиотекарь");
            Delivery delivery3 = new Delivery(3, employee, reader3, exemplar3);

            IReader reader4 = new ReaderPro("обычный", 4, "Раскольников", "Валентин", "Семенович", "муж", "31525000000");
            Book Book4 = new Book(1, "Есенин", "Сборник стихов", "Стихотворения");
            Exemplar exemplar4 = new Exemplar(4, Book, DateTime.Now, "Exmo");
            Position position4 = new Position(1, "Библиотекарь");
            Delivery delivery4 = new Delivery(4,  employee, reader4, exemplar4);

            IReader reader5 = new ReaderPro("обычный", 5, "Зюзина", "Ольга", "Николаевна", "жен", "31725000000");
            Book Book5 = new Book(1, "Достоевский", "Преступение и наказание", "Роман");
            Exemplar exemplar5 = new Exemplar(5, Book, DateTime.Now, "Exmo");
            Position position5 = new Position(1, "Библиотекарь");
            Delivery delivery5 = new Delivery(5, employee, reader5, exemplar5);

            IReader reader6 = new ReaderPro("вип", 6, "Лапшина", "Ирина", "Георгиевна", "жен", "36225000000");
            Book Book6 = new Book(1, "Пришвин", "Рассказы", "Рассказы");
            Exemplar exemplar6 = new Exemplar(5, Book, DateTime.Now, "Exmo");
            Position position6 = new Position(1, "Библиотекарь");
            Delivery delivery6 = new Delivery(5, employee, reader6, exemplar6);

            DateTime start = new DateTime(2018, 05, 6);
            DateTime end = new DateTime(2019, 12, 31);
            List<Delivery> ListDelivery = new List<Delivery>();
            ListDelivery.Add(delivery1);
            ListDelivery.Add(delivery2);
            ListDelivery.Add(delivery3);
            ListDelivery.Add(delivery4);
            ListDelivery.Add(delivery5);
            ListDelivery.Add(delivery6);

            List<IReader> ListReader = new List<IReader>();
            ListReader.Add(reader1);
            ListReader.Add(reader2);
            ListReader.Add(reader3);
            ListReader.Add(reader4);
            ListReader.Add(reader5);
            ListReader.Add(reader6);
            foreach (IReader date in ListReader)
            {
                date.Info();
                Console.WriteLine(" ");
            }
            Console.WriteLine("Сортировать читателей по полу?(да, нет)");
            string g = Console.ReadLine();
            if (g == "да")
            {
                Console.WriteLine("мужчины-'муж', женщины-'жен':");
                string gen = Console.ReadLine();
                foreach (IReader date in ListReader.Where(i => i.Gender == gen))
                {
                    //Console.WriteLine(date.Surname + date.Name + date.Patronymic);
                    date.Info();
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Для просмотра информации по выдаче конкретному читателю введите его фамилию:");
                string family = Console.ReadLine();
                foreach (Delivery date in ListDelivery.Where(i => i.ReaderDelivery.Surname == family))
                {
                    //Console.WriteLine(date.Surname + date.Name + date.Patronymic);
                    date.Info();
                    Console.WriteLine(" ");
                }
            }

            else if (g == "нет")
            {
                Console.WriteLine("Для просмотра информации по выдаче книги конкретному читателю введите его фамилию:");
                string family2 = Console.ReadLine();
                foreach (Delivery date in ListDelivery.Where(i => i.ReaderDelivery.Surname == family2))
                {
                    //Console.WriteLine(date.Surname + date.Name + date.Patronymic);
                    date.Info();
                    Console.WriteLine(" ");
                }

            }
            Console.ReadLine();
        }
    }
}