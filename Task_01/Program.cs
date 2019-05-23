using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TaskOne
{

    /// задача №1
    /// необходимо просуммировать все найденные числа
    /// исправить потенциальную ошибку
    ///
    /// задачу необходимо реализовать, дописав код, чтобы data.GetDigits() стал работоспособным

    class Program
    {

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            string data = RandomString(5);
            byte summary = 0;

            foreach (byte digit in StringExtension.GetDigits(data))
            {
                summary += digit;
            }

            Console.WriteLine($"{data} => {summary}");
        }
    }

    public static class StringExtension
    {
        public static List<byte> GetDigits(this string source)
        {
            List<byte> value = new List<byte>();

            foreach (var s in source)
            {
                if (char.IsDigit(s))
                {
                    value.Add((byte)char.GetNumericValue(s));
                }
            }

            return value;
        }
    }
}
