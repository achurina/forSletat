using System;

namespace TaskTwo
{


    /// Есть базовый класс с реалиазцией двух интерфейсов, имеющих одинаковый метод
    /// строка var @base = new Base(); - создаёт объект типа Base
    /// вызов @base.WriteExecutor()    - выводит на экран строку I base Executor!
    ///
    /// Дополните код так, чтобы не создавая новый объект на экран было выведено
    ///
    /// I base Executor!
    /// I one Executor!
    /// I two Executor!

    interface IOneExecutor
    {
        void WriteExecutor(string executor);
    }

    interface ITwoExecutor
    {
        void WriteExecutor(string executor);
    }

    class Base : IOneExecutor, ITwoExecutor
    {
        public void WriteExecutor(string executor)
        {
            Console.WriteLine("I " + executor + " Executor!");
        }
    }

    

    class Program
    {
        static void Main()
        {
            var @base = new Base();
            @base.WriteExecutor("base");
            @base.WriteExecutor("one");
            @base.WriteExecutor("two");
        }
    }
}
