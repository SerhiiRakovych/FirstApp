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
        public static int counter = 0 ;

        private string Name = "";
        private int Age = 0;
        private SexEn Sex = SexEn.NaN;
        public int Size { get; set; }


        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int age
        {
            get { return this.Age; }
            set
            {
                if (value < 14)
                {
                    Console.WriteLine("You are too young for it, Sorry!");
                }
                else
                {
                    this.Age = value;
                }
            }
        }

        public SexEn sex
        {
            get { return this.Sex; }
            set { Console.WriteLine("You can`t change your sex! Remember it!"); }
        }

        public User()
        {
            counter++;
        }

        public User(string nm, int ag, SexEn sx, int sz)
        {
            this.Name = nm;
            this.Age = ag;
            this.Sex = sx;
            this.Size = sz;

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
        public Client()
        {
            Console.WriteLine("Потомок класса User создан");
        }
    }
}