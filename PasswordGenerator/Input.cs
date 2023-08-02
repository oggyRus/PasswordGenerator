namespace PasswordGenerator
{
    internal class Input
    {
        public int GetSeed()
        {
            Console.WriteLine("Введите сид генерации: ");
        Label:
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Результат некорректный! Попробуйте написать заново: ");
                goto Label;
            }
        }

        public int GetLength()
        {
            Console.WriteLine("Введите желаемую длину пароля: ");
        }
    }
}