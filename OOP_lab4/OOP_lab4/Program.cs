using System;
using StarWarsGame.Commands;
using StarWarsGame.Database;
using StarWarsGame.Repository;
using StarWarsGame.Repository.Base;
using StarWarsGame.Repository.Impl;
using StarWarsGame.Service;
using StarWarsGame.Service.Base;
using StarWarsGame.Service.Impl;

namespace StarWarsGame
{
    // Головний клас програми
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлюємо кодування консолі, щоб коректно показувалися українські символи
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Створюємо "базу даних"
            var dbContext = new StarWarsDbContext();

            // 2. Створюємо репозиторій для гравців
            IPlayerRepository playerRepository = new PlayerRepository(dbContext);

            // 3. Створюємо сервіс гравців, який використовує репозиторій і DbContext
            PlayerService playerService = new PlayerService(playerRepository, dbContext);

            // 4. Створюємо обробник команд
            var commandProcessor = new CommandProcessor();

            // 5. Реєструємо доступні команди
            commandProcessor.Register(new ShowPlayersCommand(playerService));         // відображення даних
            commandProcessor.Register(new AddPlayerCommand(playerService));          // додавання нових даних
            commandProcessor.Register(new ComplexBusinessLogicCommand(playerService)); // виклик складної логіки

            // 6. Запускаємо "консоль команд"
            commandProcessor.Start();

            // Кінець програми
            Console.WriteLine("Завершення роботи. Натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}