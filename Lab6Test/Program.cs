using System;
using AppCore.Services;
using OurAirlines.AppCore.Entities

namespace DelegatesShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger user = new Passenger() { Age = 19, Rating = 100 };
            UserService service = new UserService();
            //Створення делегату і його перевірка
            service.DoesNeedDenyAccess();
            service.check();
            //Подія та її обробник
            service.Info += NotifyInfo;
            service.IncreaseRating(5);
            service.DecreaseRating(3);
            //Лямбда-оператор
            Console.WriteLine("Нинішній вік користувача:" + user.Age);
            user.Age = service.increment(user.Age);
            Console.WriteLine("Тепер вік користувача становить:" + user.Age);
            //Лямбда-вираз
            Console.WriteLine("Нинішній рейтинг користувача:" + user.Rating);
            user.Rating = service.multiplyRating(user.Rating);
            Console.WriteLine("Тепер рейтинг користувача становить:" + user.Rating);
            Console.ReadLine();
        }
        private static void NotifyInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
