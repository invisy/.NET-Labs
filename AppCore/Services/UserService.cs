using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Entities;

namespace AppCore.Services
{
    public class UserService
    {
        public UserService(Passenger user)
        {
            _user = user;
            notification(_user.Age,_user.Rating);
        }
        private Passenger _user;
        //Лямбда-оператор
        public YearAgeIncrement increment = (age) => { return age + 1; };
        public CheckUserAge check;
        public event RatingHandler Info;
        public void DoesNeedDenyAccess()
        {
            if (_user.Age >= 18)
            {
                check = AppropriateAge;
            }
            else if (_user.Age < 18)
            {
                check = InAppropriateAge;
            }
        }
        private void AppropriateAge()
        {
            Console.WriteLine("Доступ надано");
        }
        private void InAppropriateAge()
        {
            Console.WriteLine("Доступ заблоковано");
        }

        public void IncreaseRating(int value)
        {
            _user.Rating += value;
            Info?.Invoke($"Рейтинг користувача підвищено на {value}");
        }
        public void DecreaseRating(int value)
        {
            _user.Rating -= value;
            Info?.Invoke($"Рейтинг користувача знижено на {value}");
        }
        //Анонімний метод
        public NewUserNotification notification = delegate (int age, int rating)
        {
            string message = $"Створено користувача віком {age}, та рейтингом {rating}";
            Console.WriteLine(message);
            return message;
        };
        //Лямбда-вираз
        public MultiplyRating multiplyRating = rating => rating * 10;
    }
    public delegate void CheckUserAge();
    public delegate int YearAgeIncrement(int age);
    public delegate void RatingHandler(string message);
    public delegate int MultiplyRating(int rating);
    //Делегат для оголошення анонімного методу
    public delegate string NewUserNotification(int age, int rating);
}
