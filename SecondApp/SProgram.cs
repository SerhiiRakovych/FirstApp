using System;
using MyLib;

namespace SecondApp
{
    class SProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECOND APP CODE \n--------------------------------------");

            User BOB = new User("BOB", 22, SexEn.Male, 40);
            User Mike = new User("Mike", 45, SexEn.Female, 42);
            User Lily = new User("Lily", 25, SexEn.Female, 36);
            User Jane = new User("Jane", 18, SexEn.NaN, 34);



            BOB.GetInfo();
            Mike.GetInfo();
            Lily.GetInfo();
            Jane.GetInfo();

            BOB.name = "Марк";
            BOB.age = 10;
            BOB.sex = SexEn.NaN;
            BOB.Size = 38;

            BOB.GetInfo();

            //Инициализатор---------------------
            //User Lisa = new User { Name = "Лиза", Age = 16, Sex = SexEn.Female, 31 };
            //Lisa.GetInfo();

            User.GetUserCount();

            Console.ReadKey();

        }
    }
}
