using System;

namespace ConsoleApp1
{
    abstract class Bankomat //абстрактный класс банкомат
    {
        public abstract void adress(); // абстрактный метод 

        public abstract void GetMoney(); // абстрактный метод 

    }
    abstract class BankomatPriorBank : Bankomat //абстрактный класс банкомат приорбанк наследует класс банкомат
    {
        public abstract void GiveBonus(); // абстрактный метод 
    }
    class BankomatPrior : BankomatPriorBank
    {
        public override void adress() // реализация метода adress
        {
            Console.WriteLine("Komsomolskaya street 8");
        }
        public override void GetMoney() // реализация метода GetMoney
        {
            Console.WriteLine("get your money");
        }
        public override void GiveBonus() // реализация метода GiveBonus
        {
            Console.WriteLine("get your Bonus");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankomatPrior bankomatPrior = new BankomatPrior();
            bankomatPrior.adress();
            bankomatPrior.GiveBonus();
            Console.ReadKey();
        }
    }
}
