using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Generator
    {
        private readonly string SYMBOLS = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()+-/|\\<>";
        private Random random = new Random();

        public Generator(int seed)
        {
            random = new Random(seed);
        }
        public Generator()
        {
            random = new Random();
        }
        public string Generate(int length)
        {
            StringBuilder password = new StringBuilder();
            Console.WriteLine("Введите кол-во символов в вашем пароле (минимум 8 символов): ");
            string numbersOfCharacters = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(SYMBOLS.Length);
                password.Append(SYMBOLS[index]);
            }
            return password.ToString();
        }
    }
}
