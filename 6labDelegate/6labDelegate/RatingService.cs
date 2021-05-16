using System;
using System.Collections.Generic;
using System.Text;

namespace _6labDelegate
{
    public class RatingService
    {
        private User _user;
        public RatingService(User user) 
        {
            _user = user;
        }
        public delegate void RatingHandler(string message);
        public event RatingHandler Info;
        //Лямбда-вираз
        public MultiplyRating multiplyRating = rating => rating * 10;

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
    }
    public delegate int MultiplyRating(int rating);
}
