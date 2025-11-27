using System;
using StarWarsGame.Service.Base;
using StarWarsGame.Service.Impl;

namespace StarWarsGame.Commands
{
    // Команда для запуску складного функціоналу з рівня сервісу (бізнес-логіки)
    public class ComplexBusinessLogicCommand : ICommand
    {
        private readonly PlayerService _ratingService;

        public string Name => "epic-battle";
        public string Description => "Запустити епічну битву (складна бізнес-логіка)";

        public ComplexBusinessLogicCommand(PlayerService ratingService)
        {
            _ratingService = ratingService;
        }

        public void Execute()
        {
            // Викликаємо складний сценарій із сервісу
            _ratingService.RunEpicBattleScenario();
        }
    }
}