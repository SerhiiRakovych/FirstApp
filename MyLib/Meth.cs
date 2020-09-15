using System;

namespace MyLib
{
    public enum SexEn
    {
        Male, Female, NaN
    }
    public static class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subst(int x, int y)
        {
            int res = 0;
            res = (x > y) ? (x - y) : (y - x);
            return res;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static double Devide(int x, int y)
        {
            return x / y;
        }
    }

    public class User
    {
        public static int counter = 0;

        public string Name { get; set; } = "";

        public int Age
        {
            get { return Age; }
            set
            {
                if (value < 14)
                {
                    Console.WriteLine("You are too young for it, Sorry!");
                }
                else
                {
                    Age = value;
                }
            }
        }

        public SexEn Sex
        {
            get { return this.Sex; }
            set { Console.WriteLine("You can`t change your sex! Remember it!"); }
        }

        public int Size { get; set; } = 0;


        public User()
        {
            counter++;
        }

        public User(string nm, int ag, SexEn sx, int sz)
        {
            Name = nm;
            Age = ag;
            Sex = sx;
            Size = sz;

            counter++;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Name:{this.Name}, Age: {this.Age}, Sex: {Sex}, Size: {Size}");
        }

        public static void GetUserCount()
        {
            Console.WriteLine($"Создано {counter} пользователей.");
        }
    }

    public class Client : User
    {
        public string Position { get; set; }
        public int? Salary { get; set; }
        public Client()
        {
            Console.WriteLine("Потомок класса User создан");
        }

        public new void GetInfo()
        {
            Console.WriteLine($"Name:{Name}\nAge: {Age}\nSex: {Sex}\nSize: {Size}\nPosition: {Position}\nSalary: {Salary}");
        }
    }
}