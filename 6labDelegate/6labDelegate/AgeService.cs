using System;
using System.Collections.Generic;
using System.Text;

namespace _6labDelegate
{
    public class AgeService
    {
    public AgeService(User user) 
    {
     _user = user;
    }
    private User _user;
    //Лямбда-оператор
    public YearAgeIncrement increment = (age) => { return age + 1; };
    public CheckUserAge check;
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
    }
    public delegate void CheckUserAge();
    public delegate int YearAgeIncrement(int age);
}
