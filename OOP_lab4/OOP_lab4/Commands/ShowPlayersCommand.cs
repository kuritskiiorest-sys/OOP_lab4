using System;
using StarWarsGame.Service.Base;

namespace StarWarsGame.Commands
{
    // Команда для відображення списку гравців
    public class ShowPlayersCommand : ICommand
    {
        private readonly IPlayerService _playerService;

        public string Name => "show-players";
        public string Description => "Показати всіх гравців";

        public ShowPlayersCommand(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.WriteLine("Список гравців");

            var players = _playerService.GetAllPlayers();

            foreach (var p in players)
            {
                Console.WriteLine($"[{p.Id}] {p.Name} | Фракція: {p.AccountType} | Рейтинг: {p.Rating}");
            }
        }
    }
}