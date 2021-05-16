using System;
using System.Collections.Generic;
using System.Text;

namespace _6labDelegate
{
    public class User
    {
        public User(int age, int rating) 
        {
            Age = age;
            Rating = rating;
        }
        public int Age { get; set; }
        public int Rating { get; set; }
    }
}
