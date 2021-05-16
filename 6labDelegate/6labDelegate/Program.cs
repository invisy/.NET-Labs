using System;

namespace _6labDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            int rating = 1000;
            User user = new User(age,rating);
            //Анонімний метод
            NewUserNotification notification = delegate (int age, int rating)
            {
                string message = $"Створено користувача віком {age}, та рейтингом {rating}";
                Console.WriteLine(message);
                return message;
            };
            notification(age, rating);
            //Сервіс перевірки віку
            AgeService ageService = new AgeService(user);
            //Створення делегату і його перевірка
            ageService.DoesNeedDenyAccess();
            ageService.check();
            //Сервіс перевірки рейтингу
            RatingService ratingService = new RatingService(user);
            //Подія та її обробник
            ratingService.Info += NotifyInfo;
            ratingService.IncreaseRating(5);
            ratingService.DecreaseRating(3);
            ratingService.IncreaseRating(5);
            //Лямбда-оператор
            Console.WriteLine("Нинішній вік користувача:" + user.Age);
            user.Age = ageService.increment(user.Age);
            Console.WriteLine("Тепер вік користувача становить:" + user.Age);
            //Лямбда-вираз
            Console.WriteLine("Нинішній рейтинг користувача:" + user.Rating);
            user.Rating = ratingService.multiplyRating(user.Rating);
            Console.WriteLine("Тепер рейтинг користувача становить:"+user.Rating);
            Console.ReadLine();
        }
        //Анонімний метод
        delegate string NewUserNotification(int age, int rating);
        private static void NotifyInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
