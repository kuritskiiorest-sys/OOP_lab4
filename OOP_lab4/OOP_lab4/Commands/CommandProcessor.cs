using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWarsGame.Commands
{
    // Клас, який обробляє команди користувача з консолі.
    public class CommandProcessor
    {
        // Список усіх доступних команд
        private readonly List<ICommand> _commands = new List<ICommand>();

        // Реєстрація нової команди
        public void Register(ICommand command)
        {
            _commands.Add(command);
        }

        // Головний цикл взаємодії з користувачем
        public void Start()
        {
            Console.WriteLine("StarWars Game Console ");
            Console.WriteLine("Введіть 'help' для перегляду доступних команд.");
            Console.WriteLine("Введіть 'exit' для виходу.");

            while (true)
            {
                Console.Write("\ncommand> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                if (input.Equals("help", StringComparison.OrdinalIgnoreCase))
                {
                    PrintHelp();
                    continue;
                }

                // Знаходимо команду за її Name
                var command = _commands.FirstOrDefault(c => c.Name.Equals(input, StringComparison.OrdinalIgnoreCase));

                if (command == null)
                {
                    Console.WriteLine("Невідома команда. Введіть 'help' щоб побачити список.");
                }
                else
                {
                    try
                    {
                        command.Execute();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка під час виконання команди: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("Завершення роботи консольної системи команд.");
        }

        // Вивести список доступних команд
        private void PrintHelp()
        {
            Console.WriteLine("\nДоступні команди:");
            foreach (var cmd in _commands)
            {
                Console.WriteLine($" - {cmd.Name} : {cmd.Description}");
            }
        }
    }
}
