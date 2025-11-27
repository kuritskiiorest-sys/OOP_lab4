using System;
using StarWarsGame.Service.Base;

namespace StarWarsGame.Commands
{
    // Команда для додавання нового гравця
    public class AddPlayerCommand : ICommand
    {
        private readonly IPlayerService _playerService;

        public string Name => "add-player";
        public string Description => "Додати нового гравця";

        public AddPlayerCommand(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.Write("Введіть ім'я нового гравця: ");
            string name = Console.ReadLine();

            Console.Write("Введіть тип акаунта (1=JediOrder, 2=GalacticEmpire, 3=RebelAlliance): ");
            string typeInput = Console.ReadLine();

            if (!int.TryParse(typeInput, out int accountTypeId))
            {
                Console.WriteLine(" Невірний тип акаунта.");
                return;
            }

            _playerService.AddPlayer(name, accountTypeId);
            Console.WriteLine("Гравця успішно додано.");
        }
    }
}